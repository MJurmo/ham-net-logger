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
    public partial class Session_Command : Form
    {
        private Form selectassociates = new SelectAssociates();
        private DateTime sessionstart = new DateTime();
        private string m_currentAssociate;
        public Session_Command()
        {
            InitializeComponent();
            cboOrganization.DataSource = OrganizationController.GetDataSet().Tables[0];
            cboOrganization.DisplayMember = "ID";
            SelectedAssociates.getTable().Clear();
            InitGridTraffic();
        }

        private void InitGridTraffic()
        {
        }

        private void SaveSession()
        {
            DataRow dr = SessionsController.GetDataSet().Tables[0].Rows.Find(txtSessionID.Text);
            dr["ID"] = txtSessionID.Text;
            
            TimeSpan diff = DateTime.Now - sessionstart;
            dr["session_length"] = string.Format("Session duration:{0:N0}MIN;{1:N0}SEC;", diff.Minutes, diff.Seconds);
            dr["participants"] = SelectedAssociates.getTable().Rows.Count.ToString();
            
            SessionsController.SaveDataSet();
            foreach (DataRow selectedassociate in SelectedAssociates.getTable().AsEnumerable())
            {
                session_associateController.AddAssociat(selectedassociate["ID"].ToString(),txtSessionID.Text);
            }
            session_associateController.SaveDataSet();
            RadiogramsController.SaveDataSet();
        }
        private void btnBeginEndSession_Click(object sender, EventArgs e)
        {
            if (btnBeginEndSession.Text == "Begin Session")
            {
                sessionstart = DateTime.Now;
                cboOrganization.Enabled = false;
                DataRow dr = SessionsController.GetDataSet().Tables[0].NewRow();
                dr["ID"] = txtSessionID.Text;
                SessionsController.GetDataSet().Tables[0].Rows.Add(dr);
                SessionsController.GetDataSet().AcceptChanges();
                MessageBox.Show("Session Began @:" + sessionstart.ToString());
                btnBeginEndSession.Text = "End Session";
            }
            else if (btnBeginEndSession.Text == "End Session")
            {
                if (MessageBox.Show("Are you sure you want to end the session?", "Warning!", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {  
                    btnBeginEndSession.Text = "Session Ended";
                    SaveSession();
                    this.Close();
                }
            }
        }
        private void Session_Command_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnBeginEndSession.Text == "End Session")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to end the session?", "Warning!", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                    {
                        SaveSession();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void btnAddAssociates_Click(object sender, EventArgs e)
        {
            if (selectassociates.IsDisposed)
            {
                selectassociates= new SelectAssociates();
            }
            selectassociates.ShowDialog();
        }

        private void cboOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSessionID.Text = SessionsController.GetNewSessionID(((DataRowView)cboOrganization.SelectedItem).Row["ID"].ToString());
        }

        private void lstAssociates_MouseClick(object sender, MouseEventArgs e)
        {

        }

        

        

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form preamble = new Preamble(((DataRowView)cboOrganization.SelectedItem).Row["band"].ToString(), ((DataRowView)cboOrganization.SelectedItem).Row["agency"].ToString());
            preamble.Show();
        }

        private void gridTraffic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
        }

      

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sessionAssociatesList1_Load(object sender, EventArgs e)
        {

        }
    }
}
