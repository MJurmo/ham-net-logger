using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    
    internal class trafficController
    {
        private static DataSet dsTraffic = null;
        private trafficController()
        {
        }
        public static void AddTraffic(DataRow dr)
        {
            dsTraffic.Tables[0].Rows.Add(dr);
        }
        public static DataSet GetDataSet()
        {
            if (dsTraffic == null)
            {
                dsTraffic = new DataSet();
                dsTraffic.ReadXml("../../Data/traffic.xml");
            }
            dsTraffic.Tables[0].PrimaryKey = new DataColumn[] { dsTraffic.Tables[0].Columns["associate_call_sign"], dsTraffic.Tables[0].Columns["number"] };
            return dsTraffic;
        }           

        public static void SaveDataSet()
        {
            dsTraffic.WriteXml("../../Data/traffic.xml");
        }
        public static void UpdateTraffic(string sessionID, string assoc_call_sign, string target, string passed_to, string number)
        {
            string[] key = {assoc_call_sign,number};
            bool bNeedAdd = false;
            DataRow dr = GetDataSet().Tables[0].Rows.Find(key);
            if(dr == null)
            {
                dr = GetDataSet().Tables[0].NewRow();
                bNeedAdd = true;
            }
            dr["sessionID"] = sessionID;
            dr["associate_call_sign"] = assoc_call_sign;
            dr["target"] = target;
            dr["passed_to"] = passed_to;
            dr["number"] = number;
            if(bNeedAdd)AddTraffic(dr);
            
            GetDataSet().AcceptChanges();
        }

        public static DataTable GetUserTraffic(string callsign)
        {
            DataTable dt= new DataTable();
            var queryUserTraffic = from traff in GetDataSet().Tables[0].AsEnumerable()
                                   where traff.Field<string>("associate_call_sign") == callsign
                                   select new object[]
                                       {
                                           traff.Field<string>("number"),
                                           traff.Field<string>("target"),
                                           traff.Field<string>("passed_to")
                                       };
            dt.Columns.Add("number");
            dt.Columns.Add("target");
            dt.Columns.Add("passed_to");
            foreach (var row in queryUserTraffic)
            {
                dt.Rows.Add(row);
            }
            return dt;
        }


    }
}
