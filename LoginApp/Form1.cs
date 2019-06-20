using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] user = { "Yunus" };
        string[] password = { "1123", "123" };


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < user.Length; i++)
                {
                    if (txtUserName.Text == user[i] && txtPassword.Text == password[i])
                    {
                        MessageBox.Show("Welcome Major...!");
                        Form2 frm = new Form2();
                        frm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("You are under the age 18");
                
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '*';
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;

            DialogResult dr = MessageBox.Show("Do you member or not", "Hi..!", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        public void AddUserNamePassword(string username, string passWord)
        {
            Array.Resize(ref user, user.Length + 1);
            user[user.Length - 1] = username;
            Array.Resize(ref password, password.Length + 1);
            password[password.Length - 1] = passWord;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pass = txtPassword.Text;

            AddUserNamePassword(name, pass);
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < user.Length; i++)
            {
                if (textBox1.Text == user[i])
                {
                    MessageBox.Show("Hatalı");
                }
            }
        }
    }
}
