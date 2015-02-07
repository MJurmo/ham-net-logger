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
                    default:
                        MessageBox.Show("I don't know this form!");
                        break;
                }
            }
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            handle_form_view(associates);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //handle_form_view(lookup);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            handle_form_view(radiogram);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            handle_form_view(organization);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            handle_form_view(session);
        }
    }
}
