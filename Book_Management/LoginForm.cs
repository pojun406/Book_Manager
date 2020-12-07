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

namespace ProgramForm
{
    public partial class LoginForm : Form
    {
        public static string username;
        Data_Base DB = new Data_Base();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            DB.ConnectDB();
            MessageBox.Show("연결완료");

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
