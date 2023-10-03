using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store.BL;
using Book_Store.DL;

namespace Book_Store
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            BookDL.sorting();
            BookDL.Books.Clear();
            string path = "addbook.txt";
            BookDL.readBook(path);
            dataGridView1.DataSource = BookDL.SortedList1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BookDL.SortedList1;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}
