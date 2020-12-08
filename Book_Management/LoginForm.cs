using Book_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramForm
{
    public partial class LoginForm : Form
    {
        public static string username;
        public LoginForm()
        {
            InitializeComponent();
        }


        private void Button_Login_Click(object sender, EventArgs e)
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management;User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "select * from user where USER_NAME = '" + txt_ID.Text.Trim() + "' and USER_P_NUM = '" + txt_PW.Text.Trim() + "'";
            MySqlDataAdapter adpt = new MySqlDataAdapter(query, Conn); // adapter로 쿼리 넘김
            DataTable dt = new DataTable(); // dataTable 선언
            Conn.Open();
            adpt.Fill(dt);
                if (dt.Rows.Count == 1) // 연결된 개수가 1개라면 실행 ( 로그인 성공시 1개 실패시 0개 )
                {
                    if(txt_ID.Text == "admin")
                    {
                        MessageBox.Show("관리자 계정으로 접속합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminForm adminForm = new AdminForm();
                        LoginForm loginForm = new LoginForm();
                        adminForm.Show();
                        loginForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("로그인합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserForm userForm = new UserForm();
                        LoginForm loginForm = new LoginForm();
                        userForm.Show();
                        loginForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ID와 패스워드를 확인해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            Conn.Close();
        }

    }
}
