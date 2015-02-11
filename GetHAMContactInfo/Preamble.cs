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
    public partial class Preamble : Form
    {
        public Preamble(string organization_band, string organization_agency)
        {
            InitializeComponent();
            string[] keys = { organization_band, organization_agency };
            txtPreamble.Text =
                OrganizationController.GetDataSet().Tables[0].Rows.Find(keys)["preamble"].ToString();
        }
    }
}
