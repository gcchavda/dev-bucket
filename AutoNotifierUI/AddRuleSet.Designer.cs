namespace AutoNotifierUI
{
    partial class AddRuleSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRuleSet));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.dgRuleSet = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCriteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblRuleName = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.lblRepeatInterval = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdRemoveEmail = new System.Windows.Forms.Button();
            this.cmdAddEmail = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstEmailAddress = new System.Windows.Forms.ListBox();
            this.cmdRemoveMobile = new System.Windows.Forms.Button();
            this.cmdAddMobile = new System.Windows.Forms.Button();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMobileNumbers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.txtRoutineHeading = new System.Windows.Forms.TextBox();
            this.txtSMSTemplate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table";
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(106, 51);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(256, 21);
            this.cmbTables.TabIndex = 2;
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(368, 50);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(31, 23);
            this.cmdGo.TabIndex = 3;
            this.cmdGo.Text = "Go";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // dgRuleSet
            // 
            this.dgRuleSet.AllowUserToAddRows = false;
            this.dgRuleSet.AllowUserToDeleteRows = false;
            this.dgRuleSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgRuleSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRuleSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmCriteria,
            this.clmActive});
            this.dgRuleSet.Location = new System.Drawing.Point(23, 85);
            this.dgRuleSet.Name = "dgRuleSet";
            this.dgRuleSet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRuleSet.Size = new System.Drawing.Size(376, 332);
            this.dgRuleSet.TabIndex = 3;
            // 
            // clmName
            // 
            this.clmName.Frozen = true;
            this.clmName.HeaderText = "Column Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmCriteria
            // 
            this.clmCriteria.HeaderText = "Criteria";
            this.clmCriteria.Name = "clmCriteria";
            this.clmCriteria.ToolTipText = "i.e, <-5 or > 10, = trip, = 0";
            // 
            // clmActive
            // 
            this.clmActive.HeaderText = "Active";
            this.clmActive.Name = "clmActive";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(357, 608);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 16;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblRuleName
            // 
            this.lblRuleName.AutoSize = true;
            this.lblRuleName.Location = new System.Drawing.Point(21, 27);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(60, 13);
            this.lblRuleName.TabIndex = 5;
            this.lblRuleName.Text = "Rule Name";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(106, 25);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(293, 20);
            this.txtRuleName.TabIndex = 1;
            // 
            // lblRepeatInterval
            // 
            this.lblRepeatInterval.AutoSize = true;
            this.lblRepeatInterval.Location = new System.Drawing.Point(18, 26);
            this.lblRepeatInterval.Name = "lblRepeatInterval";
            this.lblRepeatInterval.Size = new System.Drawing.Size(80, 13);
            this.lblRepeatInterval.TabIndex = 7;
            this.lblRepeatInterval.Text = "Repeat Interval";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(150, 23);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(56, 20);
            this.txtInterval.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Seconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Is Active";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(150, 75);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 11;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgRuleSet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTables);
            this.groupBox1.Controls.Add(this.cmdGo);
            this.groupBox1.Controls.Add(this.lblRuleName);
            this.groupBox1.Controls.Add(this.txtRuleName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 437);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdRemoveEmail);
            this.groupBox2.Controls.Add(this.cmdAddEmail);
            this.groupBox2.Controls.Add(this.txtEmailAddress);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstEmailAddress);
            this.groupBox2.Controls.Add(this.cmdRemoveMobile);
            this.groupBox2.Controls.Add(this.cmdAddMobile);
            this.groupBox2.Controls.Add(this.txtMobileNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstMobileNumbers);
            this.groupBox2.Location = new System.Drawing.Point(439, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 437);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // cmdRemoveEmail
            // 
            this.cmdRemoveEmail.Location = new System.Drawing.Point(289, 257);
            this.cmdRemoveEmail.Name = "cmdRemoveEmail";
            this.cmdRemoveEmail.Size = new System.Drawing.Size(28, 23);
            this.cmdRemoveEmail.TabIndex = 15;
            this.cmdRemoveEmail.Text = "-";
            this.cmdRemoveEmail.UseVisualStyleBackColor = true;
            this.cmdRemoveEmail.Click += new System.EventHandler(this.cmdRemoveEmail_Click);
            // 
            // cmdAddEmail
            // 
            this.cmdAddEmail.Location = new System.Drawing.Point(289, 228);
            this.cmdAddEmail.Name = "cmdAddEmail";
            this.cmdAddEmail.Size = new System.Drawing.Size(28, 23);
            this.cmdAddEmail.TabIndex = 12;
            this.cmdAddEmail.Text = "+";
            this.cmdAddEmail.UseVisualStyleBackColor = true;
            this.cmdAddEmail.Click += new System.EventHandler(this.cmdAddEmail_Click);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(148, 230);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(135, 20);
            this.txtEmailAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Selected Email Addresses";
            // 
            // lstEmailAddress
            // 
            this.lstEmailAddress.FormattingEnabled = true;
            this.lstEmailAddress.Location = new System.Drawing.Point(148, 257);
            this.lstEmailAddress.Name = "lstEmailAddress";
            this.lstEmailAddress.Size = new System.Drawing.Size(135, 160);
            this.lstEmailAddress.TabIndex = 14;
            // 
            // cmdRemoveMobile
            // 
            this.cmdRemoveMobile.Location = new System.Drawing.Point(289, 58);
            this.cmdRemoveMobile.Name = "cmdRemoveMobile";
            this.cmdRemoveMobile.Size = new System.Drawing.Size(28, 23);
            this.cmdRemoveMobile.TabIndex = 10;
            this.cmdRemoveMobile.Text = "-";
            this.cmdRemoveMobile.UseVisualStyleBackColor = true;
            this.cmdRemoveMobile.Click += new System.EventHandler(this.cmdRemoveMobile_Click);
            // 
            // cmdAddMobile
            // 
            this.cmdAddMobile.Location = new System.Drawing.Point(289, 29);
            this.cmdAddMobile.Name = "cmdAddMobile";
            this.cmdAddMobile.Size = new System.Drawing.Size(28, 23);
            this.cmdAddMobile.TabIndex = 8;
            this.cmdAddMobile.Text = "+";
            this.cmdAddMobile.UseVisualStyleBackColor = true;
            this.cmdAddMobile.Click += new System.EventHandler(this.cmdAddMobile_Click);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(148, 31);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(135, 20);
            this.txtMobileNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selected Mobile Numbers";
            // 
            // lstMobileNumbers
            // 
            this.lstMobileNumbers.FormattingEnabled = true;
            this.lstMobileNumbers.Location = new System.Drawing.Point(148, 58);
            this.lstMobileNumbers.Name = "lstMobileNumbers";
            this.lstMobileNumbers.Size = new System.Drawing.Size(135, 160);
            this.lstMobileNumbers.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtInterval);
            this.groupBox3.Controls.Add(this.chkIsActive);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMinutes);
            this.groupBox3.Controls.Add(this.lblRepeatInterval);
            this.groupBox3.Location = new System.Drawing.Point(13, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 146);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scheduling";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(210, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Routine Message Timings";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(150, 49);
            this.txtMinutes.MaxLength = 2;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(54, 20);
            this.txtMinutes.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtEmailSubject);
            this.groupBox4.Controls.Add(this.txtRoutineHeading);
            this.groupBox4.Controls.Add(this.txtSMSTemplate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(300, 456);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 146);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Templates";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email Subject";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(156, 114);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(300, 20);
            this.txtEmailSubject.TabIndex = 4;
            // 
            // txtRoutineHeading
            // 
            this.txtRoutineHeading.Location = new System.Drawing.Point(156, 87);
            this.txtRoutineHeading.Name = "txtRoutineHeading";
            this.txtRoutineHeading.Size = new System.Drawing.Size(300, 20);
            this.txtRoutineHeading.TabIndex = 3;
            // 
            // txtSMSTemplate
            // 
            this.txtSMSTemplate.Location = new System.Drawing.Point(156, 19);
            this.txtSMSTemplate.Multiline = true;
            this.txtSMSTemplate.Name = "txtSMSTemplate";
            this.txtSMSTemplate.Size = new System.Drawing.Size(300, 61);
            this.txtSMSTemplate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Routine SMS Heading";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "SMS Template";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "(c) @ magnito";
            // 
            // AddRuleSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddRuleSet";
            this.Text = "Create/Edit RuleSet";
            this.Load += new System.EventHandler(this.AddEditRuleSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.DataGridView dgRuleSet;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblRuleName;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.Label lblRepeatInterval;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdRemoveMobile;
        private System.Windows.Forms.Button cmdAddMobile;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstMobileNumbers;
        private System.Windows.Forms.Button cmdRemoveEmail;
        private System.Windows.Forms.Button cmdAddEmail;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstEmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCriteria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmActive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.TextBox txtRoutineHeading;
        private System.Windows.Forms.TextBox txtSMSTemplate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}