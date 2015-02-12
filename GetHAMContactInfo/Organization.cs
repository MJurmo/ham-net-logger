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
    public partial class Organization : Form
    {
        private bool bAddingRecord = false;
        private DataRow m_dr;
        public Organization(DataRow dr)
        {
            InitializeComponent();
            m_dr = dr;
            if (dr["band"].ToString() != "")
            {
                
                txtAgency.Text = dr["agency"].ToString();
                txtFrequency.Text = dr["frequency"].ToString();
                txtBand.Text = dr["band"].ToString();
                txtSchedule.Text = dr["schedule"].ToString();
            }
            else
            {
                bAddingRecord = true;
            }
        }

        private void Organization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Organization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtAgency.Text == "")
            {
                MessageBox.Show("Agency is a required field.");
                e.Cancel = true;
            }
            if (txtBand.Text == "")
            {
                MessageBox.Show("Agency is a required field.");
                e.Cancel = true;
            }
            m_dr["band"] = txtBand.Text;
            m_dr["frequency"] = txtFrequency.Text;
            m_dr["agency"] = txtAgency.Text;
            m_dr["schedule"] = txtSchedule.Text;
            if (bAddingRecord)
            {
                OrganizationController.AddOrganization(m_dr);
            }
            else
            {
                OrganizationController.EditOrganization(m_dr);
                
            }
        }
    }
}
