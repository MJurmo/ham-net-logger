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

        public static DataSet GetDataSet()
        {
            if (dsOrganizations == null)
            {
                dsOrganizations = new DataSet();
                dsOrganizations.ReadXml("../../Data/nets.xml");
                dsOrganizations.Tables[0].Columns.Add("ID", typeof (string), "agency + '_' + band");
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
