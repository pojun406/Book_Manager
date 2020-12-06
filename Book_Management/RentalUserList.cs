using Book_Management;
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
    public partial class RentalUserList : Form
    {
        public RentalUserList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data_Base database = new Data_Base();
            DataSet dataset = database.GetBookList();

            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}
