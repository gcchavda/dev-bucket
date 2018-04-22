using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zetalex.AutoNotifier.Helpers;
using Zetalex.AutoNotifier.Models;

namespace Zetalex.AutoNotifier.Helpers
{
    public static class JobFactory
    {
        public static List<JobModel> GetAllJobs()
        {
            List<JobModel> lst = new List<JobModel>();
            ApplicationDBConnection connection = new ApplicationDBConnection();
            List<Dictionary<String, Object>> result = connection.getQueryResults("SELECT * FROM rule_base WHERE isActive=1");

            foreach(Dictionary<String, Object> res in result)
            {
                Object id, ruleName, tableName, timeInterval, lastProcessedId,statustime;
                res.TryGetValue("id", out id);
                res.TryGetValue("ruleName", out ruleName);
                res.TryGetValue("tableName", out tableName);
                res.TryGetValue("timeInterval", out timeInterval);
                res.TryGetValue("lastProcessedId", out lastProcessedId);
                res.TryGetValue("statustime", out statustime);

                JobModel jobModel = new JobModel();
                jobModel.Number =  (int) id;
                jobModel.Name = "job" + jobModel.Number;
                jobModel.JobType = Type.GetType("Zetalex.AutoNotifier.Jobs.NotifierJob");
                jobModel.Interval = Int16.Parse(timeInterval.ToString());
                jobModel.lastProcessedId = (double)lastProcessedId;


                JobModel jobModelRoutine = new JobModel();
                jobModelRoutine.Number = (int)id;
                jobModelRoutine.Name = "job_status" + jobModel.Number;
                jobModelRoutine.JobType = Type.GetType("Zetalex.AutoNotifier.Jobs.RoutineStatusJob");
                jobModelRoutine.Interval = Int16.Parse(statustime.ToString()) * 60;
                jobModelRoutine.lastProcessedId = (double)lastProcessedId;

                lst.Add(jobModel);
                //lst.Add(jobModelRoutine);
            }

            List<Dictionary<String, Object>> healthStatusTimeResult = connection.getQueryResults("SELECT statustime FROM general_settings WHERE id=1");
            Object statustime1;
            healthStatusTimeResult[0].TryGetValue("statustime", out statustime1);
            String[] statusSplit1 = statustime1.ToString().Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            JobModel jobModelHealth = new JobModel();
            jobModelHealth.Number = 999;
            jobModelHealth.Name = "job_app_health";
            jobModelHealth.JobType = Type.GetType("Zetalex.AutoNotifier.Jobs.AppHealthJob");
            jobModelHealth.DailyAtHour = Int16.Parse(statusSplit1[0]);
            jobModelHealth.DailyAtMinute = Int16.Parse(statusSplit1[1]);
            jobModelHealth.lastProcessedId = -1;

            
            lst.Add(jobModelHealth);


            return lst;
        }
    }
}
