using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace GetHAMContactInfo
{
    public partial class Form1 : Form
    {
        bool gettingname = false;
        bool gettingcoordinants = false;
        HtmlDocument m_doc=null;
        bool loggedin = false;
        //WebClient client = new WebClient();
        public Form1()
        {
            InitializeComponent();
            try
            {
                webBrowser1.Navigate("http://www.Qrz.com");
                
                return;
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
            if (m_doc != webBrowser1.Document)
            {
                m_doc = webBrowser1.Document;
            }
            
            checkLogin();
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
                    address = address.Substring(address.IndexOf(trimstr)+4);
                    txtCity.Text = address.Substring(0, address.IndexOf("<BR>"));
                    address = address.Substring(address.IndexOf(txtCity.Text));
                    address = address.Substring(address.IndexOf(trimstr));
                    txtCountry.Text = collect[0].InnerHtml.Substring(collect[0].InnerHtml.LastIndexOf("<BR>") + 4);
                    HtmlElement email = m_doc.GetElementById("qem");
                    if (email != null)
                    {
                        
                        email.InvokeMember("click");
                        txtEmail.Text=email.InnerText;
                    }
                    gettingname = false;
                }
                
                HtmlElementCollection coll = m_doc.GetElementsByTagName("TR");
                foreach (HtmlElement ele2 in coll)
                {
                    HtmlElementCollection innerCollection = ele2.GetElementsByTagName("TD");
                    if (innerCollection.Count==2)
                    {
                        switch(innerCollection[0].InnerText)
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
                }
                ele.SetAttribute("value", textBox1.Text);
                ele = getElement("INPUT", "value","Search");
                if (ele != null)
                {
                    ele.InvokeMember("click");
                    gettingname = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't know where to save yet!");
        }
        private void checkLogin()
        {
            HtmlElement elem, tboxUsername, tboxPassword, btnContinue, btnLogin;
            tboxUsername = m_doc.GetElementById("username");
            tboxPassword = m_doc.GetElementById("password");
            btnContinue = getElement("INPUT", "value", "Continue");
            btnLogin = getElement("INPUT", "value", "Login");
            if ((btnContinue != null || btnLogin != null) && tboxUsername != null && tboxPassword != null)
            {
                tboxPassword.SetAttribute("value", txtPassword.Text);
                tboxUsername.SetAttribute("value", txtUserName.Text);
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
                HtmlElement ele = m_doc.GetElementById("tquery");
                if (ele != null)
                {
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogon.Text = "Logged On!";
                    btnLogon.Enabled = false;
                    return;
                }
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            checkLogin();
        }
    }
}
