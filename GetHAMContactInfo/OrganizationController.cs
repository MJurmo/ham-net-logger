using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    class OrganizationController
    {
       private static DataSet dsOrganizations = null;

        private OrganizationController()
        {
        }

        
        public static void EditOrganization(DataRow dr)
        {
            RemoveIDColumn();
            string[] key =
                {
                    dr["band"].ToString(), dr["agency"].ToString()
                };
            dsOrganizations.Tables[0].Rows.Find(key).ItemArray  = dr.ItemArray;
            
            AddIDColumn();

        }
        public static void AddOrganization(DataRow dr)
        {
            dsOrganizations.Tables[0].Rows.Add(dr);
            RemoveIDColumn();
            AddIDColumn();
        }

        private static void RemoveIDColumn()
        {
            dsOrganizations.Tables[0].Columns.Remove("ID");
        }

        private static void AddIDColumn()
        {
            dsOrganizations.Tables[0].Columns.Add("ID", typeof(string), "agency + '_' + band");
        }

        public static DataSet GetDataSet()
        {
            if (dsOrganizations == null)
            {
                dsOrganizations = new DataSet();
                dsOrganizations.ReadXml("../../Data/nets.xml");
                AddIDColumn();
                
                dsOrganizations.Tables[0].PrimaryKey = new DataColumn[] { dsOrganizations.Tables[0].Columns["band"], dsOrganizations.Tables[0].Columns["agency"] };
                
            }
            return dsOrganizations;
        }

        public static void SaveDataSet()
        {
            dsOrganizations.Tables[0].Columns.Remove("ID");
            dsOrganizations.AcceptChanges();
            dsOrganizations.WriteXml("../../Data/nets.xml");
        }
    }
}
