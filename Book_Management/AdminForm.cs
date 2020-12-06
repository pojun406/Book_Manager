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
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
        }
        //클릭시 대출자 관리 창 오픈
        private void btnUserCheck_Click(object sender, EventArgs e)
        {
            RentalUserList rentalUserList = new RentalUserList();
            rentalUserList.Show();
        }
    }
}
