namespace GetHAMContactInfo
{
    partial class SessionAssociatesList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.txtAssociateName1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(13, 12);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(66, 22);
            this.txtUser1.TabIndex = 0;
            this.txtUser1.TextChanged += new System.EventHandler(this.txtUser1_TextChanged);
            this.txtUser1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser1_KeyDown);
            // 
            // txtAssociateName1
            // 
            this.txtAssociateName1.Enabled = false;
            this.txtAssociateName1.Location = new System.Drawing.Point(85, 12);
            this.txtAssociateName1.Name = "txtAssociateName1";
            this.txtAssociateName1.Size = new System.Drawing.Size(169, 22);
            this.txtAssociateName1.TabIndex = 1;
            // 
            // SessionAssociatesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAssociateName1);
            this.Controls.Add(this.txtUser1);
            this.Name = "SessionAssociatesList";
            this.Size = new System.Drawing.Size(1309, 254);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.TextBox txtAssociateName1;
    }
}
