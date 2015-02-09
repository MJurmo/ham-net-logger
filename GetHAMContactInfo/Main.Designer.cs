namespace GetHAMContactInfo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.associatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiogramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRZCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Test Lookup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(477, 411);
            this.button5.TabIndex = 5;
            this.button5.Text = "Host New Net Session";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associatesToolStripMenuItem,
            this.organizationsToolStripMenuItem,
            this.radiogramsToolStripMenuItem,
            this.sessionsToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qRZCredentialsToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(297, 24);
            this.aboutToolStripMenuItem1.Text = "About Net Managers Companion";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // associatesToolStripMenuItem
            // 
            this.associatesToolStripMenuItem.Name = "associatesToolStripMenuItem";
            this.associatesToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.associatesToolStripMenuItem.Text = "Associates";
            this.associatesToolStripMenuItem.Click += new System.EventHandler(this.associatesToolStripMenuItem_Click);
            // 
            // organizationsToolStripMenuItem
            // 
            this.organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            this.organizationsToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.organizationsToolStripMenuItem.Text = "Organizations";
            this.organizationsToolStripMenuItem.Click += new System.EventHandler(this.organizationsToolStripMenuItem_Click);
            // 
            // radiogramsToolStripMenuItem
            // 
            this.radiogramsToolStripMenuItem.Name = "radiogramsToolStripMenuItem";
            this.radiogramsToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.radiogramsToolStripMenuItem.Text = "Radiograms";
            this.radiogramsToolStripMenuItem.Click += new System.EventHandler(this.radiogramsToolStripMenuItem_Click);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            this.sessionsToolStripMenuItem.Click += new System.EventHandler(this.sessionsToolStripMenuItem_Click);
            // 
            // qRZCredentialsToolStripMenuItem
            // 
            this.qRZCredentialsToolStripMenuItem.Name = "qRZCredentialsToolStripMenuItem";
            this.qRZCredentialsToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.qRZCredentialsToolStripMenuItem.Text = "QRZ credentials";
            this.qRZCredentialsToolStripMenuItem.Click += new System.EventHandler(this.qRZCredentialsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 439);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Net Managers Companion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem associatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radiogramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRZCredentialsToolStripMenuItem;
    }
}