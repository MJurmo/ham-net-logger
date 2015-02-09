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
    public partial class Main : Form
    {
        private Form associates = new Associates();
        //private Form lookup = null;
        private Form radiogram = new Radiograms();
        private Form organization = new Organizations();
        private Form session = new Session_Command();
        private Form sessions = new Sessions();
        private Form qrzcredentials = new QRZCredentials();
        public Main()
        {
            InitializeComponent();
        }
        private void handle_form_view(Form form)
        {
            if (form == null || form.IsDisposed)
            {
                switch (form.Name)
                {
                    case("Associates"):
                        form = new Associates();
                        break;
                    //case("AssociateLookup"):
                        //form = new AssociateLookup("");
                        //break;
                    case ("Radiograms"):
                        form = new Radiograms();
                        break;
                    case ("Organizations"):
                        form = new Organizations();
                        break;
                    case ("Session_Command"):
                        form = new Session_Command();
                        break;
                    case ("Sessions"):
                        form = new Sessions();
                        break;
                    case ("QRZCredentials"):
                        form = new QRZCredentials();
                        break;
                    default:
                        MessageBox.Show("I don't know this form!");
                        break;
                }
            }
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //handle_form_view(lookup);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            handle_form_view(session);
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new AboutNMC();
            about.Show();
        }
        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_form_view(sessions);
        }
        private void radiogramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_form_view(radiogram);
        }
        private void organizationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_form_view(organization);
        }
        private void associatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_form_view(associates);
        }

        private void qRZCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_form_view(qrzcredentials);
        }
    }
}
