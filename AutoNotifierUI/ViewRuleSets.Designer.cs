namespace AutoNotifierUI
{
    partial class ViewRuleSets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRuleSets));
            this.dgViewRules = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewRules)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgViewRules
            // 
            this.dgViewRules.AllowUserToAddRows = false;
            this.dgViewRules.AllowUserToDeleteRows = false;
            this.dgViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmRuleName,
            this.clmTableName,
            this.clmTimeInterval,
            this.clmIsActive,
            this.clmEdit,
            this.clmDelete});
            this.dgViewRules.Location = new System.Drawing.Point(12, 12);
            this.dgViewRules.Name = "dgViewRules";
            this.dgViewRules.ReadOnly = true;
            this.dgViewRules.Size = new System.Drawing.Size(647, 190);
            this.dgViewRules.TabIndex = 0;
            this.dgViewRules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewRules_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmRuleName
            // 
            this.clmRuleName.HeaderText = "RuleName";
            this.clmRuleName.Name = "clmRuleName";
            this.clmRuleName.ReadOnly = true;
            // 
            // clmTableName
            // 
            this.clmTableName.HeaderText = "Table Name";
            this.clmTableName.Name = "clmTableName";
            this.clmTableName.ReadOnly = true;
            // 
            // clmTimeInterval
            // 
            this.clmTimeInterval.HeaderText = "Time Interval";
            this.clmTimeInterval.Name = "clmTimeInterval";
            this.clmTimeInterval.ReadOnly = true;
            // 
            // clmIsActive
            // 
            this.clmIsActive.HeaderText = "Is Active";
            this.clmIsActive.Name = "clmIsActive";
            this.clmIsActive.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clmEdit.HeaderText = "Edit";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEdit.Text = "Edit";
            this.clmEdit.UseColumnTextForButtonValue = true;
            // 
            // clmDelete
            // 
            this.clmDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Text = "Delete";
            this.clmDelete.UseColumnTextForButtonValue = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(670, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "(c) @ magnito";
            // 
            // ViewRuleSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 234);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgViewRules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewRuleSets";
            this.Text = "View Rule Sets";
            this.Load += new System.EventHandler(this.ViewRuleSets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewRules)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeInterval;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsActive;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}