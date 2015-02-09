using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    class AssociatesController
    {
       private static DataSet dsAssociates = null;

        private AssociatesController()
        {
        }

        public static DataSet GetDataSet()
        {
            if (dsAssociates == null)
            {
                dsAssociates = new DataSet();
                dsAssociates.ReadXml("../../Data/associates.xml");
            }
            dsAssociates.Tables[0].PrimaryKey = new DataColumn[] {dsAssociates.Tables[0].Columns["ID"]};
            return dsAssociates;
        }           

        public static void SaveDataSet()
        {
            dsAssociates.WriteXml("../../Data/associates.xml");
        }
    }
}
