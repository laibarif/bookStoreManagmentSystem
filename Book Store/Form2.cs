using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store.BL;
using Book_Store.DL;
using System.Windows.Forms;

namespace Book_Store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            Credentials user = new Credentials(userName, password);
            Credentials validUser = CredentialsDL.SignIn(user);
            if (validUser != null)
            {
                string role = validUser.role();
                if (role == "Admin")
                {
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else if(role == "Customer")
                {
                    Form4 f4 = new Form4();
                    f4.Show();
                    this.Hide();
                }
                else if(role == "Seller")
                {

                }
            }
            else
            {
                MessageBox.Show("InValid");
            }
            clearTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
