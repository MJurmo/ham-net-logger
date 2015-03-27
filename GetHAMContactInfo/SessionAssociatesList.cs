using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GetHAMContactInfo
{
    public partial class SessionAssociatesList : UserControl
    {
        public SessionAssociatesList()
        {
            InitializeComponent();
            _lastUserTxtBox = txtUser1;

        }

        //private System.Drawing.Point _lastTextBox;
        private int _usercount = 1;
        private TextBox _lastUserTxtBox;
        private int _iAssociateCount = 1;
        private void txtUser1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (((TextBox) sender).Text == "")
                {
                    if (
                        MessageBox.Show("Are you done entering associates?",
                                        "Remove Row?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Controls.Remove((TextBox)sender);
                        _usercount--;
                        foreach (Control ctrl in this.Controls)
                        {
                            if (ctrl.Name == "txtUser" + _usercount.ToString())
                            {
                                _lastUserTxtBox = (TextBox)ctrl;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an associate ID.");
                    }
                    return;
                }
                else if (AssociatesController.GetDataSet().Tables[0].Rows.Contains(((TextBox) sender).Text.ToString()))
                {

                    DataRow dr = AssociatesController.GetDataSet().Tables[0].Rows.Find(((TextBox) sender).Text);
                    (this.Controls.Find("txtAssociateName" + _usercount.ToString(), false))[0].Text = dr["name"].ToString();
                       

                    if (
                        MessageBox.Show("Do you have more associates to add to this session?",
                                        "Add Associates?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (Control ctrl in this.Controls)
                        {
                            if (ctrl.Name.Contains("txtUser"))
                            {
                                if (ctrl.Text == "")
                                {
                                    ctrl.Focus();
                                    return;
                                }
                            }
                        }
                        AddNewRow();
                        
                        
                    }
                    
                }
                else
                {
                    if (
                        MessageBox.Show("This ID is not in your database, would you like to look it up?",
                                        "User not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Form AssociateLookup = new AssociateLookup(((TextBox) sender).Text.ToString());
                        AssociateLookup.ShowDialog();
                        if (
                            !AssociatesController.GetDataSet().Tables[0].Rows.Contains(
                                ((TextBox) sender).Text.ToString()))
                        {
                            MessageBox.Show("Could not find associate, please check your call sign and retry.");
                        }
                    }
                }
            }
        }

        private void AddNewRow()
        {

            TextBox origUserTextBox = _lastUserTxtBox;
            //Associate Call sign
            TextBox newAssociateBox = new TextBox();
            newAssociateBox.Location = new System.Drawing.Point(_lastUserTxtBox.Location.X,
                                                          _lastUserTxtBox.Location.Y + txtUser1.Height + 5);
            newAssociateBox.Width = _lastUserTxtBox.Width;
            newAssociateBox.KeyDown += txtUser1_KeyDown;
            newAssociateBox.Name = "txtUser" + (++_usercount).ToString();
            this.Controls.Add(newAssociateBox);
            newAssociateBox.Focus();
            _lastUserTxtBox = newAssociateBox;

            //Associate Name
            TextBox newAssociateName = new TextBox();
            newAssociateName.Location = new System.Drawing.Point(txtAssociateName1.Location.X,
                                                          origUserTextBox.Location.Y + txtUser1.Height + 5);
            newAssociateName.Width = txtAssociateName1.Width;
            newAssociateName.Enabled = false;
            newAssociateName.Name = "txtAssociateName" + (_usercount).ToString();
            this.Controls.Add(newAssociateName);

        }

        private void txtUser1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
