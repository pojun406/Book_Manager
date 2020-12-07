using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProgramForm;

namespace Book_Management
{
    class Data_Base
    {
        public static SqlConnection conn = new SqlConnection(); // 접속시켜주는 코드
        string strConn = "Server=127.0.0.1;Port=3307;Database=book_management;Uid=root;Pwd=123123;"; // DB정보

        public void ConnectDB()
        {
            conn.ConnectionString = strConn;
            conn = new SqlConnection(conn.ConnectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);
            conn.Open();
            DataSet ds = new DataSet();
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

            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, conn);

            myAdapter.Fill(ds);
            conn.Close();

            return ds;
        }

    }
}
