namespace GetHAMContactInfo
{
    partial class Associates
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
            this.gridAssociates = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAssociates)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAssociates
            // 
            this.gridAssociates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAssociates.Location = new System.Drawing.Point(12, 12);
            this.gridAssociates.Name = "gridAssociates";
            this.gridAssociates.RowTemplate.Height = 24;
            this.gridAssociates.Size = new System.Drawing.Size(1196, 464);
            this.gridAssociates.TabIndex = 0;
            this.gridAssociates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAssociates_CellDoubleClick);
            this.gridAssociates.DoubleClick += new System.EventHandler(this.gridAssociates_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Associates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridAssociates);
            this.Name = "Associates";
            this.Text = "Associates";
            this.Load += new System.EventHandler(this.Associates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAssociates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAssociates;
        private System.Windows.Forms.Button button1;
    }
}