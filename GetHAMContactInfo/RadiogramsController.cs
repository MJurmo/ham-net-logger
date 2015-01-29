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
