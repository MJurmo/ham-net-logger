using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    class RadiogramsController
    {
       private static DataSet dsRadiograms = null;

        private RadiogramsController()
        {
        }

        public static bool FindID(string ID, ref bool duplicate)
        {
            var Results = GetDataSet().Tables[0].AsEnumerable().Count(row => ID == row.Field<string>("ID"));

            bool retVal = true;
            int numrecs = Results;
            if (numrecs == 0)
            {
                retVal = false;
            }
            if (numrecs > 1)
            {
                duplicate = true;
            }
            return retVal;
        }

        public static DataSet GetDataSet()
        {
            if (dsRadiograms == null)
            {
                dsRadiograms = new DataSet();
                dsRadiograms.ReadXml("../../Data/radiograms.xml");
            }
            return dsRadiograms;
        }

        public static void SaveDataSet()
        {
            dsRadiograms.WriteXml("../../Data/radiograms.xml");
        }
    }
}
