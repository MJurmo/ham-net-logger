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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void RADIOGRAM2_ResizeBegin(object sender, EventArgs e)
        {
            this.SuspendLayout();
        }

        private void RADIOGRAM2_ResizeEnd(object sender, EventArgs e)
        {
            this.ResumeLayout(true);
        }
    }
}
