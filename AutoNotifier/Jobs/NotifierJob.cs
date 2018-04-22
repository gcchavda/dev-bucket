using Autofac;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zetalex.AutoNotifier.Helpers;
using AutoNotifier.Models;


namespace Zetalex.AutoNotifier.Jobs
{
    public class NotifierJob : BaseJob, IJob
    {
        public NotifierJob(ILifetimeScope lifetimeScope, DAL.IUnitOfWork unitOfWork)
            : base(lifetimeScope, unitOfWork)
        {
        }
        public async Task Execute(IJobExecutionContext context)
        {
            int ruleId = (int)context.MergedJobDataMap["rule_id"];
            double lastProcessedId = (double)context.MergedJobDataMap["lastProcessedId"];

            ApplicationDBConnection dbConnection = new ApplicationDBConnection();
            ClientDBConnection clientConnection = new ClientDBConnection(Utility.GetClientConnectionString(dbConnection));

            List<Dictionary<String, Object>> criteria = dbConnection.getQueryResults("SELECT a.ruleName,a.tableName,a.lastProcessedId, b.columnName, b.criteria, c.regular_sms, c.email_subject FROM rule_base a, rule_details b, text_templates c WHERE a.id=" + ruleId + " AND b.rule_id=" + ruleId + " AND c.rule_id=" + ruleId);
            Object tableName = null, ruleName = null, lastProcessed = null, regular_sms=null, email_subject=null;    
            criteria[0].TryGetValue("tableName", out tableName);
            criteria[0].TryGetValue("ruleName", out ruleName);
            criteria[0].TryGetValue("lastProcessedId", out lastProcessed);
            criteria[0].TryGetValue("regular_sms", out regular_sms);
            criteria[0].TryGetValue("email_subject", out email_subject);
            lastProcessedId = (double)lastProcessed;



            Logger.Info("Starting job execution for rule_id : " + ruleId + " , rule name : " + ruleName.ToString() + " on table : " + tableName.ToString() + ", last processed id was : " + lastProcessedId) ;
            Object maxId;
            clientConnection.getQueryResults("SELECT MAX(RecNo) as id FROM " + tableName)[0].TryGetValue("id", out maxId);
            if (lastProcessedId == -1)
            {
                Logger.Info("Job is running first time or there is no data in table, hence starting from latest record");
                lastProcessedId = (double)maxId;
            }

            try
            {
                List<ColumnProcessingDetails> queries = processCriteriaAndGenerateQuery(criteria, tableName.ToString(), ruleName.ToString(), lastProcessedId);
                List<String> msgs = prepareMessageContents(executeAndPrepareViolations(queries, clientConnection), regular_sms.ToString());
                if(msgs.Count==0)
                {
                    Logger.Info("There is no violations in this execution");
                    markLastProcessedId((double)maxId, ruleId, dbConnection);
                }
                else
                {
                    Logger.Info("Checking internet connectivity by ping : google.com");
                    if(Utility.checkConnectivity())
                    {
                        Logger.Info("Internet connectivity found");
                        
                        try
                        {
                            Utility.sendSMSs(msgs, ruleId, dbConnection, 1);
                            Utility.sendEmails(msgs, ruleId, email_subject.ToString(), dbConnection, 1);    
                        }catch(Exception e)
                        {
                            Logger.Error("Error occurred while sending sms/email (program will resend notification in next execution. " + e.Message);
                            return;
                        }
                        markLastProcessedId((double)maxId, ruleId, dbConnection);
                    }
                    else
                    {
                        Logger.Info("Internet connectivity is not available, hence violation messages can not be sent");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                Logger.Error(ex);
                throw new AutoNotifierException(ex.Message);
            }

            Logger.Info("Exiting for job rule_id : " + ruleId + " , rule name : " + ruleName.ToString() + " on table : " + tableName.ToString());
        }


       

        private void markLastProcessedId(double lastProcessedId, int rule_id, ApplicationDBConnection dBConnection)
        {
            dBConnection.Update("UPDATE rule_base set lastProcessedId=" + lastProcessedId + " where id=" + rule_id);
        }

        

        private List<ColumnProcessingResults> executeAndPrepareViolations(List<ColumnProcessingDetails> columnProcessingDetails, ClientDBConnection clientConnection)
        {
            Dictionary<String, List<String>> violationDetails = new Dictionary<string, List<string>>();
            List<ColumnProcessingResults> results = new List<ColumnProcessingResults>();
            for(int i=0;i<columnProcessingDetails.Count;i++)
            {
                List<Dictionary<String,Object>> result = clientConnection.getQueryResults(columnProcessingDetails[i].query);
                for(int j=0;j<result.Count;j++)
                {
                    Dictionary<String, Object> row = result[j];
                    Object recNo;
                    row.TryGetValue("RecNo", out recNo);
                    ColumnProcessingResults res = new ColumnProcessingResults();
                    res.RecNo = recNo.ToString();
                    List<EachColumnResult> lstEachColRes = new List<EachColumnResult>();
                    foreach (KeyValuePair<string, Object> entry in row)
                    {
                        
                        if(entry.Key!= "RecNo")
                        {
                            EachColumnResult colRes = new EachColumnResult();
                            colRes.columnName = entry.Key;
                            colRes.criteria = columnProcessingDetails[i].criteria;
                            colRes.currentValue = entry.Value.ToString();
                            lstEachColRes.Add(colRes);
                        }
                    }
                    res.colResults = lstEachColRes;
                    results.Add(res);
                }
            }
            return results;
        }

        private List<String> prepareMessageContents(List<ColumnProcessingResults> violationDetails, String msgTemplate)
        {
            List<String> messages = new List<string>();
            foreach(ColumnProcessingResults result in violationDetails)
            {
                foreach(EachColumnResult ecr in result.colResults)
                {
                    String msg = msgTemplate;
                    msg = msg.Replace("@RecNo@", result.RecNo);
                    msg = msg.Replace("@ColumnName@", ecr.columnName);
                    msg = msg.Replace("@Criteria@", ecr.criteria);
                    msg = msg.Replace("@PresentValue@", ecr.currentValue);
                    Logger.Info(msg);
                    messages.Add(msg);
                }
            }
            return messages;
        }

        private List<ColumnProcessingDetails> processCriteriaAndGenerateQuery(List<Dictionary<String, Object>> criterias, String tableName, String ruleName, double lastProcessedId)
        {
            List<ColumnProcessingDetails> allQueries = new List<ColumnProcessingDetails>();
            try
            {
                for(int i=0;i<criterias.Count;i++)
                {
                    ColumnProcessingDetails detail = new ColumnProcessingDetails();
                    Object columnName, criteria;
                    criterias[i].TryGetValue("columnName", out columnName);
                    criterias[i].TryGetValue("criteria", out criteria);
                    String query = "Select RecNo, " + columnName.ToString() + " from " + tableName + " where RecNo > "  + lastProcessedId + " AND (" + getWhereCondition(columnName.ToString(), criteria.ToString()) + ")";
                    detail.query = query;
                    detail.columnName = (string)columnName;
                    detail.criteria = (string)criteria;
                    allQueries.Add(detail);
                }
                return allQueries;
            }catch(Exception e)
            {
                Logger.Error("Error occured while generating where condition : please check configured criteria for rule " + ruleName);
                throw new AutoNotifierException("Error occured while generating where condition : please check configured criteria for rule " + ruleName);
            }
        }

        private String getWhereCondition(String columnName, String criteria)
        {
            String condition = "";
            if (criteria.Contains("AND"))
            {
                // <5 AND >8 , <-2 AND >= 5, <-2 AND = 3
                String[] parts = criteria.Split("AND".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                for(int i=0;i<parts.Length;i++)
                {
                    if (i > 0)
                        condition = condition + " AND ";
                    condition = condition + " " + getConditionPart(columnName, parts[i]);
                }
                return condition;
            }else if(criteria.Contains("OR"))
            {
                String[] parts = criteria.Split("OR".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < parts.Length; i++)
                {
                    if (i > 0)
                        condition = condition + " OR ";
                    condition = condition + " " + getConditionPart(columnName, parts[i]);
                }
                return condition;
            }
            else
            {
                return getConditionPart(columnName, criteria);
            }
        }

        private String getConditionPart(String columnName, String part)
        {
            part = part.Replace(" ", "");
            if(part.StartsWith("="))
            {
                return columnName + " = '" + part.Substring(part.IndexOf('=') + 1) + "'";
            }
            else
            {
                return columnName + part;
            }
        }
    }
}
