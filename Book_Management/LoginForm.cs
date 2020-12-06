using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForm
{
    public partial class LoginForm : Form
    {
        public static String username;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            

            if (txt_login.Text == "admin" && txt_pw.Text == "1234")
            {
                MessageBox.Show("관리자 계정으로 접속합니다.", "알림" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm adminForm = new AdminForm();
                adminForm.Show();

            }

            else if (txt_login.Text == "이동욱" && txt_pw.Text == "01045490569")
            {
                MessageBox.Show("로그인합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserForm userForm = new UserForm();
                userForm.Show();
            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
