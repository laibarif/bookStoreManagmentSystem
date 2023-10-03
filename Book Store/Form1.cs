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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "credentials.txt";
            CredentialsDL.readDataFromFile(path);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "credentials.txt";
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role = textBox3.Text;
            Credentials user = new Credentials(name, password, role);
            CredentialsDL.addUserIntoList(user);
            CredentialsDL.storeUserintoFile(user, path);
            MessageBox.Show("User Added!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
