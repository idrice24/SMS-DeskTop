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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPage form1 = new loginPage();
            form1.Show();
            RegisterUser register = new RegisterUser();
            register.Close();

        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string pass = txtPaasword.Text;
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string confPassword = txtConfPassword.Text;
            string email = txtEmail.Text;
            

            if (string.IsNullOrEmpty("txtEmail"))
            {
                MessageBox.Show("Please enter the email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty("txtLastName"))
            {
                MessageBox.Show("Please enter your Last Name ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastname.Focus();
                return;
            }
            if (string.IsNullOrEmpty("txtFirstname"))
            {
                MessageBox.Show("Please enter your First Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstname.Focus();
            }
            if (string.IsNullOrEmpty("txtPaasword"))
            {
                MessageBox.Show("Please enter your password..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaasword.Focus();
                return;
            }
            if (string.IsNullOrEmpty("txtConfPassword"))
            {
                MessageBox.Show("Please enter the confirm password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfPassword.Focus();
                return;
            }if(txtConfPassword == txtPaasword)
            {
                MessageBox.Show("Your Password does not match, please re-enter it!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaasword.Focus();
                txtConfPassword.Focus();
                return;
            }
            try { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
