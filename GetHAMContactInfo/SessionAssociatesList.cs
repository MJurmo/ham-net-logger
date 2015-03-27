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
            _lastTextBox = txtUser1;
        }

        //private System.Drawing.Point _lastTextBox;
        private TextBox _lastTextBox;
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
                    }
                    else
                    {
                        MessageBox.Show("Please enter an associate ID.");
                    }
                    return;
                }
                else if (AssociatesController.GetDataSet().Tables[0].Rows.Contains(((TextBox) sender).Text.ToString()))
                {

                    MessageBox.Show("loading associate data");
                    if (
                        MessageBox.Show("Do you have more associates to add to this session?",
                                        "Add Associates?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TextBox newTxtBox = new TextBox();
                        newTxtBox.Location = new System.Drawing.Point(_lastTextBox.Location.X,
                                                                      _lastTextBox.Location.Y + txtUser1.Height + 5);
                        newTxtBox.Width = _lastTextBox.Width;
                        newTxtBox.KeyDown += txtUser1_KeyDown;
                        this.Controls.Add(newTxtBox);
                        newTxtBox.Focus();
                        _lastTextBox = newTxtBox;
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

        private void txtUser1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
