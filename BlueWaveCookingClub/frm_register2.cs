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
    public partial class FrmRegister2 : Form
    {
        public FrmRegister2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            {
                // Create a new instance of FrmRegister1 (registration form 1)
                FrmRegister1 registrationForm1 = new FrmRegister1();

                // Show FrmRegister1
                registrationForm1.Show();

                // Hide the current form (FrmRegister2 )
                this.Hide();
            }

        }

        private void btnDisplayall_Click(object sender, EventArgs e)
        {
            // Create instances of FrmRegister1 and FrmRegister2
            FrmRegister1 registrationForm1 = new FrmRegister1();
            FrmRegister2 registrationForm2 = new FrmRegister2();

            // Assuming you have methods like GetData() in both forms to retrieve data
            // Replace GetData() with the actual method names you have in your forms
            string dataFromForm1 = registrationForm1.GetData();
            string dataFromForm2 = registrationForm2.GetData();

            // Display the data 
            MessageBox.Show($"Data from Form 1: {dataFromForm1}\nData from Form 2: {dataFromForm2}");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Assuming FrmLogin is the name of your login form
            FrmLogin loginForm = new FrmLogin();

            // Close the current form
            this.Close();

            // Show the login form
            loginForm.Show();
        }
    }
}
