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
            gridRadiograms.CurrentCell = gridRadiograms.Rows[currRow].Cells["number"];
            gridRadiograms.CurrentCell = gridRadiograms.Rows[currRow].Cells["ID"];
            Form radiogram = new RADIOGRAM2(gridRadiograms.Rows[((DataGridView)sender).SelectedCells[0].RowIndex].Cells["ID"].EditedFormattedValue.ToString());
            radiogram.Show();
        }
    }
}
