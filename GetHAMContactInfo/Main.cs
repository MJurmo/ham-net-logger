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
        Form associates = new Associates();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (associates.IsDisposed)
            {
                associates = new Associates();
            }
            associates.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form lookup = new AssociateLookup("");
            lookup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form radiogram = new Radiograms();
            radiogram.Show();
        }
    }
}
