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

        public RADIOGRAM2(string ID)
        {
            InitializeComponent();
            m_ID = ID;
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
            DialogResult dr = MessageBox.Show("Would you like to save your entry/changes?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                RadiogramsController.GetDataSet().AcceptChanges();
                DataRow[] diagramRow = RadiogramsController.GetDataSet().Tables[0].Select("ID = '" + m_ID + "'");
                try
                {
                    diagramRow[0]["number"] = txt_number.Text;
                    diagramRow[0]["precedence"] = txt_precedence.Text;
                    diagramRow[0]["hx"] = txt_hx.Text;
                    diagramRow[0]["st-of-origin"] = txt_st_of_origin.Text;
                    diagramRow[0]["check"] = txt_check.Text;
                    diagramRow[0]["place-of-origin"] = txt_place_of_origin.Text;
                    diagramRow[0]["time-filed"] = txt_time_filed.Text;
                    diagramRow[0]["date"] = txt_date.Text;
                    diagramRow[0]["am-station"] = txt_am_station.Text;
                    diagramRow[0]["am-phone"] = txt_am_phone.Text;
                    diagramRow[0]["am-name"] = txt_am_name.Text;
                    diagramRow[0]["am-address"] = txt_am_address.Text;
                    diagramRow[0]["am-csz"] = txt_am_csz.Text;
                    diagramRow[0]["am-email"] = txt_am_email.Text;
                    diagramRow[0]["to-name"] = txt_to_name.Text;
                    diagramRow[0]["to-call-sign"] = txt_to_call_sign.Text;
                    diagramRow[0]["to-address"] = txt_to_address.Text;
                    diagramRow[0]["to-csz"] = txt_to_csz.Text;
                    diagramRow[0]["to-phone"] = txt_to_phone.Text;
                    diagramRow[0]["to-email"] = txt_to_email.Text;
                    diagramRow[0]["word1"] = txt_word1.Text;
                    diagramRow[0]["word2"] = txt_word2.Text;
                    diagramRow[0]["word3"] = txt_word3.Text;
                    diagramRow[0]["word4"] = txt_word4.Text;
                    diagramRow[0]["word5"] = txt_word5.Text;
                    diagramRow[0]["word6"] = txt_word6.Text;
                    diagramRow[0]["word7"] = txt_word7.Text;
                    diagramRow[0]["word8"] = txt_word8.Text;
                    diagramRow[0]["word9"] = txt_word9.Text;
                    diagramRow[0]["word10"] = txt_word10.Text;
                    diagramRow[0]["word11"] = txt_word11.Text;
                    diagramRow[0]["word12"] = txt_word12.Text;
                    diagramRow[0]["word13"] = txt_word13.Text;
                    diagramRow[0]["word14"] = txt_word14.Text;
                    diagramRow[0]["word15"] = txt_word15.Text;
                    diagramRow[0]["word16"] = txt_word16.Text;
                    diagramRow[0]["word17"] = txt_word17.Text;
                    diagramRow[0]["word18"] = txt_word18.Text;
                    diagramRow[0]["word19"] = txt_word19.Text;
                    diagramRow[0]["word20"] = txt_word20.Text;
                    diagramRow[0]["word21"] = txt_word21.Text;
                    diagramRow[0]["word22"] = txt_word22.Text;
                    diagramRow[0]["word23"] = txt_word23.Text;
                    diagramRow[0]["word24"] = txt_word24.Text;
                    diagramRow[0]["word25"] = txt_word25.Text;
                    diagramRow[0]["sig-from"] = txt_sig_from.Text;
                    diagramRow[0]["sig-from-date"] = txt_sig_from_date.Text;
                    diagramRow[0]["sig-from-time"] = txt_sig_from_time.Text;
                    diagramRow[0]["sig-to"] = txt_sig_to.Text;
                    diagramRow[0]["sig-to-date"] = txt_sig_to_date.Text;
                    diagramRow[0]["sig-to-time"] = txt_sig_to_time.Text;
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
                DataRow[] diagramRow = RadiogramsController.GetDataSet().Tables[0].Select("ID = '" + m_ID + "'");
                try
                {
                    txt_number.Text=diagramRow[0]["number"].ToString();
                    txt_precedence.Text = diagramRow[0]["precedence"].ToString();
                    txt_hx.Text = diagramRow[0]["hx"].ToString();
                    txt_st_of_origin.Text = diagramRow[0]["st-of-origin"].ToString();
                    txt_check.Text = diagramRow[0]["check"].ToString();
                    txt_place_of_origin.Text = diagramRow[0]["place-of-origin"].ToString();
                    txt_time_filed.Text = diagramRow[0]["time-filed"].ToString();
                    txt_date.Text = diagramRow[0]["date"].ToString();
                    txt_am_station.Text = diagramRow[0]["am-station"].ToString();
                    txt_am_phone.Text = diagramRow[0]["am-phone"].ToString();
                    txt_am_name.Text = diagramRow[0]["am-name"].ToString();
                    txt_am_address.Text = diagramRow[0]["am-address"].ToString();
                    txt_am_csz.Text = diagramRow[0]["am-csz"].ToString();
                    txt_am_email.Text = diagramRow[0]["am-email"].ToString();
                    txt_to_name.Text = diagramRow[0]["to-name"].ToString();
                    txt_to_call_sign.Text = diagramRow[0]["to-call-sign"].ToString();
                    txt_to_address.Text = diagramRow[0]["to-address"].ToString();
                    txt_to_csz.Text = diagramRow[0]["to-csz"].ToString();
                    txt_to_phone.Text = diagramRow[0]["to-phone"].ToString();
                    txt_to_email.Text = diagramRow[0]["to-email"].ToString();
                    txt_word1.Text = diagramRow[0]["word1"].ToString();
                    txt_word2.Text = diagramRow[0]["word2"].ToString();
                    txt_word3.Text = diagramRow[0]["word3"].ToString();
                    txt_word4.Text = diagramRow[0]["word4"].ToString();
                    txt_word5.Text = diagramRow[0]["word5"].ToString();
                    txt_word6.Text = diagramRow[0]["word6"].ToString();
                    txt_word7.Text = diagramRow[0]["word7"].ToString();
                    txt_word8.Text = diagramRow[0]["word8"].ToString();
                    txt_word9.Text = diagramRow[0]["word9"].ToString();
                    txt_word10.Text = diagramRow[0]["word10"].ToString();
                    txt_word11.Text = diagramRow[0]["word11"].ToString();
                    txt_word12.Text = diagramRow[0]["word12"].ToString();
                    txt_word13.Text = diagramRow[0]["word13"].ToString();
                    txt_word14.Text = diagramRow[0]["word14"].ToString();
                    txt_word15.Text = diagramRow[0]["word15"].ToString();
                    txt_word16.Text = diagramRow[0]["word16"].ToString();
                    txt_word17.Text = diagramRow[0]["word17"].ToString();
                    txt_word18.Text = diagramRow[0]["word18"].ToString();
                    txt_word19.Text = diagramRow[0]["word19"].ToString();
                    txt_word20.Text = diagramRow[0]["word20"].ToString();
                    txt_word21.Text = diagramRow[0]["word21"].ToString();
                    txt_word22.Text = diagramRow[0]["word22"].ToString();
                    txt_word23.Text = diagramRow[0]["word23"].ToString();
                    txt_word24.Text = diagramRow[0]["word24"].ToString();
                    txt_word25.Text = diagramRow[0]["word25"].ToString();
                    txt_sig_from.Text = diagramRow[0]["sig-from"].ToString();
                    txt_sig_from_date.Text = diagramRow[0]["sig-from-date"].ToString();
                    txt_sig_from_time.Text = diagramRow[0]["sig-from-time"].ToString();
                    txt_sig_to.Text = diagramRow[0]["sig-to"].ToString();
                    txt_sig_to_date.Text = diagramRow[0]["sig-to-date"].ToString();
                    txt_sig_to_time.Text = diagramRow[0]["sig-to-time"].ToString();
                    RadiogramsController.GetDataSet().AcceptChanges();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
        }
    }
}
