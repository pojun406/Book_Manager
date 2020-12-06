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
            conn.ConnectionString = "Server=127.0.0.1;Port=3307;Database=book_management;Uid=root;Pwd=123123;";
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }


    }
}
