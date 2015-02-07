namespace GetHAMContactInfo
{
    partial class SelectAssociates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAssociates));
            this.lstAllAssociates = new System.Windows.Forms.ListBox();
            this.lstSelectedAssociates = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAllAssociates
            // 
            this.lstAllAssociates.FormattingEnabled = true;
            this.lstAllAssociates.ItemHeight = 16;
            this.lstAllAssociates.Location = new System.Drawing.Point(27, 99);
            this.lstAllAssociates.Name = "lstAllAssociates";
            this.lstAllAssociates.Size = new System.Drawing.Size(148, 324);
            this.lstAllAssociates.TabIndex = 0;
            // 
            // lstSelectedAssociates
            // 
            this.lstSelectedAssociates.FormattingEnabled = true;
            this.lstSelectedAssociates.ItemHeight = 16;
            this.lstSelectedAssociates.Location = new System.Drawing.Point(353, 99);
            this.lstSelectedAssociates.Name = "lstSelectedAssociates";
            this.lstSelectedAssociates.Size = new System.Drawing.Size(148, 324);
            this.lstSelectedAssociates.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAllAssociates);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lstSelectedAssociates);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 538);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // SelectAssociates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 538);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectAssociates";
            this.Text = "SelectAssociates";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllAssociates;
        private System.Windows.Forms.ListBox lstSelectedAssociates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}