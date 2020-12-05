using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management
{
    class DataBase
    {
        public static SqlConnection conn = new SqlConnection();
    }
}
