using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    class SessionsController
    {
        private static DataSet dsSessions = null;

        private SessionsController()
        {
        }

        public static string GetNewSessionID(string organization_band)
        {
            string strReturn = "";
            var sessions =
    SessionsController.GetDataSet().Tables[0].Select()
                                             .Where(
                                                 p =>
                                                 p.Field<string>("ID")
                                                  .Contains(organization_band));
            int iHighestNum = 0;
            string strCurrSession = "";
            String strCurrNumber = "";
            int iNumber = 0;
            foreach (DataRow dr in sessions)
            {
                strCurrSession = dr["ID"].ToString();
                iNumber = Convert.ToInt32(strCurrSession.Substring(strCurrSession.IndexOf("-") + 1));
                if (iHighestNum < iNumber)
                {
                    iHighestNum = iNumber;
                }
            }
            iHighestNum++;
            strReturn = organization_band  + "-" + iHighestNum.ToString();
            return strReturn;
        }

        public static DataSet GetDataSet()
        {
            try
            {
                if (dsSessions == null)
                {
                    dsSessions = new DataSet();
                    dsSessions.ReadXml("../../Data/sessions.xml");
                }
                dsSessions.Tables[0].PrimaryKey = new DataColumn[] { dsSessions.Tables[0].Columns["ID"] };
                return dsSessions;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            
        }           

        public static void SaveDataSet()
        {
            dsSessions.WriteXml("../../Data/sessions.xml");
        }
    }
}
