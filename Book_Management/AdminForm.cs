using System;
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

        private void btnMake_Click(object sender, EventArgs e) // 유저 회원가입버튼
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string refresh = "SELECT USER_NUM AS '유저 번호', USER_NAME AS '유저명', USER_P_NUM AS '핸드폰 번호' FROM user";
            string query = "INSERT INTO user (USER_NUM, USER_NAME, USER_P_NUM) value(USER_NUM, '" + txt_Name.Text.Trim() + "' , '" + txt_Tel.Text.Trim() + "');";
            Conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, Conn);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(refresh, Conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "user");

                    data_UserManage.DataSource = ds;
                    data_UserManage.DataMember = "user";

                    MessageBox.Show("유저 아이디 : " + txt_Name.Text + "   유저 핸드폰번호 : " + txt_Tel.Text);
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

        private void btn_AddBook_Click(object sender, EventArgs e) // 도서 추가 버튼
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "INSERT INTO book_list (BOOK_NUM, BOOK_NAME, BOOK_GENRE, BOOK_WRITER) value('" + txt_booknum.Text.Trim() + "', '" + txt_bookname.Text.Trim() + "' , '" + txt_genre.Text.Trim() + "' , '" + txt_writer.Text.Trim() + "');";
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    
                    MessageBox.Show("도서 번호 : " + txt_booknum.Text + "\r 도서 제목 : " + txt_bookname.Text + "\r 도서 장르 : " + txt_genre.Text + "\r 도서 저자 : " + txt_writer.Text);
                }
                else
                {
                    MessageBox.Show("값 들어가기 실패");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            Conn.Close();
        }

        private void btn_DelBook_Click(object sender, EventArgs e) // 도서 삭제 버튼
        {

        }

        private void btn_Search_Click(object sender, EventArgs e) // 도서 대출 조회
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "SELECT L.BOOK_NUM, L.BOOK_NAME,R.RENT_NUM, R.RENT_DATE, R.RETURN_DATE,R.USER_NUM , U.USER_NAME, L.BOOK_T_F" +
                "FROM book_list L, book_rent R, user U" +
                "WHERE L.BOOK_NUM = R.BOOK_NUM AND R.USER_NUM = U.USER_NUM;";
            string rent_Table = "book_list L, book_rent R, user U";
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, Conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            data_Rent.DataSource = ds;
            data_Rent.DataMember = rent_Table;
            Conn.Close();
        }

        private void btn_SearchUser_Click(object sender, EventArgs e) // 유저 목록 datagrid에 출력
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "SELECT USER_NUM AS '유저 번호', USER_NAME AS '유저명', USER_P_NUM AS '핸드폰 번호' FROM user";

            Conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, Conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "user");

            data_UserManage.DataSource = ds;
            data_UserManage.DataMember = "user";
        }

        private void btn_searchbooklist_Click(object sender, EventArgs e)
        {

        }

        private void btn_searchrentallist_Click(object sender, EventArgs e)
        {

        }
    }
}
