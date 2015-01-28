using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace GetHAMContactInfo
{
    public partial class AssociateLookup : Form
    {
        
        bool gettingname = false;
        bool gettingcoordinants = false;
        HtmlDocument m_doc=null;
        bool loggedin = false;
        private bool waiting_for_credentials = false;
        private string m_ID="";
        private string username, password;
        private bool autorun = false;
        private MessageBox invalidLogin;
        //WebClient client = new WebClient();
        public AssociateLookup(string ID)
        {
            InitializeComponent();
            try
            {
                webBrowser1.Navigate("http://www.Qrz.com");
                m_ID = ID;
                textBox1.Text = ID;
            }
            catch (WebException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            HtmlElement elem = m_doc.Body;
            PageSource dlg = new PageSource(elem.InnerHtml);
            dlg.Show();
        }

        private void btnCurrELEM_Click(object sender, EventArgs e)
        {

            MessageBox.Show(m_doc.ActiveElement.OuterHtml);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }
        private HtmlElement getElement(string type, string attribute,string elementname)
        {
            HtmlElement elem = null;
            HtmlElementCollection inputs = m_doc.GetElementsByTagName(type);
            foreach (HtmlElement element in inputs)
            {
                if (element.GetAttribute(attribute) == elementname)
                {
                    return elem = element;
                }
            }
            return elem;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtUSCounty.Clear();
                txtName.Clear();
                txtLongitude.Clear();
                txtLatitude.Clear();
                txtClass.Clear();
                txtBearing.Clear();
                txtBorn.Clear();
                txtCity.Clear();
                txtCountry.Clear();
                txtGridSquare.Clear();
                txtDistance.Clear();
                txtAddress.Clear();
                txtUSState.Clear();
                txtEmail.Clear();
                
                HtmlElement ele=m_doc.GetElementById("tquery");
                if (ele == null)
                {
                    MessageBox.Show("Invalid Logon, please reenter proper cridentials!");
                    return;
                }
                else
                {
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogon.Text = "Logged On!";
                    btnLogon.Enabled = false;
                    Lookup(ele);
                }
                
            }
        }

        private void Lookup(HtmlElement ele)
        {
            
            if (textBox1.Text != "")
            {
                ele.SetAttribute("value", textBox1.Text);
                ele = getElement("INPUT", "value", "Search");
                if (ele != null)
                {
                    ele.InvokeMember("click");
                    gettingname = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (m_ID != "")
            {
                AssociatesController.GetDataSet().AcceptChanges();
                DataRow[] associateRow = AssociatesController.GetDataSet().Tables[0].Select("ID = '" + m_ID + "'");

                associateRow[0]["name"] = txtName.Text;
                associateRow[0]["address"] = txtAddress.Text;
                associateRow[0]["city-state-zip"] = txtCity.Text;
                associateRow[0]["country"] = txtCountry.Text;
                associateRow[0]["class"] = txtClass.Text;
                associateRow[0]["latitude"] = txtLatitude.Text;
                associateRow[0]["longitude"] = txtLongitude.Text;
                associateRow[0]["email"] = txtEmail.Text;
                associateRow[0]["birthdate"] = txtBorn.Text;
                associateRow[0]["bearing"] = txtBearing.Text;
                associateRow[0]["distance"] = txtDistance.Text;
                associateRow[0]["us-county"] = txtUSCounty.Text;
                associateRow[0]["us-state"] = txtUSState.Text;
                associateRow[0]["grid-square"] = txtGridSquare.Text;
                AssociatesController.GetDataSet().AcceptChanges();
            }
            else
            {
                MessageBox.Show("No ID!");
            }
            this.Close();
        }
        private bool checkLogin()
        {
            HtmlElement elem, tboxUsername, tboxPassword, btnContinue, btnLogin;
            tboxUsername = m_doc.GetElementById("username");
            tboxPassword = m_doc.GetElementById("password");
            btnContinue = getElement("INPUT", "value", "Continue");
            btnLogin = getElement("INPUT", "value", "Login");

            if ((btnContinue != null || btnLogin != null) && tboxUsername != null && tboxPassword != null)
            {
                if (txtPassword.Text != "" && txtUserName.Text != "")
                {
                    
                    if (username == txtUserName.Text && password == txtPassword.Text)
                    {
                        MessageBox.Show("Invalid Credentials, try again!");
                        waiting_for_credentials = true;
                    }
                    else
                    {
                        username = txtUserName.Text;
                        password = txtPassword.Text;
                        waiting_for_credentials = false;
                    }
                    tboxPassword.SetAttribute("value", password);
                    tboxUsername.SetAttribute("value", username);
                    
                    if (btnContinue != null)
                    {
                        btnContinue.InvokeMember("click");
                    }
                    else if (btnLogin != null)
                    {
                        btnLogin.InvokeMember("click");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Username and Password and Press Login Button.");
                    
                    waiting_for_credentials = true;
                }
            }
            else
            {
                HtmlElement ele = m_doc.GetElementById("tquery");
                if (ele != null)
                {
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogon.Text = "Logged On!";
                    btnLogon.Enabled = false;
                    loggedin = true;
                    waiting_for_credentials = false;
                    if (m_ID != "" && !autorun)
                    {
                        textBox1.Enabled = false;
                        autorun = true;
                        Lookup(ele);
                    }
                }
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (m_doc != webBrowser1.Document)
            {
                m_doc = webBrowser1.Document;
            }
            if (waiting_for_credentials && !loggedin)
            {
                return;
            }
            else if (!loggedin)
            {
                checkLogin();
            }
            else
            {
                checkLogin();
            }
            if (m_doc.Body != null)
            {
                if (m_doc.Body.InnerText != null)
                {
                    String innertText = m_doc.Body.InnerText;
                    if (innertText.IndexOf("Daily usage limit exceeded") > -1)
                    {
                        MessageBox.Show(
                            "You have reached your daily limit, you may only search for you own call sign data!");
                        this.Close();
                        return;
                    }
                }
            }

            if (m_doc.GetElementById("qrzcenter") != null)
            {
                if (m_doc.GetElementById("qrzcenter").InnerText.IndexOf("produced no results") > -1)
                {
                    MessageBox.Show("Call Sign NOT FOUND!");
                    this.Close();
                    return;
                }
            }
            
            if (gettingname)
            {
                HtmlElement ele = null;
                ele = m_doc.GetElementById("csdata");
                if (ele != null)
                {
                    HtmlElementCollection collect = ele.GetElementsByTagName("P");
                    string address = collect[0].InnerHtml;
                    txtName.Text = collect[0].InnerHtml.Substring(0, address.IndexOf("<"));
                    address = address.Substring(address.IndexOf(txtName.Text));
                    address = address.Substring(address.IndexOf("SPAN><BR>") + 9);
                    txtAddress.Text = address.Substring(0, address.IndexOf("<BR>"));
                    address = address.Trim(txtAddress.Text.ToCharArray());
                    string trimstr = "<BR>";
                    address = address.Substring(address.IndexOf(trimstr) + 4);
                    txtCity.Text = address.Substring(0, address.IndexOf("<BR>"));
                    address = address.Substring(address.IndexOf(txtCity.Text));
                    address = address.Substring(address.IndexOf(trimstr));
                    txtCountry.Text = collect[0].InnerHtml.Substring(collect[0].InnerHtml.LastIndexOf("<BR>") + 4);
                    HtmlElement email = m_doc.GetElementById("qem");
                    if (email != null)
                    {

                        email.InvokeMember("click");
                        txtEmail.Text = email.InnerText;
                    }
                    gettingname = false;
                }

                HtmlElementCollection coll = m_doc.GetElementsByTagName("TR");
                foreach (HtmlElement ele2 in coll)
                {
                    HtmlElementCollection innerCollection = ele2.GetElementsByTagName("TD");
                    if (innerCollection.Count == 2)
                    {
                        switch (innerCollection[0].InnerText)
                        {
                            case "Class":
                                txtClass.Text = innerCollection[1].InnerText;
                                break;
                            case "Grid Square":
                                txtGridSquare.Text = innerCollection[1].InnerText;
                                break;
                            case "US State":
                                txtUSState.Text = innerCollection[1].InnerText;
                                break;
                            case "US County":
                                txtUSCounty.Text = innerCollection[1].InnerText;
                                break;
                            case "Bearing":
                                txtBearing.Text = innerCollection[1].InnerText;
                                break;
                            case "Distance":
                                txtDistance.Text = innerCollection[1].InnerText;
                                break;
                            case "Latitude":
                                txtLatitude.Text = innerCollection[1].InnerText;
                                break;
                            case "Longitude":
                                txtLongitude.Text = innerCollection[1].InnerText;
                                break;
                            case "Born":
                                txtBorn.Text = innerCollection[1].InnerText;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }
    }
}
