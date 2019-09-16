using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ADUserTransfer
{
    public class UserDataTable:DataTable
    {
        public UserDataTable()
        {
            this.Columns.Add(new DataColumn("CommonName", typeof(string)));
            this.Columns.Add(new DataColumn("ResultDetail", typeof(string)));
        }
    }
}
