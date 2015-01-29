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
    public partial class RADIOGRAM2 : Form
    {
        private string m_ID;

        public RADIOGRAM2(string ID)
        {
            InitializeComponent();
            m_ID = ID;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
