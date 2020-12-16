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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
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

        private void btn_Search_Click(object sender, EventArgs e) // 조회(도서 검색 조회)
        {
            string myConnection = "Server=localhost; port = 3307; Database=book_management; User ID=root;Password=123123;CHARSET=utf8"; // DB정보
            MySqlConnection Conn = new MySqlConnection(myConnection);
            Conn.Open();

            string category = cbox_Category.SelectedItem.ToString();
            string query = "";

            if(txt_search.Text == "")
            {
                MessageBox.Show("입력해주세요");
                return;
            }

            if(category == "전체")
            {
                query = "SELECT BOOK_NAME AS '도서 명', BOOK_GENRE AS '도서 장르', BOOK_WRITER AS '저자', IF(BOOK_T_F, '대여 가능', '대여 불가능') AS '대출 유무' FROM book_list " +
                        "WHERE (BOOK_NAME LIKE '%" + txt_search.Text.Trim() + "%' OR BOOK_GENRE LIKE '%" + txt_search.Text.Trim() + "%' OR BOOK_WRITER LIKE '%" + txt_search.Text.Trim() + "%');";
            }
            else if(category == "도서명")
            {
                query = "SELECT BOOK_NAME AS '도서 명', BOOK_GENRE AS '도서 장르', BOOK_WRITER AS '저자', IF(BOOK_T_F, '대여 가능', '대여 불가능') AS '대출 유무' FROM book_list " +
                        "WHERE BOOK_NAME LIKE '%" + txt_search.Text.Trim() + "%';";
            }
            else if(category == "장르")
            {
                query = "SELECT BOOK_NAME AS '도서 명', BOOK_GENRE AS '도서 장르', BOOK_WRITER AS '저자', IF(BOOK_T_F, '대여 가능', '대여 불가능') AS '대출 유무' FROM book_list " +
                        "WHERE BOOK_GENRE LIKE '%" + txt_search.Text.Trim() + "%';";
            }
            else if(category == "저자")
            {
                query = "SELECT BOOK_NAME AS '도서 명', BOOK_GENRE AS '도서 장르', BOOK_WRITER AS '저자', IF(BOOK_T_F, '대여 가능', '대여 불가능') AS '대출 유무' FROM book_list " +
                        "WHERE BOOK_WRITER LIKE '%" + txt_search.Text.Trim() + "%';";
            }
            else
            {
                MessageBox.Show("안들어가짐");
            }
            MySqlDataAdapter da = new MySqlDataAdapter(query, Conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "book_list");

            data_booklist.DataSource = ds;
            data_booklist.DataMember = "book_list";
        }

        private void btn_Rental_Click(object sender, EventArgs e) // 반납처리(반납) -- 구현 안됌
        {

        }

        private void cbox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            cbox_Category.Items.Add("전체");
            cbox_Category.Items.Add("도서명");
            cbox_Category.Items.Add("장르");
            cbox_Category.Items.Add("저자");
            cbox_Category.SelectedIndex = 0;
        }

    }
}
