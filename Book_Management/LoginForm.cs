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
            //bool login = false;
            string myConnection = "Server=localhost; port = 3307; Database=book_management;User ID=root;Password=123123;CHARSET=utf8";
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "select * from user where USER_NAME = '" + txt_ID.Text.Trim() + "' and USER_P_NUM = '" + txt_PW.Text.Trim() + "'";
            MySqlDataAdapter adpt = new MySqlDataAdapter(query,Conn);
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                MessageBox.Show("실패");
            }
            
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM book_management.user WHERE USER_NAME='" + txt_ID.Text + "' and USER_P_NUM = '" + txt_PW.Text + "'", Conn);
            try
            {

                /*
                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = new MySqlCommand("select + database.book_management;", Conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(Da);
                Conn.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("연결완료");
                
                MySqlDataReader myReader;
                Conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    if(txt_ID.Text == "admin" && txt_PW.Text == "1234")
                    {
                        MessageBox.Show("관리자 계정으로 접속합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminForm adminForm = new AdminForm();
                        LoginForm loginForm = new LoginForm();
                        adminForm.Show();
                        loginForm.Close();
                    }
                    else
                    {
                        if (myReader["USER_NAME"].ToString() == txt_ID.Text)
                        {
                            if(myReader["USER_P_NUM"].ToString() == txt_PW.Text)
                            {
                                UserForm userForm = new UserForm();
                                LoginForm loginForm = new LoginForm();
                                userForm.Show();
                                loginForm.Close();
                            }
                            else
                            {
                                MessageBox.Show("비번틀림");
                            }
                        }
                        else
                        {
                            MessageBox.Show("아이디 틀림");
                        }
                    }
                }
                
                myReader.Close();
                */
                /*
                if(login)
                {
                    MessageBox.Show("로그인 성공");
                }
                else
                {
                    MessageBox.Show("아이디/암호 확인하세요");
                }
                */
                Conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            if (txt_login.Text == "admin" && txt_pw.Text == "1234")
            {
                MessageBox.Show("관리자 계정으로 접속합니다.", "알림" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm adminForm = new AdminForm();
                LoginForm loginForm = new LoginForm();
                adminForm.Show();
                loginForm.Close();
                
            }

            else if (txt_login.Text == "이동욱" && txt_pw.Text == "01045490569")
            {
                MessageBox.Show("로그인합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserForm userForm = new UserForm();
                LoginForm loginForm = new LoginForm();
                userForm.Show();
                loginForm.Close();
            }

            else if (txt_login.Text == "" | txt_pw.Text == "")
            {
                MessageBox.Show("ID와 패스워드를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("ID와 패스워드를 확인해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
