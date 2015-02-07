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
    public partial class SelectAssociates : Form
    {
        private DataTable selectedds = new DataTable();
        
        public SelectAssociates()
        {
            InitializeComponent();

            lstAllAssociates.DataSource = AssociatesController.GetDataSet().Tables[0];
            selectedds = AssociatesController.GetDataSet().Tables[0].Clone();
            lstSelectedAssociates.DataSource = selectedds;
            lstSelectedAssociates.DisplayMember = "ID";
            lstAllAssociates.DisplayMember = "ID";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = selectedds.NewRow();
            dr.ItemArray = ((DataRowView)lstAllAssociates.SelectedItem).Row.ItemArray;
            selectedds.Rows.Add(dr);



        }
    }
}