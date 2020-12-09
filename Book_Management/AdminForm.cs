﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramForm
{
    public partial class AdminForm : Form
    {
        private ListBox listBox1;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //클릭 시 도서관리 창 오픈
        private void btnBookM_Click(object sender, EventArgs e)
        {
            
        }
        //클릭시 대출자 관리 창 오픈
        private void btnUserCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "INSERT INTO user (USER_NUM, USER_NAME, USER_P_NUM) value(USER_NUM + 1, '" + txt_Name.Text.Trim() + "' , '" + txt_Tel.Text.Trim() + "');";

            Conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            try
            {
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("값 들어감");
                }
                else
                {
                    MessageBox.Show("값 들어가기 실패");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            Conn.Close();
        }

        private void data_UserManage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_BookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                LoginForm loginForm = new LoginForm();
                this.Close();
                loginForm.Show();

            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
