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
    public partial class Associates : Form
    {
         
        public Associates()
        {
            InitializeComponent();
        }

        private void Associates_Load(object sender, EventArgs e)
        {
            gridAssociates.DataSource = AssociatesController.GetDataSet().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssociatesController.SaveDataSet();
        }

        private void gridAssociates_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void gridAssociates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int currRow = ((DataGridView) sender).SelectedCells[0].RowIndex;
            gridAssociates.CurrentCell = gridAssociates.Rows[currRow + 1].Cells["ID"];
            gridAssociates.CurrentCell = gridAssociates.Rows[currRow].Cells["ID"];
            Form AssociateLookup = new AssociateLookup(gridAssociates.Rows[((DataGridView)sender).SelectedCells[0].RowIndex].Cells["ID"].EditedFormattedValue.ToString());
            AssociateLookup.Show();

        }
    }
}
