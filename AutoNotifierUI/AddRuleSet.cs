using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNotifierUI
{
    public partial class AddRuleSet : Form
    {
        private String connectionString;
        private String id;
        private List<Dictionary<String, Object>> editResult = null;
        public AddRuleSet(String id)
        {
            InitializeComponent();
            ApplicationDBConnection connection = new ApplicationDBConnection();
            if (id != null)
            {
                this.id = id;
                editResult = connection.getQueryResults("SELECT a.id,a.ruleName,a.tableName, a.timeInterval, a.isActive, a.statustime, b.columnName, b.criteria FROM rule_base a, rule_details b WHERE a.id=" + id + " AND b.rule_id=" + id);
            }
            List<Dictionary<String, Object>> result = connection.getQueryResults("SELECT * FROM db_connection");

            Object hostname, username, password, port, dbname;
            result[0].TryGetValue("hostname", out hostname);
            result[0].TryGetValue("port", out port);
            result[0].TryGetValue("username", out username);
            result[0].TryGetValue("password", out password);
            result[0].TryGetValue("dbname", out dbname);
            


            connectionString = "SERVER = " + hostname.ToString() + "; PORT = " + port.ToString() + "; DATABASE = " + dbname.ToString() + "; UID = " + username.ToString() + "; PASSWORD = " + password.ToString() + "; SslMode = none";


        }

        private void AddEditRuleSet_Load(object sender, EventArgs e)
        {
            lstMobileNumbers.Items.Clear();
            lstEmailAddress.Items.Clear();
            ClientDBConnection clientConnection = new ClientDBConnection(connectionString);
            List<String> tables = clientConnection.getAllTables();
            BindingSource bs = new BindingSource();
            bs.DataSource = tables;
            cmbTables.DataSource = bs;
            if(editResult!=null)
            {
                Object ruleName, tableName, timeInterval, isActive, statusTime;
                editResult[0].TryGetValue("ruleName", out ruleName);
                editResult[0].TryGetValue("tableName", out tableName);
                editResult[0].TryGetValue("timeInterval", out timeInterval);
                editResult[0].TryGetValue("isActive", out isActive);
                editResult[0].TryGetValue("statustime", out statusTime);
                if (statusTime != null && statusTime.ToString()!="")
                {
                    txtMinutes.Text = statusTime.ToString();
                }
                chkIsActive.Checked = (Boolean) isActive;
                txtRuleName.Text = ruleName.ToString();
                cmbTables.SelectedItem = tableName.ToString();
                txtInterval.Text = timeInterval.ToString();
                cmbTables.Enabled = false;
                cmdGo.Enabled = false;
                cmdGo_Click(sender, e);
                for(int i = 0; i < editResult.Count; i++)
                {
                    Object columnName, criteria;
                    editResult[i].TryGetValue("columnName", out columnName);
                    editResult[i].TryGetValue("criteria", out criteria);
                    for(int j=0;j<dgRuleSet.Rows.Count;j++)
                    {
                        if(dgRuleSet.Rows[j].Cells[0].Value.ToString()==columnName.ToString())
                        {
                            dgRuleSet.Rows[j].Cells[1].Value = criteria;
                            dgRuleSet.Rows[j].Cells[2].Value = true;
                        }
                    }
                }
                ApplicationDBConnection connection = new ApplicationDBConnection();
                String query = "Select * from contacts where rule_id=" + id;
                List<Dictionary<String, Object>> contacts = connection.getQueryResults(query);
                for(int i=0;i<contacts.Count;i++)
                {
                    Dictionary<String, Object> contactRow = contacts[i];
                    Object type, value;
                    contactRow.TryGetValue("type", out type);
                    contactRow.TryGetValue("value", out value);
                    if (type.Equals("MOBILE"))
                        lstMobileNumbers.Items.Add(value);
                    else
                        lstEmailAddress.Items.Add(value);

                }
                String query1 = "Select * from text_templates where rule_id = " + id;
                List<Dictionary<String, Object>> templates = connection.getQueryResults(query1);
                if(templates.Count > 0)
                {
                    Object regular_sms, routine_sms, email_subject;
                    templates[0].TryGetValue("regular_sms",out regular_sms);
                    templates[0].TryGetValue("routine_sms", out routine_sms);
                    templates[0].TryGetValue("email_subject", out email_subject);

                    txtSMSTemplate.Text = regular_sms.ToString();
                    txtEmailSubject.Text = email_subject.ToString();
                    txtRoutineHeading.Text = routine_sms.ToString();
                }
            }
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            if(txtRuleName.Text == "")
            {
                MessageBox.Show("Please provide rule name", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgRuleSet.Rows.Clear();
            String selectedTable = cmbTables.SelectedItem.ToString();
            String query = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + selectedTable + "'";
            ClientDBConnection clientConnection = new ClientDBConnection(connectionString);
            List<Dictionary<String, Object>> result = clientConnection.getQueryResults(query);
            for(int i=0;i<result.Count;i++)
            {
                Object colName;
                result[i].TryGetValue("COLUMN_NAME", out colName);
                dgRuleSet.Rows.Add(new Object[] { colName, "", false });
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            String ruleName = txtRuleName.Text;
            String tableName = cmbTables.SelectedItem.ToString();
            String timeInterval = txtInterval.Text;
            String statusHH = txtMinutes.Text;
            String emailSub = txtEmailSubject.Text;
            String smsTemplate = txtSMSTemplate.Text;
            String routineSMSHeader = txtRoutineHeading.Text;

            if (timeInterval == "" || ruleName == "" || statusHH == "" || (lstEmailAddress.Items.Count == 0 && lstMobileNumbers.Items.Count==0)) { 
                MessageBox.Show("Please provide values for all the fields, can not save rule", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(emailSub=="" || smsTemplate==""|| routineSMSHeader=="")
            {
                MessageBox.Show("Please provide values for all the fields (Message Templates)", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationDBConnection connection = new ApplicationDBConnection();
            long localId;
            if (editResult != null)
            {
                localId = long.Parse(id);
                String updateQuery = "Update rule_base set ruleName='" + ruleName + "', tableName='" + tableName + "', timeInterval=" + timeInterval + ", isActive=" + chkIsActive.Checked + ", statustime='" + statusHH  +  "' where id=" + localId;
                connection.Update(updateQuery);
                connection.Delete("Delete from rule_details where rule_id=" + localId);
            }
            else
            {
                String baseQuery = "INSERT INTO rule_base (ruleName, tableName, timeInterval, isActive, statustime) values ('" + ruleName + "','" + tableName + "'," + timeInterval + ", " + chkIsActive.Checked + ",'" + statusHH + "') ";
                localId = connection.Insert(baseQuery);
            }
            List<String> queries = new List<string>();
            for (int i=0;i<dgRuleSet.Rows.Count;i++)
            {
                Boolean isActive = (Boolean)dgRuleSet.Rows[i].Cells[2].Value;
                if(isActive)
                {
                    String colName = dgRuleSet.Rows[i].Cells[0].Value.ToString();
                    String criteria = dgRuleSet.Rows[i].Cells[1].Value.ToString();
                    String query = "INSERT INTO rule_details (rule_id, columnName, criteria) values (" + localId + ",'" + colName + "','" + criteria + "')";
                    queries.Add(query);
                }
            }
            if(queries.Count==0)
            {
                if (editResult == null)
                { 
                    connection.Delete("DELETE FROM rule_base where id=" + localId);
                }
                MessageBox.Show("There are no active columns, hence can not save rule", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                connection.batchInsert(queries);
            }

            if (editResult != null)
            {
                connection.Delete("DELETE FROM contacts where rule_id=" + localId);
                connection.Delete("DELETE FROM text_templates where rule_id=" + localId);
            }
            List<String> contactQueries = new List<string>();
            for(int i=0;i<lstMobileNumbers.Items.Count;i++)
            {
                String query = "INSERT INTO contacts (type, value, rule_id) values ('MOBILE','" + lstMobileNumbers.Items[i].ToString() + "'," + localId + ")";
                contactQueries.Add(query);
            }
            for (int i = 0; i < lstEmailAddress.Items.Count; i++)
            {
                String query = "INSERT INTO contacts (type, value, rule_id) values ('EMAIL','" + lstEmailAddress.Items[i].ToString() + "'," + localId + ")";
                contactQueries.Add(query);
            }
            connection.batchInsert(contactQueries);
            connection.Insert("INSERT INTO text_templates (rule_id,  regular_sms, routine_sms, email_subject) values (" + localId + ",'" + txtSMSTemplate.Text + "','" + txtRoutineHeading.Text + "','" + txtEmailSubject.Text + "')");
            MessageBox.Show("Rule settings stored successfully", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmdAddMobile_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text.Trim() == "" || txtMobileNumber.Text.Length < 12) { 
                MessageBox.Show("Please enter valid mobile number (i.e, 911234123412)", "Auto Notifier", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                return;
            }
            lstMobileNumbers.Items.Add(txtMobileNumber.Text);
            txtMobileNumber.Text = "";
            txtMobileNumber.Focus();
        }

        private void cmdRemoveMobile_Click(object sender, EventArgs e)
        {
            if(lstMobileNumbers.SelectedItem!=null)
                lstMobileNumbers.Items.Remove(lstMobileNumbers.SelectedItem);
            else
                MessageBox.Show("Select one mobile number to remove from list", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmdAddEmail_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text.Trim() == "" || !txtEmailAddress.Text.Contains("@"))
            {
                MessageBox.Show("Please enter valid email address", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstEmailAddress.Items.Add(txtEmailAddress.Text);
            txtEmailAddress.Text = "";
            txtEmailAddress.Focus();
        }

        private void cmdRemoveEmail_Click(object sender, EventArgs e)
        {
            if (lstEmailAddress.SelectedItem != null)
                lstEmailAddress.Items.Remove(lstEmailAddress.SelectedItem);
            else
                MessageBox.Show("Select one email address to remove from list", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
