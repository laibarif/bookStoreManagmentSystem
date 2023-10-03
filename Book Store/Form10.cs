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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            float price = float.Parse(textBox2.Text);
            float quantity = float.Parse(textBox3.Text);
            string path = "addbook.txt";
            Book book = new Book(name, price, quantity);
            BookDL.addBookintoFile(book,path);
            BookDL.addBookintoList(book);
            MessageBox.Show("BOOK ADDED!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}
