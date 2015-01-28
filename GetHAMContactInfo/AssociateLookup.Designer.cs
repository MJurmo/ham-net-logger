namespace GetHAMContactInfo
{
    partial class AssociateLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssociateLookup));
            this.btnShowPageCode = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnCurrELEM = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUSCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUSState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGridSquare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBorn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBearing = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogon = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowPageCode
            // 
            this.btnShowPageCode.Location = new System.Drawing.Point(279, 56);
            this.btnShowPageCode.Name = "btnShowPageCode";
            this.btnShowPageCode.Size = new System.Drawing.Size(207, 23);
            this.btnShowPageCode.TabIndex = 0;
            this.btnShowPageCode.Text = "ShowPageCode";
            this.btnShowPageCode.UseVisualStyleBackColor = true;
            this.btnShowPageCode.Visible = false;
            this.btnShowPageCode.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser1.Location = new System.Drawing.Point(-134, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(549, 563);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnCurrELEM
            // 
            this.btnCurrELEM.Location = new System.Drawing.Point(288, 11);
            this.btnCurrELEM.Name = "btnCurrELEM";
            this.btnCurrELEM.Size = new System.Drawing.Size(175, 23);
            this.btnCurrELEM.TabIndex = 3;
            this.btnCurrELEM.Text = "ShowSelectedElement";
            this.btnCurrELEM.UseVisualStyleBackColor = true;
            this.btnCurrELEM.Visible = false;
            this.btnCurrELEM.Click += new System.EventHandler(this.btnCurrELEM_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(179, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 22);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Code and press [Enter]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(179, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "City/State/Zip";
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(179, 180);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(207, 22);
            this.txtCity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Country Code:";
            // 
            // txtCountry
            // 
            this.txtCountry.Enabled = false;
            this.txtCountry.Location = new System.Drawing.Point(179, 208);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(207, 22);
            this.txtCountry.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "US County:";
            // 
            // txtUSCounty
            // 
            this.txtUSCounty.Enabled = false;
            this.txtUSCounty.Location = new System.Drawing.Point(179, 378);
            this.txtUSCounty.Name = "txtUSCounty";
            this.txtUSCounty.Size = new System.Drawing.Size(207, 22);
            this.txtUSCounty.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "US State";
            // 
            // txtUSState
            // 
            this.txtUSState.Enabled = false;
            this.txtUSState.Location = new System.Drawing.Point(179, 350);
            this.txtUSState.Name = "txtUSState";
            this.txtUSState.Size = new System.Drawing.Size(207, 22);
            this.txtUSState.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Grid Square:";
            // 
            // txtGridSquare
            // 
            this.txtGridSquare.Enabled = false;
            this.txtGridSquare.Location = new System.Drawing.Point(179, 322);
            this.txtGridSquare.Name = "txtGridSquare";
            this.txtGridSquare.Size = new System.Drawing.Size(207, 22);
            this.txtGridSquare.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Class:";
            // 
            // txtClass
            // 
            this.txtClass.Enabled = false;
            this.txtClass.Location = new System.Drawing.Point(179, 238);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(207, 22);
            this.txtClass.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Born:";
            // 
            // txtBorn
            // 
            this.txtBorn.Enabled = false;
            this.txtBorn.Location = new System.Drawing.Point(179, 465);
            this.txtBorn.Name = "txtBorn";
            this.txtBorn.Size = new System.Drawing.Size(207, 22);
            this.txtBorn.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Bearing:";
            // 
            // txtBearing
            // 
            this.txtBearing.Enabled = false;
            this.txtBearing.Location = new System.Drawing.Point(179, 437);
            this.txtBearing.Name = "txtBearing";
            this.txtBearing.Size = new System.Drawing.Size(207, 22);
            this.txtBearing.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Longitude:";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(179, 294);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(207, 22);
            this.txtLongitude.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Latitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(179, 266);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(207, 22);
            this.txtLatitude.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Distance:";
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Location = new System.Drawing.Point(179, 407);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(207, 22);
            this.txtDistance.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "UserName:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 33;
            // 
            // btnLogon
            // 
            this.btnLogon.Location = new System.Drawing.Point(203, 32);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(149, 30);
            this.btnLogon.TabIndex = 37;
            this.btnLogon.Text = "Logon";
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 498);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(179, 493);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 22);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // AssociateLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 563);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBorn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBearing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUSCounty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUSState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGridSquare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCurrELEM);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnShowPageCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssociateLookup";
            this.Text = "HAM Contact Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPageCode;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnCurrELEM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUSCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUSState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGridSquare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBorn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBearing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

