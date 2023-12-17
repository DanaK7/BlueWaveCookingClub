using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueWaveCookingClub
{
    public partial class FrmLogin : Form
    {

        //Admin and member passwords
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";
        private const string MemberUsername = "member";
        private const string MemberPassword = "member123";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.ToLower() == AdminUsername && password == AdminPassword)
            {
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenAdminPanel();
            }
            else if (username.ToLower() == MemberUsername && password == MemberPassword)
            {
                MessageBox.Show("Member login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenRegistrationForm();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void rbtnShow_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click event for the registration link label
            OpenRegistrationForm();
        }
    }
}
