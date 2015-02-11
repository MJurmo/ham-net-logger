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
        public Session_Command()
        {
            InitializeComponent();
            cboOrganization.DataSource = OrganizationController.GetDataSet().Tables[0];
            cboOrganization.DisplayMember = "ID";
            SelectedAssociates.getTable().Clear();
            lstAssociates.DataSource = SelectedAssociates.getTable();
            lstAssociates.DisplayMember = "ID";
            lstAssociates.ContextMenuStrip = ctxAssociateActions;
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

        private void lstAssociates_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (((ListBox) sender).SelectedItem != null)
                {
                    ctxAssociateActions.Show(Cursor.Position);
                    
                }
            }

        }

        private void ctxAssociateActions_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void ctxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnBeginEndSession.Text == "End Session")
            {
                Form radiogram = new RADIOGRAM2(((DataRowView) lstAssociates.SelectedItem).Row["ID"].ToString(),
                                                txtSessionID.Text);
                radiogram.Show();
            }
            else
            {
                MessageBox.Show("You must bress [Begin Session] before you can add net traffic.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form preamble = new Preamble(((DataRowView)cboOrganization.SelectedItem).Row["band"].ToString(), ((DataRowView)cboOrganization.SelectedItem).Row["agency"].ToString());
            preamble.Show();
        }
    }
}
