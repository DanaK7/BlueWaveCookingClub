using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueWaveCookingClub
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
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
           


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
    }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Open Login Form
            FrmLogin loginForm = new FrmLogin();

            // Close the current form
            this.Close();

            // Show the login form
            loginForm.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            // Open Admin Panel Form
            FrmAdminPanel AdminPanelForm = new FrmAdminPanel();

            // Close the current form
            this.Close();

            // Show the Admin Panel Form
            AdminPanelForm.Show();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) AS TotalMemberCount FROM tbl_BlueWave";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int membercount = (int)command.ExecuteScalar();
                    label1.Text = membercount.ToString();

                }

            }
       
        
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
    




