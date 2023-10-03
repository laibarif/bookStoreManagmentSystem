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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            float bookbuy = float.Parse(textBox2.Text);
            float bill = float.Parse(textBox3.Text);
            string path = "customer.txt";
            Customer customer = new Customer(name, bookbuy, bill);
            CustomerDL.addCustomerintoFile(customer, path);
            CustomerDL.addCustomerintoList(customer);
            MessageBox.Show("BOOK ADDED!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
