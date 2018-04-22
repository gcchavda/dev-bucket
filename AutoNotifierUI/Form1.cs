using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
namespace AutoNotifierUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnectionForm = new DatabaseConnection();
            dbConnectionForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewRuleSets rls = new ViewRuleSets();
            rls.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            AddRuleSet ruls = new AddRuleSet(null);
            ruls.ShowDialog(this);

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0\nContact gaurav.flw@gmail.com, 09723335284 in case of any software related issues", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            ServiceController serviceController = new ServiceController("Windows Jobs");
            try
            {
                if ((serviceController.Status.Equals(ServiceControllerStatus.Running)) || (serviceController.Status.Equals(ServiceControllerStatus.StartPending)))
                {
                    serviceController.Stop();
                }
                serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
                serviceController.Start();
                serviceController.WaitForStatus(ServiceControllerStatus.Running);
                MessageBox.Show("Service Updated Successfully", "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Auto Notifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
