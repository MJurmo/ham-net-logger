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

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dr =OrganizationController.GetDataSet().Tables[0].NewRow();
            Form organization = new Organization(dr);
            organization.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (gridOrganizations.SelectedRows.Count == 1)
            {
                string[] key =
                    {
                        gridOrganizations.SelectedRows[0].Cells["band"].Value.ToString(),
                        gridOrganizations.SelectedRows[0].Cells["agency"].Value.ToString()
                    };
                DataRow dr = OrganizationController.GetDataSet().Tables[0].Rows.Find(key);
                Form organization = new Organization(dr);
                organization.Show();
            }
            else
            {
                MessageBox.Show("Please select one record to edit.");
            }
        }
    }
}
