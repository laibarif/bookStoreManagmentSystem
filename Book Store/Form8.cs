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

namespace Book_Store
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string path = "customerBook.txt";
            string name = textBox1.Text;
            for (int i = 0; i < CustomerBookDL.customerBook.Count; i++)
            {
                textBox1.Text = CustomerBookDL.customerBook[i].BookName;
                if (name == CustomerBookDL.customerBook[i].BookName)
                {
                    MessageBox.Show("Record Found!");
                    Form7 f7 = new Form7();
                    f7.Show();
                    this.Hide();
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Record Not Found!");
            }
            clearTextBox();
        }

        private void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            string path = "customerBook.txt";
            CustomerBookDL.readCustomerBook(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
