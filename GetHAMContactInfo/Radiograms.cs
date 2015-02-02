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
    public partial class Radiograms : Form
    {
        public Radiograms()
        {
            InitializeComponent();
        }

        private void Radiograms_Load(object sender, EventArgs e)
        {
            gridRadiograms.DataSource = RadiogramsController.GetDataSet().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadiogramsController.SaveDataSet();
        }

        private void gridRadiograms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRow = ((DataGridView)sender).SelectedCells[0].RowIndex;
            if (currRow == gridRadiograms.Rows.Count-1)
            {
                MessageBox.Show(
                    "Invalid record selected. NOTE: To add a new record, please enter a ID(call sign) into a new record in the grid and double click the new record.");
                return;
            }
            gridRadiograms.CurrentCell = gridRadiograms.Rows[currRow+1].Cells["ID"];
            gridRadiograms.CurrentCell = gridRadiograms.Rows[currRow].Cells["ID"];
            Form radiogram = new RADIOGRAM2(gridRadiograms.Rows[((DataGridView)sender).SelectedCells[0].RowIndex].Cells["ID"].EditedFormattedValue.ToString());
            if (gridRadiograms.Rows[currRow].Cells["ID"].Value.ToString() == "")
            {
                MessageBox.Show("Please enter an ID(call sign).");
                return;
            }
            else
            {
                radiogram.Show();
            }
        }
    }
}
