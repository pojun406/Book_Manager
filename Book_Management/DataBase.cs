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
        public static DataSet ds = new DataSet();
        public static DataTable dt_book;
        public static DataTable dt_user;

        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=127.0.0.1,3307;Initial Catalog=book_management;User ID=root;Password=123123;");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }

        public static void 
    }
}
