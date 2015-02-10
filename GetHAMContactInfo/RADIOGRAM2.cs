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
    public partial class RADIOGRAM2 : Form
    {
        private string m_ID;
        private string m_sessionID;
        
        public RADIOGRAM2(string ID, string sessionID="")
        {
            InitializeComponent();
            m_ID = ID;
            m_sessionID = sessionID;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void RADIOGRAM2_ResizeBegin(object sender, EventArgs e)
        {
            this.SuspendLayout();
        }

        private void RADIOGRAM2_ResizeEnd(object sender, EventArgs e)
        {
            this.ResumeLayout(true);
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void RADIOGRAM2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txt_number.Focus())
            {
                txt_hx.Focus();
            }
            DialogResult dr = MessageBox.Show("Would you like to save your entry/changes?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                RadiogramsController.GetDataSet().AcceptChanges();
                if (m_sessionID != "")
                {
                    DataRow sessiondr = SessionsController.GetDataSet().Tables[0].Rows.Find(m_sessionID);
                    try
                    {
                        string currTrafficBrought = sessiondr["traffic_brought"].ToString();
                        if (currTrafficBrought == "") currTrafficBrought = "0";
                        Int32 iTrafficBrought = Convert.ToInt32(currTrafficBrought);
                        iTrafficBrought++;
                        sessiondr["traffic_brought"] = iTrafficBrought.ToString();
                        SessionsController.GetDataSet().AcceptChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                        throw;
                    }
                }
                DataRow diagramRow = RadiogramsController.GetDataSet().Tables[0].Rows.Find(m_ID);

                try
                {
                    
                    diagramRow["number"] = txt_number.Text;
                    diagramRow["sessionID"] = m_sessionID;
                    diagramRow["precedence"] = txt_precedence.Text;
                    diagramRow["hx"] = txt_hx.Text;
                    diagramRow["st-of-origin"] = txt_st_of_origin.Text;
                    diagramRow["check"] = txt_check.Text;
                    diagramRow["place-of-origin"] = txt_place_of_origin.Text;
                    diagramRow["time-filed"] = txt_time_filed.Text;
                    diagramRow["date"] = txt_date.Text;
                    diagramRow["am-station"] = txt_am_station.Text;
                    diagramRow["am-phone"] = txt_am_phone.Text;
                    diagramRow["am-name"] = txt_am_name.Text;
                    diagramRow["am-address"] = txt_am_address.Text;
                    diagramRow["am-csz"] = txt_am_csz.Text;
                    diagramRow["am-email"] = txt_am_email.Text;
                    diagramRow["to-name"] = txt_to_name.Text;
                    diagramRow["to-call-sign"] = txt_to_call_sign.Text;
                    diagramRow["to-address"] = txt_to_address.Text;
                    diagramRow["to-csz"] = txt_to_csz.Text;
                    diagramRow["to-phone"] = txt_to_phone.Text;
                    diagramRow["to-email"] = txt_to_email.Text;
                    diagramRow["word1"] = txt_word1.Text;
                    diagramRow["word2"] = txt_word2.Text;
                    diagramRow["word3"] = txt_word3.Text;
                    diagramRow["word4"] = txt_word4.Text;
                    diagramRow["word5"] = txt_word5.Text;
                    diagramRow["word6"] = txt_word6.Text;
                    diagramRow["word7"] = txt_word7.Text;
                    diagramRow["word8"] = txt_word8.Text;
                    diagramRow["word9"] = txt_word9.Text;
                    diagramRow["word10"] = txt_word10.Text;
                    diagramRow["word11"] = txt_word11.Text;
                    diagramRow["word12"] = txt_word12.Text;
                    diagramRow["word13"] = txt_word13.Text;
                    diagramRow["word14"] = txt_word14.Text;
                    diagramRow["word15"] = txt_word15.Text;
                    diagramRow["word16"] = txt_word16.Text;
                    diagramRow["word17"] = txt_word17.Text;
                    diagramRow["word18"] = txt_word18.Text;
                    diagramRow["word19"] = txt_word19.Text;
                    diagramRow["word20"] = txt_word20.Text;
                    diagramRow["word21"] = txt_word21.Text;
                    diagramRow["word22"] = txt_word22.Text;
                    diagramRow["word23"] = txt_word23.Text;
                    diagramRow["word24"] = txt_word24.Text;
                    diagramRow["word25"] = txt_word25.Text;
                    diagramRow["sig-from"] = txt_sig_from.Text;
                    diagramRow["sig-from-date"] = txt_sig_from_date.Text;
                    diagramRow["sig-from-time"] = txt_sig_from_time.Text;
                    diagramRow["sig-to"] = txt_sig_to.Text;
                    diagramRow["sig-to-date"] = txt_sig_to_date.Text;
                    diagramRow["sig-to-time"] = txt_sig_to_time.Text;
                    RadiogramsController.GetDataSet().AcceptChanges();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }

            }
        }

        private void RADIOGRAM2_Load(object sender, EventArgs e)
        {

           

            RadiogramsController.GetDataSet().AcceptChanges();
                DataRow diagramRow = RadiogramsController.GetDataSet().Tables[0].Rows.Find(m_ID);
                try
                {
                    if (diagramRow == null)
                    {
                        DataRow dr = RadiogramsController.GetDataSet().Tables[0].NewRow();
                        dr["ID"] = m_ID;
                        dr["number"] = "";
                        dr["sessionID"] = m_sessionID;
                        RadiogramsController.GetDataSet().Tables[0].Rows.Add(dr);
                        RadiogramsController.GetDataSet().AcceptChanges();
                        diagramRow = RadiogramsController.GetDataSet().Tables[0].Rows.Find(m_ID);

                    }
                    txt_number.Text=diagramRow["number"].ToString();
                    if (txt_number.Text == "")
                    {
                        if (m_ID.IndexOf("-") > -1)
                        {
                            string strIDnum = m_ID.Substring(m_ID.IndexOf("-") + 1);
                            if (strIDnum.Length > 0)
                            {
                                txt_number.Text = strIDnum;
                            }
                        }
                    }
                    txt_precedence.Text = diagramRow["precedence"].ToString();
                    m_sessionID = diagramRow["sessionID"].ToString();
                    txt_hx.Text = diagramRow["hx"].ToString();
                    txt_st_of_origin.Text = diagramRow["st-of-origin"].ToString();
                    txt_check.Text = diagramRow["check"].ToString();
                    txt_place_of_origin.Text = diagramRow["place-of-origin"].ToString();
                    txt_time_filed.Text = diagramRow["time-filed"].ToString();
                    txt_date.Text = diagramRow["date"].ToString();
                    txt_am_station.Text = diagramRow["am-station"].ToString();
                    txt_am_phone.Text = diagramRow["am-phone"].ToString();
                    txt_am_name.Text = diagramRow["am-name"].ToString();
                    txt_am_address.Text = diagramRow["am-address"].ToString();
                    txt_am_csz.Text = diagramRow["am-csz"].ToString();
                    txt_am_email.Text = diagramRow["am-email"].ToString();
                    txt_to_name.Text = diagramRow["to-name"].ToString();
                    txt_to_call_sign.Text = diagramRow["to-call-sign"].ToString();
                    txt_to_address.Text = diagramRow["to-address"].ToString();
                    txt_to_csz.Text = diagramRow["to-csz"].ToString();
                    txt_to_phone.Text = diagramRow["to-phone"].ToString();
                    txt_to_email.Text = diagramRow["to-email"].ToString();
                    txt_word1.Text = diagramRow["word1"].ToString();
                    txt_word2.Text = diagramRow["word2"].ToString();
                    txt_word3.Text = diagramRow["word3"].ToString();
                    txt_word4.Text = diagramRow["word4"].ToString();
                    txt_word5.Text = diagramRow["word5"].ToString();
                    txt_word6.Text = diagramRow["word6"].ToString();
                    txt_word7.Text = diagramRow["word7"].ToString();
                    txt_word8.Text = diagramRow["word8"].ToString();
                    txt_word9.Text = diagramRow["word9"].ToString();
                    txt_word10.Text = diagramRow["word10"].ToString();
                    txt_word11.Text = diagramRow["word11"].ToString();
                    txt_word12.Text = diagramRow["word12"].ToString();
                    txt_word13.Text = diagramRow["word13"].ToString();
                    txt_word14.Text = diagramRow["word14"].ToString();
                    txt_word15.Text = diagramRow["word15"].ToString();
                    txt_word16.Text = diagramRow["word16"].ToString();
                    txt_word17.Text = diagramRow["word17"].ToString();
                    txt_word18.Text = diagramRow["word18"].ToString();
                    txt_word19.Text = diagramRow["word19"].ToString();
                    txt_word20.Text = diagramRow["word20"].ToString();
                    txt_word21.Text = diagramRow["word21"].ToString();
                    txt_word22.Text = diagramRow["word22"].ToString();
                    txt_word23.Text = diagramRow["word23"].ToString();
                    txt_word24.Text = diagramRow["word24"].ToString();
                    txt_word25.Text = diagramRow["word25"].ToString();
                    txt_sig_from.Text = diagramRow["sig-from"].ToString();
                    txt_sig_from_date.Text = diagramRow["sig-from-date"].ToString();
                    txt_sig_from_time.Text = diagramRow["sig-from-time"].ToString();
                    txt_sig_to.Text = diagramRow["sig-to"].ToString();
                    txt_sig_to_date.Text = diagramRow["sig-to-date"].ToString();
                    txt_sig_to_time.Text = diagramRow["sig-to-time"].ToString();
                    RadiogramsController.GetDataSet().AcceptChanges();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
        }

        private void txt_number_Leave(object sender, EventArgs e)
        {
            DataRow diagramRow = RadiogramsController.GetDataSet().Tables[0].Rows.Find(m_ID);
            string strSearchID="";
            bool bDuplicate = false;
            if (!m_ID.Contains("-"))
            {
                strSearchID += m_ID + "-" + txt_number.Text;
                if (RadiogramsController.FindID(strSearchID, ref bDuplicate))
                {
                    MessageBox.Show(
                        "Radiogram already exists with this number for this associate, please enter another number.");
                    txt_number.Text = "";
                    txt_number.Focus();
                }
                else
                {

                    m_ID = strSearchID;
                    try
                    {
                        diagramRow["ID"] = m_ID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                string strIDnum = m_ID.Substring(m_ID.IndexOf("-")+1);
                string strIDprefix = m_ID.Substring(0, m_ID.IndexOf("-"));
                
                if (strIDnum != txt_number.Text)
                {
                    if (!RadiogramsController.FindID(strIDprefix + "-" + txt_number.Text, ref bDuplicate))
                    {
                        m_ID = m_ID.Replace(strIDnum, txt_number.Text);
                        diagramRow["ID"] = m_ID;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Radiogram already exists with this number for this associate, please enter another number.");
                        txt_number.Text = strIDnum;
                        txt_number.Focus();
                    }
                }
                //if(txt_number.Text != )
            }

        }
    }
}
