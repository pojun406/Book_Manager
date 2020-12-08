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
            string myConnection = "Server=localhost; port = 3307; Database=book_management;User ID=root;Password=123123;CHARSET=utf8";
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "select * from user where USER_NAME = '" + txt_ID.Text.Trim() + "' and USER_P_NUM = '" + txt_PW.Text.Trim() + "'";
            MySqlDataAdapter adpt = new MySqlDataAdapter(query, Conn);
            DataTable dt = new DataTable();
            Conn.Open();
            adpt.Fill(dt);
            if (txt_ID.Text == "admin" && txt_PW.Text == "1234")
            {
                MessageBox.Show("관리자 계정으로 접속합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm adminForm = new AdminForm();
                LoginForm loginForm = new LoginForm();
                adminForm.Show();
                loginForm.Close();
            }
            else
            {
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("로그인합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserForm userForm = new UserForm();
                    LoginForm loginForm = new LoginForm();
                    userForm.Show();
                    loginForm.Close();
                }
                else
                {
                    MessageBox.Show("ID와 패스워드를 확인해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Conn.Close();
        }

    }
}
