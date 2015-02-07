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
    public partial class Session_Command : Form
    {
        public Session_Command()
        {
            InitializeComponent();
        }

        private Form selectassociates = new SelectAssociates();
        private DateTime sessionstart = new DateTime();
        private void btnBeginEndSession_Click(object sender, EventArgs e)
        {
            if (btnBeginEndSession.Text == "Begin Session")
            {
                sessionstart = DateTime.Now;
                MessageBox.Show("Session Began @:" + sessionstart.ToString());
                btnBeginEndSession.Text = "End Session";
            }
            else if (btnBeginEndSession.Text == "End Session")
            {
                if (MessageBox.Show("Are you sure you want to end the session?", "Warning!", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    TimeSpan diff = DateTime.Now - sessionstart;
                    string message = string.Format("Session duration:{0:N0}MIN;{1:N0}SEC;", diff.Minutes, diff.Seconds);
                    MessageBox.Show(message);
                    btnBeginEndSession.Text = "Session Ended";
                    this.Close();
                }
            }
        }
        private void Session_Command_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnBeginEndSession.Text == "End Session")
            {
                if (MessageBox.Show("Are you sure you want to end the session?", "Warning!", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    TimeSpan diff = DateTime.Now - sessionstart;
                    string message = string.Format("Session duration:{0:N0}MIN;{1:N0}SEC;", diff.Minutes, diff.Seconds);
                    MessageBox.Show(message);
                }
                else
                {
                    e.Cancel= true;
                }
            }
        }

        private void btnAddAssociates_Click(object sender, EventArgs e)
        {
            if (selectassociates.IsDisposed)
            {
                selectassociates= new SelectAssociates();
            }
            selectassociates.Show();
        }
    }
}
