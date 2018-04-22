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
    class AppHealthJob : BaseJob, IJob
    {
        public AppHealthJob(ILifetimeScope lifetimeScope, DAL.IUnitOfWork unitOfWork)
            : base(lifetimeScope, unitOfWork)
        {
        }
        public async Task Execute(IJobExecutionContext context)
        {
            Logger.Info("Triggering daily application health status job");
            ApplicationDBConnection dBConnection = new ApplicationDBConnection();
            List<Dictionary<String,Object>> result = dBConnection.getQueryResults("SELECT ruleName, tableName, lastProcessedId FROM rule_base WHERE isActive=1 AND lastProcessedId!=-1");
            String clientConnectionString = Utility.GetClientConnectionString(dBConnection);
            ClientDBConnection clientConnection = new ClientDBConnection(clientConnectionString);
            String msg = "";
            for(int i=0;i<result.Count;i++)
            {
                Object ruleName, tableName, lastProcessedId;
                result[i].TryGetValue("ruleName",out ruleName);
                result[i].TryGetValue("tableName", out tableName);
                result[i].TryGetValue("lastProcessedId", out lastProcessedId);

                Object maxId;
                clientConnection.getQueryResults("SELECT MAX(RecNo) as id FROM " + tableName)[0].TryGetValue("id", out maxId);
                if((((double)maxId) - ((double)lastProcessedId)) > 25)
                {
                    msg = msg + ruleName + "\n";
                }
            }
            if(msg!="")
            {
                msg = msg + "\n" + "verify logs, above rules are facing errors";
            }
            else
            {
                msg = "All the active rules are working as expected";
            }

            Logger.Info("Checking internet connectivity by ping : google.com");
            if (Utility.checkConnectivity())
            {
                Logger.Info("Internet connectivity found");
                Utility.sendSMSs(new List<String> { msg }, -999, dBConnection,3);
                Utility.sendEmails(new List<String> { msg }, -999, "Auto Notifier : Application Health", dBConnection,3);
            }
            else
            {
                Logger.Info("Internet connectivity is not available, hence daily health messages can not be sent");
                return;
            }

        }
    }
}
