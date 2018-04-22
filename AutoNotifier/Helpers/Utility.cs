using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Specialized;
using System.Web;
using System.Net.Mail;

    
namespace Zetalex.AutoNotifier.Helpers
{
    public class Utility
    {
        public static String GetClientConnectionString(ApplicationDBConnection dbConnection)
        {
            List<Dictionary<String, Object>> result = dbConnection.getQueryResults("SELECT * FROM db_connection");

            Object hostname, username, password, port, dbname;
            result[0].TryGetValue("hostname", out hostname);
            result[0].TryGetValue("port", out port);
            result[0].TryGetValue("username", out username);
            result[0].TryGetValue("password", out password);
            result[0].TryGetValue("dbname", out dbname);
            return "SERVER = " + hostname.ToString() + "; PORT = " + port.ToString() + "; DATABASE = " + dbname.ToString() + "; UID = " + username.ToString() + "; PASSWORD = " + password.ToString() + "; SslMode = none";
        }

        public static bool checkConnectivity()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void sendSMSs(List<String> msgs, int rule_id, ApplicationDBConnection dBConnection, int type)
        {
            List<String> contacts = new List<string>();
            if (type != 3)
            {
                contacts = getContactsOnRule(rule_id, dBConnection, "MOBILE");
            }
            else
            {
                contacts.Add(getAdminContact(dBConnection)[1]);
            }
            if (contacts.Count == 0)
                return;
            List<Dictionary<String, Object>> smsSettings = dBConnection.getQueryResults("SELECT * FROM sms_settings WHERE id=1");
            Object url, sendername, password;
            smsSettings[0].TryGetValue("url", out url);
            smsSettings[0].TryGetValue("sendername", out sendername);
            smsSettings[0].TryGetValue("password", out password);

            for (int i = 0; i < msgs.Count; i++) { 
            String message = HttpUtility.UrlEncode(msgs[i]);
                using (var wb = new WebClient())
                {
                    byte[] response = wb.UploadValues(url.ToString(), new NameValueCollection()
                    {
                    {"apikey" , password.ToString()},
                    {"numbers" , getCSVFromList(contacts)},
                    {"message" , message},
                    //{"sender" , sendername.ToString()}
                    });
                    string result = System.Text.Encoding.UTF8.GetString(response);
                    if (result.Contains("errors") || result.Contains("failure"))
                    {
                        throw new AutoNotifierException("Error occured while sending sms, server response :: " + result);
                    }
                }
            }

        }

        private static String getCSVFromList(List<String> contacts)
        {
            String contactStr = "";
            for(int i=0;i<contacts.Count;i++)
            {
                if (i > 0)
                    contactStr = contactStr + ",";
                contactStr = contactStr + contacts[i];
            }
            return contactStr;
        }

        public static void sendEmails(List<String> msgs, int rule_id, String subject, ApplicationDBConnection dBConnection, int type)
        {
            List<String> contacts = new List<string>();
            if (type != 3)
            {
                contacts = getContactsOnRule(rule_id, dBConnection, "EMAIL");
            }
            else
            {
                contacts.Add(getAdminContact(dBConnection)[0]);
            }
            if (contacts.Count == 0)
                return;
            //send email
            List<Dictionary<String, Object>> smsSettings = dBConnection.getQueryResults("SELECT * FROM smtp_settings WHERE id=1");
            Object hostname,port,from_email,from_name, from_pwd;
            smsSettings[0].TryGetValue("hostname", out hostname);
            smsSettings[0].TryGetValue("port", out port);
            smsSettings[0].TryGetValue("from_email", out from_email);
            smsSettings[0].TryGetValue("from_name", out from_name);
            smsSettings[0].TryGetValue("from_pwd", out from_pwd);


            var fromAddress = new MailAddress(from_email.ToString(), from_name.ToString());
            string fromPassword = from_pwd.ToString();
            

            var smtp = new SmtpClient
            {
                Host = (string)hostname,
                Port = (int)port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 50000
            };

            for (int j = 0; j < msgs.Count; j++)
            {
                using (var message = new MailMessage()
                {
                    Subject = subject,
                    Body = msgs[j]
                })
                {
                    message.From = fromAddress;
                    for (int i = 0; i < contacts.Count; i++)
                    {
                        message.To.Add(contacts[i]);
                    }
                    smtp.Send(message);
                }
            }
        }

        private static String[] getAdminContact(ApplicationDBConnection dBConnection)
        {
            
            String query = "SELECT adminemail,adminmobile FROM general_settings WHERE id=1";
            List<Dictionary<String, Object>> result = dBConnection.getQueryResults(query);
            Object adminemail, adminmobile;
            result[0].TryGetValue("adminemail", out adminemail);
            result[0].TryGetValue("adminmobile", out adminmobile);
            return new String[2] {adminemail.ToString(), adminmobile.ToString() };
        }

        private static List<String> getContactsOnRule(int rule_id, ApplicationDBConnection dBConnection, String type)
        {
            String query = "SELECT value FROM contacts WHERE TYPE = '" + type + "' AND rule_id = " + rule_id;
            List<Dictionary<String,Object>> result = dBConnection.getQueryResults(query);
            List<String> contacts = new List<string>();
            for(int i=0;i<result.Count;i++)
            {
                Object val;
                result[i].TryGetValue("value", out val);
                contacts.Add(val.ToString());
            }
            return contacts;
        }

    }
}
