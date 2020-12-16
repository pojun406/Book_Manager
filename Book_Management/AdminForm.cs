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

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void AdminForm_Load(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) { }
        //클릭 시 도서관리 창 오픈
        private void btnBookM_Click(object sender, EventArgs e) { }
        //클릭시 대출자 관리 창 오픈
        private void btnUserCheck_Click(object sender, EventArgs e) { }

        //------------------------------------------------------------------------------------------------------------

        private void 출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                LoginForm loginForm = new LoginForm();
                this.Close();
                loginForm.Show();

            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

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

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btn_DelBook_Click(object sender, EventArgs e) // 도서 삭제 버튼
        {
            for( int i = 0; i < data_BookList.Rows.Count; i++)
            {
                if(data_BookList.Rows[i].Selected == true)
                {
                    data_BookList.Rows.Remove(data_BookList.Rows[i]);
                    string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
                    MySqlConnection Conn = new MySqlConnection(myConnection);
                    string refresh = "SELECT BOOK_NUM AS '도서 번호', BOOK_NAME AS '도서명', BOOK_GENRE AS '도서 장르', BOOK_WRITER AS '저자' FROM book_list";
                    string select_Row_NUM = data_BookList.CurrentRow.Cells["도서 번호"].Value.ToString();
                    string Delquery = "DELETE FROM book_list WHERE BOOK_NUM = '#NUM'";
                    Delquery = Delquery.Replace("#NUM", select_Row_NUM);
                    Conn.Open();
                    MySqlCommand cmd = new MySqlCommand(Delquery, Conn);
                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MySqlDataAdapter da = new MySqlDataAdapter(refresh, Conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "book_list");

                            data_UserManage.DataSource = ds;
                            data_UserManage.DataMember = "book_list";
                        }
                        else
                        {
                            MessageBox.Show("삭제 실패");
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    Conn.Close();

                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btn_searchbooklist_Click(object sender, EventArgs e) // 도서 목록 datagrid에 출력 (도서 조회)
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "SELECT BOOK_NUM AS '도서 번호', BOOK_NAME AS '도서 명', BOOK_GENRE AS '도서 장르', BOOK_WRITER AS '저자' FROM book_list";

            Conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, Conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "book_list");

            data_BookList.DataSource = ds;
            data_BookList.DataMember = "book_list";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnMake_Click(object sender, EventArgs e) // 유저 회원가입버튼
        {

            if (txt_Name.Text == "" && txt_Tel.Text == "")
            {
                MessageBox.Show("빈칸은 못넣습니다.");
                return;
            }

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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            Conn.Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btn_SearchUser_Click(object sender, EventArgs e) // 유저 목록 datagrid에 출력 (유저 조회)
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

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btn_searchrentallist_Click(object sender, EventArgs e) // 대출 목록 datagrid에 출력 (대출 조회)
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            string query = "SELECT R.RENT_NUM AS '대출 번호', L.BOOK_NUM AS '도서 번호', L.BOOK_NAME AS '도서 이름', R.USER_NUM AS '유저 번호', U.USER_NAME AS '유저 이름', IF(L.BOOK_T_F, '대여 가능', '대여 불가능') AS '대출 유무', R.RENT_DATE AS '대여일', R.RETURN_DATE AS '반납일'"/*별칭 설정완료*/
                + " FROM book_list L, book_rent R, user U "
                + "WHERE L.BOOK_NUM = R.BOOK_NUM AND R.USER_NUM  = U.USER_NUM";

            string rent_Table = "book_list L, book_rent R, user U";
            Conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, Conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, rent_Table);

            data_Rent.DataSource = ds;
            data_Rent.DataMember = rent_Table;


            Conn.Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btn_Return_Click(object sender, EventArgs e) // 대출 반납처리 -- 안됌
        {
            for (int i = 0; i < data_BookList.Rows.Count - 1; i++)
            {
                if (data_BookList.Rows[i].Selected == true)
                {
                    data_BookList.Rows.Remove(data_BookList.Rows[i]);
                    string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
                    MySqlConnection Conn = new MySqlConnection(myConnection);
                    string refresh = "SELECT R.RENT_NUM AS '대출 번호', L.BOOK_NUM AS '도서 번호', L.BOOK_NAME AS '도서 이름', R.USER_NUM AS '유저 번호', U.USER_NAME AS '유저 이름', IF(L.BOOK_T_F, '대여 가능', '대여 불가능') AS '대출 유무', R.RENT_DATE AS '대여일', R.RETURN_DATE AS '반납일'"/*별칭 설정완료*/
                + " FROM book_list L, book_rent R, user U "
                + "WHERE L.BOOK_NUM = R.BOOK_NUM AND R.USER_NUM  = U.USER_NUM";
                    string select_Row_NUM = data_BookList.CurrentRow.Cells["대출 유무"].Value.ToString();
                    string Delquery = "UPDATE book_list SET BOOK_T_F = '1' WHERE " + select_Row_NUM;
                    string rent_Table = "book_list L, book_rent R, user U";
                    Conn.Open();
                    MySqlCommand cmd = new MySqlCommand(Delquery, Conn);
                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MySqlDataAdapter da = new MySqlDataAdapter(refresh, Conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds, rent_Table);

                            data_UserManage.DataSource = ds;
                            data_UserManage.DataMember = rent_Table;
                        }
                        else
                        {
                            MessageBox.Show("반납 실패");
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    Conn.Close();

                }
            }
        }
        

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        /*private void btn_Search_Click(object sender, EventArgs e) // 도서 대출 조회 (안돼는 코드)
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
        }*/

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
