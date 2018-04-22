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
    public partial class ViewRuleSets : Form
    {
        public ViewRuleSets()
        {
            InitializeComponent();
        }

        private void ViewRuleSets_Load(object sender, EventArgs e)
        {
            dgViewRules.Rows.Clear();
            ApplicationDBConnection connection = new ApplicationDBConnection();
            List<Dictionary<String, Object>> result = connection.getQueryResults("Select * from rule_base");
            for(int i=0;i<result.Count;i++)
            {
                Dictionary<String, Object> row = result[i];
                Object id, ruleName, tableName, timeInterval, isActive;
                row.TryGetValue("id", out id);
                row.TryGetValue("ruleName", out ruleName);
                row.TryGetValue("tableName", out tableName);
                row.TryGetValue("timeInterval", out timeInterval);
                row.TryGetValue("isActive", out isActive);
                dgViewRules.Rows.Add(new Object[] { id, ruleName, tableName, timeInterval, isActive });
            }
        }


        private void dgViewRules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                String id = dgViewRules.Rows[e.RowIndex].Cells[0].Value.ToString();
                AddRuleSet ruleSet = new AddRuleSet(id);
                ruleSet.ShowDialog(this);
                ViewRuleSets_Load(sender, e);
            }
            else if (e.ColumnIndex == 6)
            {
                String id = dgViewRules.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete ruleset?", "Auto Notifier", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.Yes:
                        ApplicationDBConnection connection = new ApplicationDBConnection();
                        connection.Delete("DELETE from rule_details where rule_id=" + id);
                        connection.Delete("DELETE from rule_base where id=" + id);
                        MessageBox.Show("Rule has been deleted successfully, restart service to take effect", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViewRuleSets_Load(sender, e);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
