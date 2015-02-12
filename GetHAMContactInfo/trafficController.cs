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

        
    }
}
