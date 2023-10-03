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
    public partial class Form13 : Form
    {
        private string path = "addbook.txt";
        public Form13()
        {
            InitializeComponent();
            
        }

        public void dataBind()
        {
            
            usersGV.DataSource = null;
            usersGV.DataSource = BookDL.Books;
            usersGV.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BookDL.Books.Clear();
            BookDL.readBook(path);
            usersGV.DataSource = BookDL.Books; // introspection
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book user = (Book)usersGV.CurrentRow.DataBoundItem;
            if (usersGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                BookDL.deleteUserFromList(user);
                BookDL.storeAllDataIntoFile(path);
                dataBind();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // we can add menu strips as well

        // Modal Form
    }
}
