using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    class session_associateController
    {
       private static DataSet ds_session_associate = null;

       private session_associateController()
        {
        }

        public static DataSet GetDataSet()
        {
            if (ds_session_associate == null)
            {
                ds_session_associate = new DataSet();
                ds_session_associate.ReadXml("../../Data/associate_session.xml");
            }
            return ds_session_associate;
        }

        public static void AddAssociat(string associate, string session)
        {
            DataRow dr = GetDataSet().Tables[0].NewRow();
            dr["call_sign"] = associate;
            dr["session_ID"] = session;
            GetDataSet().Tables[0].Rows.Add(dr);
            GetDataSet().AcceptChanges();
        }

        public static void SaveDataSet()
        {
            if (ds_session_associate != null)
            {
                ds_session_associate.WriteXml("../../Data/associate_session.xml");
            }
        }
    }
}
