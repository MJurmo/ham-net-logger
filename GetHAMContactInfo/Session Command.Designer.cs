namespace GetHAMContactInfo
{
    partial class Session_Command
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Session_Command));
            this.btnBeginEndSession = new System.Windows.Forms.Button();
            this.lstAssociates = new System.Windows.Forms.ListBox();
            this.lblAssociates = new System.Windows.Forms.Label();
            this.btnAddAssociates = new System.Windows.Forms.Button();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeginEndSession
            // 
            this.btnBeginEndSession.Location = new System.Drawing.Point(925, 13);
            this.btnBeginEndSession.Name = "btnBeginEndSession";
            this.btnBeginEndSession.Size = new System.Drawing.Size(177, 23);
            this.btnBeginEndSession.TabIndex = 0;
            this.btnBeginEndSession.Text = "Begin Session";
            this.btnBeginEndSession.UseVisualStyleBackColor = true;
            this.btnBeginEndSession.Click += new System.EventHandler(this.btnBeginEndSession_Click);
            // 
            // lstAssociates
            // 
            this.lstAssociates.FormattingEnabled = true;
            this.lstAssociates.ItemHeight = 16;
            this.lstAssociates.Location = new System.Drawing.Point(12, 106);
            this.lstAssociates.Name = "lstAssociates";
            this.lstAssociates.Size = new System.Drawing.Size(120, 500);
            this.lstAssociates.TabIndex = 1;
            // 
            // lblAssociates
            // 
            this.lblAssociates.AutoSize = true;
            this.lblAssociates.Location = new System.Drawing.Point(12, 57);
            this.lblAssociates.Name = "lblAssociates";
            this.lblAssociates.Size = new System.Drawing.Size(82, 17);
            this.lblAssociates.TabIndex = 2;
            this.lblAssociates.Text = "Participants";
            // 
            // btnAddAssociates
            // 
            this.btnAddAssociates.Location = new System.Drawing.Point(15, 77);
            this.btnAddAssociates.Name = "btnAddAssociates";
            this.btnAddAssociates.Size = new System.Drawing.Size(75, 23);
            this.btnAddAssociates.TabIndex = 3;
            this.btnAddAssociates.Text = "Add";
            this.btnAddAssociates.UseVisualStyleBackColor = true;
            this.btnAddAssociates.Click += new System.EventHandler(this.btnAddAssociates_Click);
            // 
            // cboOrganization
            // 
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(127, 12);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(121, 24);
            this.cboOrganization.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Organization:";
            // 
            // Session_Command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.btnAddAssociates);
            this.Controls.Add(this.lblAssociates);
            this.Controls.Add(this.lstAssociates);
            this.Controls.Add(this.btnBeginEndSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Session_Command";
            this.Text = "Sesson_Command";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Session_Command_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeginEndSession;
        private System.Windows.Forms.ListBox lstAssociates;
        private System.Windows.Forms.Label lblAssociates;
        private System.Windows.Forms.Button btnAddAssociates;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.Label label1;

    }
}