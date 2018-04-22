namespace AutoNotifierUI
{
    partial class DatabaseConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnection));
            this.lblDatabaseHostName = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.txtHH = new System.Windows.Forms.TextBox();
            this.cmdSaveGeneral = new System.Windows.Forms.Button();
            this.txtAdminMobile = new System.Windows.Forms.TextBox();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdSaveSMTP = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.txtSMTPHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmdSaveSMS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.txtSMSPassword = new System.Windows.Forms.TextBox();
            this.txtGatewayURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatabaseHostName
            // 
            this.lblDatabaseHostName.AutoSize = true;
            this.lblDatabaseHostName.Location = new System.Drawing.Point(8, 10);
            this.lblDatabaseHostName.Name = "lblDatabaseHostName";
            this.lblDatabaseHostName.Size = new System.Drawing.Size(60, 13);
            this.lblDatabaseHostName.TabIndex = 0;
            this.lblDatabaseHostName.Text = "Host Name";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(96, 7);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(250, 20);
            this.txtHostName.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(96, 33);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(250, 20);
            this.txtPort.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(8, 36);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUsername.Location = new System.Drawing.Point(96, 59);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPassword.Location = new System.Drawing.Point(96, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(8, 88);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "Password";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(96, 138);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(63, 23);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(8, 115);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(84, 13);
            this.lblDatabaseName.TabIndex = 6;
            this.lblDatabaseName.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(96, 112);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(250, 20);
            this.txtDatabaseName.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 194);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtMM);
            this.tabPage4.Controls.Add(this.txtHH);
            this.tabPage4.Controls.Add(this.cmdSaveGeneral);
            this.tabPage4.Controls.Add(this.txtAdminMobile);
            this.tabPage4.Controls.Add(this.txtAdminEmail);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(353, 168);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "General";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "HH:MM (24 Hour format)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Status Message Timings";
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(173, 63);
            this.txtMM.MaxLength = 2;
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(24, 20);
            this.txtMM.TabIndex = 4;
            // 
            // txtHH
            // 
            this.txtHH.Location = new System.Drawing.Point(143, 63);
            this.txtHH.MaxLength = 2;
            this.txtHH.Name = "txtHH";
            this.txtHH.Size = new System.Drawing.Size(24, 20);
            this.txtHH.TabIndex = 3;
            // 
            // cmdSaveGeneral
            // 
            this.cmdSaveGeneral.Location = new System.Drawing.Point(143, 93);
            this.cmdSaveGeneral.Name = "cmdSaveGeneral";
            this.cmdSaveGeneral.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveGeneral.TabIndex = 5;
            this.cmdSaveGeneral.Text = "Save";
            this.cmdSaveGeneral.UseVisualStyleBackColor = true;
            this.cmdSaveGeneral.Click += new System.EventHandler(this.cmdSaveGeneral_Click);
            // 
            // txtAdminMobile
            // 
            this.txtAdminMobile.Location = new System.Drawing.Point(143, 36);
            this.txtAdminMobile.Name = "txtAdminMobile";
            this.txtAdminMobile.Size = new System.Drawing.Size(200, 20);
            this.txtAdminMobile.TabIndex = 2;
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(143, 9);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(200, 20);
            this.txtAdminEmail.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Admin\'s Mobile Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Admin\'s Email";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDatabaseHostName);
            this.tabPage1.Controls.Add(this.txtDatabaseName);
            this.tabPage1.Controls.Add(this.txtHostName);
            this.tabPage1.Controls.Add(this.lblDatabaseName);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.cmdSave);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.lblPwd);
            this.tabPage1.Controls.Add(this.lblPort);
            this.tabPage1.Controls.Add(this.lblUsername);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Database";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdSaveSMTP);
            this.tabPage2.Controls.Add(this.txtPwd);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtSMTPPort);
            this.tabPage2.Controls.Add(this.txtSMTPHost);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMTP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdSaveSMTP
            // 
            this.cmdSaveSMTP.Location = new System.Drawing.Point(117, 135);
            this.cmdSaveSMTP.Name = "cmdSaveSMTP";
            this.cmdSaveSMTP.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveSMTP.TabIndex = 6;
            this.cmdSaveSMTP.Text = "Save";
            this.cmdSaveSMTP.UseVisualStyleBackColor = true;
            this.cmdSaveSMTP.Click += new System.EventHandler(this.cmdSaveSMTP_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(117, 109);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(226, 20);
            this.txtPwd.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Location = new System.Drawing.Point(117, 37);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(226, 20);
            this.txtSMTPPort.TabIndex = 2;
            // 
            // txtSMTPHost
            // 
            this.txtSMTPHost.Location = new System.Drawing.Point(117, 12);
            this.txtSMTPHost.Name = "txtSMTPHost";
            this.txtSMTPHost.Size = new System.Drawing.Size(226, 20);
            this.txtSMTPHost.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sender\'s Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sender\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sender\'s Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SMTP Port number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Hostname";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmdSaveSMS);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtSenderName);
            this.tabPage3.Controls.Add(this.txtSMSPassword);
            this.tabPage3.Controls.Add(this.txtGatewayURL);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(353, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SMS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmdSaveSMS
            // 
            this.cmdSaveSMS.Location = new System.Drawing.Point(114, 86);
            this.cmdSaveSMS.Name = "cmdSaveSMS";
            this.cmdSaveSMS.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveSMS.TabIndex = 4;
            this.cmdSaveSMS.Text = "Save";
            this.cmdSaveSMS.UseVisualStyleBackColor = true;
            this.cmdSaveSMS.Click += new System.EventHandler(this.cmdSaveSMS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Sender\'s Name";
            // 
            // txtSenderName
            // 
            this.txtSenderName.Location = new System.Drawing.Point(114, 59);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(229, 20);
            this.txtSenderName.TabIndex = 3;
            // 
            // txtSMSPassword
            // 
            this.txtSMSPassword.Location = new System.Drawing.Point(114, 33);
            this.txtSMSPassword.Name = "txtSMSPassword";
            this.txtSMSPassword.PasswordChar = '*';
            this.txtSMSPassword.Size = new System.Drawing.Size(229, 20);
            this.txtSMSPassword.TabIndex = 2;
            // 
            // txtGatewayURL
            // 
            this.txtGatewayURL.Location = new System.Drawing.Point(114, 7);
            this.txtGatewayURL.Name = "txtGatewayURL";
            this.txtGatewayURL.Size = new System.Drawing.Size(229, 20);
            this.txtGatewayURL.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SMS Gateway URL";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 210);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "(c) @ magnito";
            // 
            // DatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 232);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DatabaseConnection";
            this.Text = "General Settings";
            this.Load += new System.EventHandler(this.DatabaseConnection_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatabaseHostName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button cmdSaveSMTP;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.TextBox txtSMTPHost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSaveSMS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.TextBox txtSMSPassword;
        private System.Windows.Forms.TextBox txtGatewayURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button cmdSaveGeneral;
        private System.Windows.Forms.TextBox txtAdminMobile;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.TextBox txtHH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}