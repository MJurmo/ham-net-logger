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
        
        private DataTable _selectedds = new DataTable();

        public SelectAssociates()
        {
            InitializeComponent();
            lstAllAssociates.DataSource = AssociatesController.GetDataSet().Tables[0];
            _selectedds = AssociatesController.GetDataSet().Tables[0].Clone();
            lstSelectedAssociates.DataSource = _selectedds;
            lstSelectedAssociates.DisplayMember = "ID";
            lstAllAssociates.DisplayMember = "ID";
            SelectedAssociates.getTable().Clear();
            foreach (DataRow dr in _selectedds.Rows)
            {
                SelectedAssociates.getTable().ImportRow(dr);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = _selectedds.NewRow();
            dr.ItemArray = ((DataRowView)lstAllAssociates.SelectedItem).Row.ItemArray;
            var itemsfound = _selectedds.Rows.Find(((DataRowView) lstAllAssociates.SelectedItem).Row["ID"].ToString());
            if(itemsfound == null)
            {
                _selectedds.Rows.Add(dr);
                _selectedds.AcceptChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var itemsfound = _selectedds.Rows.Find(((DataRowView)lstSelectedAssociates.SelectedItem).Row["ID"].ToString());
            if (itemsfound != null)
            {
                itemsfound.Delete();
                _selectedds.AcceptChanges();
            }
        }

        private void SelectAssociates_FormClosing(object sender, FormClosingEventArgs e)
        {

            SelectedAssociates.getTable().Clear();
            
            foreach (DataRow dr in _selectedds.Rows)
            {
                SelectedAssociates.getTable().ImportRow(dr);
            }
        }
    }
}