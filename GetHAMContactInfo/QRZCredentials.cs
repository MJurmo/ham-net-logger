using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    public partial class QRZCredentials : Form
    {
        public QRZCredentials()
        {
            InitializeComponent();
            txtUserName.Text = configurationController.GetDataSet().Tables[0].Rows[0]["qrz_username"].ToString();
            txtPassword.Text = configurationController.GetDataSet().Tables[0].Rows[0]["qrz_password"].ToString();
        }

        private void QRZCredentials_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo))
            {
                configurationController.GetDataSet().Tables[0].Rows[0]["qrz_username"] = txtUserName.Text;
                configurationController.GetDataSet().Tables[0].Rows[0]["qrz_password"] = txtPassword.Text;
                configurationController.SaveDataSet();
            }
        }
    }
}
