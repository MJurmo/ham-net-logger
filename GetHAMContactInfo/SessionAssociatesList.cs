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
            _lastUserTxtBox = txtUser_1;

        }

        //private System.Drawing.Point _lastTextBox;
        private string _currentAssociatCallsign;
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
                    //MessageBox.Show(((TextBox)sender).Name.IndexOf("_").ToString());
                    //MessageBox.Show(((TextBox)sender).Name.Length.ToString());
                    //MessageBox.Show(((TextBox)sender).Name.Substring(((TextBox)sender).Name.IndexOf("_"), ((TextBox)sender).Name.Length - ((TextBox)sender).Name.IndexOf("_")));
                    //MessageBox.Show(((TextBox)sender).Name.Substring(((TextBox)sender).Name.IndexOf("_"), ((TextBox)sender).Name.Length - ((TextBox)sender).Name.IndexOf("_")));
                    (this.Controls.Find("txtAssociateName" + ((TextBox)sender).Name.Substring(((TextBox)sender).Name.IndexOf("_"), ((TextBox)sender).Name.Length - ((TextBox)sender).Name.IndexOf("_")), false))[0].Text = dr["name"].ToString();
                    _currentAssociatCallsign = ((TextBox)sender).Text;
                    MessageBox.Show(_currentAssociatCallsign);
                    //((TextBox) sender).Enabled = false;
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
                    if (((TextBox) sender).Text != _currentAssociatCallsign)
                    {
                        MessageBox.Show("You modified a previously entered call sign!");
                    }
                    if (
                        MessageBox.Show("This ID is not in your database, would you like to look it up?",
                                        "User not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Lookup_Results code = Lookup_Results.NOERROR;

                        AssociateLookup AssociateLookup = new AssociateLookup(((TextBox) sender).Text.ToString());
                        code = AssociateLookup.ShowDialogWithResults();
                        if (code == Lookup_Results.NOTFOUND)
                        {
                            if (
                                MessageBox.Show(
                                    "Auto lookup could not find this call sign. Would you like to add it manually?",
                                    "Add Call Sign", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                AssociateLookup al = new AssociateLookup(((TextBox)sender).Text.ToString());
                                al._bManualEntry = true;
                                al.ShowDialogWithResults();
                                
                            }
                            else
                            {
                                MessageBox.Show("Invalid Entry");
                                return;
                            }
                        }
                        
                        if (
                            !AssociatesController.GetDataSet().Tables[0].Rows.Contains(
                                ((TextBox) sender).Text.ToString()))
                        {
                            MessageBox.Show("Could not find associate, please check your call sign and retry.");
                            return;
                        }
                        txtUser1_KeyDown(sender, e);
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
                                                          _lastUserTxtBox.Location.Y + txtUser_1.Height + 5);
            newAssociateBox.Width = _lastUserTxtBox.Width;
            newAssociateBox.KeyDown += txtUser1_KeyDown;
            newAssociateBox.Enter += txtUser1_Enter;
            newAssociateBox.Name = "txtUser_" + (++_usercount).ToString();
            this.Controls.Add(newAssociateBox);
            newAssociateBox.Focus();
            _lastUserTxtBox = newAssociateBox;

            //Associate Name
            TextBox newAssociateName = new TextBox();
            newAssociateName.Location = new System.Drawing.Point(txtAssociateName_1.Location.X,
                                                          origUserTextBox.Location.Y + txtUser_1.Height + 5);
            newAssociateName.Width = txtAssociateName_1.Width;
            newAssociateName.Enabled = false;
            newAssociateName.Name = "txtAssociateName_" + (_usercount).ToString();
            this.Controls.Add(newAssociateName);

        }

        private void txtUser1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser1_Enter(object sender, EventArgs e)
        {
            _currentAssociatCallsign = ((TextBox) sender).Text;
            MessageBox.Show(_currentAssociatCallsign);
        }

        private void txtUser1_Leave(object sender, EventArgs e)
        {
            if (((TextBox) sender).Text != _currentAssociatCallsign)
            {
                MessageBox.Show("take care of editing");
                ((TextBox) sender).Focus();
            }
        }
    }
}
