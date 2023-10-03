using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store.DL;
using Book_Store.BL;
using System.Windows.Forms;

namespace Book_Store
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string name = textBox1.Text;
            for (int i = 0; i < BookDL.Books.Count; i++)
            {
                if (name == BookDL.Books[i].Name)
                {
                    MessageBox.Show("RECORD FOUND!!");
                    MessageBox.Show("Name\t\tPrice\t\tQuantity"+"\n"+BookDL.Books[i].Name + "\t\t" + BookDL.Books[i].Price + "\t\t" + BookDL.Books[i].Quantity);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Not Available!");
            }
            textBox1.Text = " ";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            string pathBook = "addbook.txt";
            BookDL.readBook(pathBook);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}
