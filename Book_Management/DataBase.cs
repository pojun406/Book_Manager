using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Book_Management
{
    class Data_Base
    {
        public SqlConnection conn = new SqlConnection();
        string strConn = "Server=127.0.0.1;Port=3307;Database=book_management;Uid=root;Pwd=123123;";

        public void ConnectDB()
        {
            conn.ConnectionString = strConn;
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open(); 
        }

        public void CloseDB()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }


        public DataSet GetBookList()
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sql = "SELECT * FROM book_list ORDER BY BOOK_NUM DESC;";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds);
            conn.Close();

            return ds;
        }

    }
}
