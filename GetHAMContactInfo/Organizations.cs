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
    public partial class Organizations : Form
    {
        public Organizations()
        {
            InitializeComponent();
        }

        private void Organizations_Load(object sender, EventArgs e)
        {
            gridOrganizations.DataSource = OrganizationController.GetDataSet().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrganizationController.SaveDataSet();
        }
    }
}
