using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetHAMContactInfo
{
    class configurationController
    {
       private static DataSet dsConfiguration = null;

        private configurationController()
        {
        }

        public static DataSet GetDataSet()
        {
            if (dsConfiguration == null)
            {
                dsConfiguration = new DataSet();
                dsConfiguration.ReadXml("../../Data/config.xml");
            }
            return dsConfiguration;
        }           

        public static void SaveDataSet()
        {
            dsConfiguration.WriteXml("../../Data/config.xml");
        }
    }
}
