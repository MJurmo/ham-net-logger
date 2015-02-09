using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GetHAMContactInfo
{
    class SelectedAssociates
    {
        private static DataTable m_associates = null;
        public static DataTable getTable()
        {
            if(m_associates==null)
            {
                m_associates = new DataTable();
                foreach (DataColumn col in AssociatesController.GetDataSet().Tables[0].Columns)
                {
                    DataColumn col1 = new DataColumn();
                    col1.ColumnName = col.ColumnName;
                    col1.DataType = col.DataType;
                    getTable().Columns.Add(col1);
                }
            }
            return m_associates;
        }
    }
}
