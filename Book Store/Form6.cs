using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store.DL;
using Book_Store.BL;

namespace Book_Store
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string path = "customerBook.txt";
            string name = textBox1.Text;
            float Quantity = float.Parse(textBox2.Text);
            CustomerBook cBook = new CustomerBook(name, Quantity);
            for (int i = 0; i < BookDL.Books.Count; i++)
            {
                if (name == BookDL.Books[i].Name)
                {
                    CustomerBookDL.addCustomerBookIntoList(cBook);
                    CustomerBookDL.storeCustomerBookintoFile(cBook, path);
                    Form7 f7 = new Form7();
                    f7.Show();
                    this.Hide();
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                MessageBox.Show("Not Available!");
            }
            clearTextBox();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string path = "customerBook.txt";
            string pathBook = "addbook.txt";
            CustomerBookDL.readCustomerBook(path);
            BookDL.readBook(pathBook);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
