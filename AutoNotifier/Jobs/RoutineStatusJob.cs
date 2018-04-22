using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zetalex.AutoNotifier.Helpers;
using AutoNotifier.Models;
using System.Net.NetworkInformation;
using Autofac;
using Quartz;

namespace Zetalex.AutoNotifier.Jobs
{
    class RoutineStatusJob : BaseJob, IJob
    {
        public RoutineStatusJob(ILifetimeScope lifetimeScope, DAL.IUnitOfWork unitOfWork)
            : base(lifetimeScope, unitOfWork)
        {
        }
        public async Task Execute(IJobExecutionContext context)
        {
            int ruleId = (int)context.MergedJobDataMap["rule_id"];


            ApplicationDBConnection dbConnection = new ApplicationDBConnection();
            ClientDBConnection clientConnection = new ClientDBConnection(Utility.GetClientConnectionString(dbConnection));

            List<Dictionary<String, Object>> criteria = dbConnection.getQueryResults("SELECT a.ruleName,a.tableName, b.columnName, c.routine_sms, c.email_subject FROM rule_base a, rule_details b,text_templates c WHERE a.id=" + ruleId + " AND b.rule_id=" + ruleId + " AND c.rule_id="+ ruleId);
            Object tableName = null, ruleName = null, routine_sms = null, email_subject=null;
            criteria[0].TryGetValue("tableName", out tableName);
            criteria[0].TryGetValue("ruleName", out ruleName);
            criteria[0].TryGetValue("routine_sms", out routine_sms);
            criteria[0].TryGetValue("email_subject", out email_subject);



            Logger.Info("Starting job execution for rule_id : " + ruleId + " , rule name : " + ruleName.ToString() + " on table : " + tableName.ToString());
            String statusMsg = getStatusMessage(tableName.ToString(), routine_sms.ToString(), criteria, clientConnection);
            Logger.Info("Checking internet connectivity by ping : google.com");
            if (Utility.checkConnectivity())
            {
                Logger.Info("Internet connectivity found");
                Utility.sendSMSs(new List<String> { statusMsg }, ruleId, dbConnection,2);
                Utility.sendEmails(new List<String> { statusMsg }, ruleId, email_subject.ToString(), dbConnection,2);
            }
            else
            {
                Logger.Info("Internet connectivity is not available, hence violation messages can not be sent");
                return;
            }
        }

        private String getStatusMessage(String tableName, String routine_sms, List<Dictionary<String, Object>> criteria, ClientDBConnection clientConnection)
        {
            String query = "Select ";
            for(int i=0;i<criteria.Count;i++)
            {
                Object columnName;
                criteria[i].TryGetValue("columnName", out columnName);
                if(i>0)
                    query = query + ", ";
                query = query + columnName.ToString();
            }
            query = query + " From " + tableName + " Where RecNo = (select MAX(RecNo) from " + tableName + ")";
            return prepareMessage(routine_sms, clientConnection.getQueryResults(query));
        }

        private String prepareMessage(String routine_sms, List<Dictionary<String, Object>> result)
        {
            String statusMessage = routine_sms + "\n";
            foreach (KeyValuePair<String, Object> entry in result[0])
            {
                statusMessage = statusMessage + entry.Key + ":" + entry.Value.ToString() + "\n";
            }
            Logger.Info("Routine Status Msg = " + statusMessage);
            return statusMessage;
        }
        
    }
}
