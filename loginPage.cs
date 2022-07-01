using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            loginPage form1 = new loginPage();
            form1.Close();
            if (string.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
                return;
            }
            try { } catch (Exception ex) {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            if(string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
            }
            try { } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string email = username.Text;
            string pass = password.Text;
            /*MySqlConnection conn = new MySqlConnection();*/


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();

        }
    }
}
