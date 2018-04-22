using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoNotifierUI
{
    public partial class DatabaseConnection : Form
    {
        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            ApplicationDBConnection connection = new ApplicationDBConnection();
            List<Dictionary<String,Object>> result =  connection.getQueryResults("SELECT * FROM db_connection");
            if(result.Count>0)
            {
                Object hostname, username, password, port, dbname;
                result[0].TryGetValue("hostname", out hostname);
                result[0].TryGetValue("port", out port);
                result[0].TryGetValue("username", out username);
                result[0].TryGetValue("password", out password);
                result[0].TryGetValue("dbname", out dbname);

                txtHostName.Text = hostname.ToString();
                txtPassword.Text = password.ToString();
                txtPort.Text = port.ToString();
                txtUsername.Text = username.ToString();
                txtDatabaseName.Text = dbname.ToString();

            }
            List<Dictionary<String, Object>> smtpResult = connection.getQueryResults("SELECT * FROM smtp_settings");
            if(smtpResult!=null)
            {
                Object smtpHost, smtpPort, fromEmail, fromName, fromPwd;
                smtpResult[0].TryGetValue("hostname", out smtpHost);
                smtpResult[0].TryGetValue("port", out smtpPort);
                smtpResult[0].TryGetValue("from_email", out fromEmail);
                smtpResult[0].TryGetValue("from_name", out fromName);
                smtpResult[0].TryGetValue("from_pwd", out fromPwd);

                txtSMTPHost.Text = smtpHost.ToString();
                txtSMTPPort.Text = smtpPort.ToString();
                txtEmail.Text = fromEmail.ToString();
                txtName.Text = fromName.ToString();
                txtPwd.Text = fromPwd.ToString();
            }
            List<Dictionary<String, Object>> smsResult = connection.getQueryResults("SELECT * FROM sms_settings");
            if (smsResult != null)
            {
                Object smsURL, smsUser, smsPassword, senderName;
                smsResult[0].TryGetValue("url", out smsURL);
                smsResult[0].TryGetValue("username", out smsUser);
                smsResult[0].TryGetValue("password", out smsPassword);
                smsResult[0].TryGetValue("sendername", out senderName);


                txtGatewayURL.Text = smsURL.ToString();
                //txtSMSUserName.Text = smsUser.ToString();
                txtSMSPassword.Text = smsPassword.ToString();
                txtSenderName.Text = senderName.ToString();

            }
            List<Dictionary<String, Object>> generalResult = connection.getQueryResults("SELECT * FROM general_settings");
            if(generalResult!= null)
            {
                Object adminEmail, adminMobile, statusTime;
                generalResult[0].TryGetValue("adminemail", out adminEmail);
                generalResult[0].TryGetValue("adminmobile", out adminMobile);
                generalResult[0].TryGetValue("statustime", out statusTime);
                txtAdminEmail.Text = adminEmail.ToString();
                txtAdminMobile.Text = adminMobile.ToString();
                if(statusTime!=null && statusTime.ToString() != "") { 
                    String[] timeSplit = statusTime.ToString().Split(":".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                    txtHH.Text = timeSplit[0];
                    txtMM.Text = timeSplit[1];
                }

            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            ApplicationDBConnection connection = new ApplicationDBConnection();
            String query = "Update db_connection set hostname='" + txtHostName.Text + "', port=" + txtPort.Text + ", username='" + txtUsername.Text + "',password='" + txtPassword.Text + "',dbname='" + txtDatabaseName.Text + "' where id=1";
            connection.Update(query);
           MessageBox.Show("Database connection settings updated successfully", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmdSaveSMTP_Click(object sender, EventArgs e)
        {
            ApplicationDBConnection connection = new ApplicationDBConnection();
            String query = "Update smtp_settings set hostname='" + txtSMTPHost.Text + "', port=" + txtSMTPPort.Text + ", from_email='" + txtEmail.Text + "',from_name='" + txtName.Text + "',from_pwd='"  + txtPwd.Text + "' where id=1";
            connection.Update(query);
            MessageBox.Show("SMTP email settings updated successfully", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmdSaveSMS_Click(object sender, EventArgs e)
        {
            ApplicationDBConnection connection = new ApplicationDBConnection();
            String query = "Update sms_settings set url='" + txtGatewayURL.Text + "', username='temp', password='" + txtSMSPassword.Text + "',sendername='" + txtSenderName.Text + "' where id=1";
            connection.Update(query);
            MessageBox.Show("SMS Gateway settings updated successfully", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdSaveGeneral_Click(object sender, EventArgs e)
        {
            ApplicationDBConnection connection = new ApplicationDBConnection();
            String query = "Update general_settings set adminemail='" + txtAdminEmail.Text + "', adminmobile='" + txtAdminMobile.Text + "', statustime='"+ txtHH.Text + ":" + txtMM.Text + "' where id=1";
            connection.Update(query);
            MessageBox.Show("General settings updated successfully", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
