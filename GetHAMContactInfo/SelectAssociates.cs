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
        
        

        public SelectAssociates()
        {
            InitializeComponent();
            lstAllAssociates.DataSource = AssociatesController.GetDataSet().Tables[0];
            
            lstSelectedAssociates.DataSource = SelectedAssociates.getTable();
            lstSelectedAssociates.DisplayMember = "ID";
            lstAllAssociates.DisplayMember = "ID";
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = SelectedAssociates.getTable().NewRow();
            dr.ItemArray = ((DataRowView)lstAllAssociates.SelectedItem).Row.ItemArray;
            var itemsfound = SelectedAssociates.getTable().Rows.Find(((DataRowView)lstAllAssociates.SelectedItem).Row["ID"].ToString());
            if(itemsfound == null)
            {
                SelectedAssociates.getTable().Rows.Add(dr);
                SelectedAssociates.getTable().AcceptChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var itemsfound = SelectedAssociates.getTable().Rows.Find(((DataRowView)lstSelectedAssociates.SelectedItem).Row["ID"].ToString());
            if (itemsfound != null)
            {
                itemsfound.Delete();
                SelectedAssociates.getTable().AcceptChanges();
            }
        }

        private void SelectAssociates_FormClosing(object sender, FormClosingEventArgs e)
        {

            //SelectedAssociates.getTable().Clear();
            
            //foreach (DataRow dr in _selectedds.Rows)
            //{
            //    SelectedAssociates.getTable().ImportRow(dr);
            //}
        }
    }
}