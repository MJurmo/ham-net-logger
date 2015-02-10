namespace GetHAMContactInfo
{
    partial class Preamble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preamble));
            this.txtPreamble = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPreamble
            // 
            this.txtPreamble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreamble.Location = new System.Drawing.Point(0, 0);
            this.txtPreamble.Name = "txtPreamble";
            this.txtPreamble.Size = new System.Drawing.Size(381, 255);
            this.txtPreamble.TabIndex = 0;
            this.txtPreamble.Text = "";
            // 
            // Preamble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 255);
            this.Controls.Add(this.txtPreamble);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preamble";
            this.Text = "Preamble";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPreamble;
    }
}