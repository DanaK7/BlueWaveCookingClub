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

           using(SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {
                connection1.Open();

                string queryMale = "SELECT COUNT(*) AS MaleMemberCount FROM tbl_BlueWave WHERE Gender = 'Male'";
                string queryFemale = "SELECT COUNT(*) AS MaleMemberCount FROM tbl_BlueWave WHERE Gender = 'Female'";

                int maleCount = 0;
                int femaleCount = 0;

                using (SqlCommand commandMale = new SqlCommand(queryMale, connection1))
                {
                    maleCount = (int)commandMale.ExecuteScalar();
                }

                using (SqlCommand commandFemale = new SqlCommand(queryFemale, connection1))
                {
                    femaleCount = (int)commandFemale.ExecuteScalar();
                }

                int totalMembers = maleCount + femaleCount;

                lblMale.Text = $"Male: {maleCount}";

                lblFemale.Text =$"Female: {femaleCount}";







            }

            using (SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {
                connection1.Open();

                string queryCuisine = "SELECT COUNT(*) AS CuisineCount FROM tbl_BlueWave WHERE Gender = 'Cuisine'";
                string queryDessert = "SELECT COUNT(*) AS DessertCount FROM tbl_BlueWave WHERE Gender = 'Dessert'";
                string queryBakery = "SELECT COUNT(*) AS BakeryCount FROM tbl_BlueWave WHERE Gender = 'Bakery'";

                int CuisineCount = 0;
                int DessertCount = 0;
                int BakeryCount = 0;


                using (SqlCommand commandcuisine = new SqlCommand(queryCuisine, connection1))
                {
                    CuisineCount = (int)commandcuisine.ExecuteScalar();
                }

                using (SqlCommand commanddessert = new SqlCommand(queryDessert, connection1))
                {
                    DessertCount = (int)commanddessert.ExecuteScalar();
                }

                using (SqlCommand commandbakery = new SqlCommand(queryBakery, connection1))
                {
                    BakeryCount = (int)commandbakery.ExecuteScalar();
                }



                lblCuisine.Text = $"Cuisine: {CuisineCount}";
                lblDessert.Text =$"Dessert:{DessertCount}";
                lblBakery.Text = $"Bakery:{BakeryCount}";

            }

            using (SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {
                connection1.Open();

                string querypaid = "SELECT COUNT(*) AS PaidCount FROM tbl_BlueWave WHERE Payment_Method = 'Paid'";
                string querypaynow = "SELECT COUNT(*) AS paynowCount FROM tbl_BlueWave WHERE Payment_Method = 'Pay Now'";
                string querypaylater = "SELECT COUNT(*) AS paylaterCount FROM tbl_BlueWave WHERE Payment_Method = 'Pay Later'";

                int paidCount = 0;
                int paynowCount = 0;
                int paylaterCount = 0;


                using (SqlCommand commandpaid = new SqlCommand(querypaid, connection1))
                {
                    paidCount = (int)commandpaid.ExecuteScalar();
                }

                using (SqlCommand commandpaynow = new SqlCommand(querypaynow, connection1))
                {
                    paynowCount = (int)commandpaynow.ExecuteScalar();
                }

                using (SqlCommand commandpaylater = new SqlCommand(querypaylater, connection1))
                {
                    paylaterCount = (int)commandpaylater.ExecuteScalar();
                }



                lblPaid.Text = $"Paid: {paidCount}";
                lblPayNow.Text = $"Pay now :{paynowCount}";
                lblPayLater.Text = $"Pay Later:{paylaterCount}";

            }

















        }
    }
}
    




