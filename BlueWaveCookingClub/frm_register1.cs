using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlueWaveCookingClub
{
    public partial class FrmRegister1 : Form
    {
        public FrmRegister1()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection to the SQL Server using SqlConnection
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False");
                con.Open();

                // SQL query to insert data into the 'tbl_BlueWave' table
                string sqlquery = "INSERT INTO tbl_BlueWave VALUES(@First_Name, @Last_Name, @Date_Of_Birth, @Gender, @Age, @Address, @Phone_Number, @Email, @NIC_Number, @Cooking_Clubs, @Payment_Method, @Payment, @Date_of_Reg )";

                //SqlCommand with parameters to avoid SQL injection
                using (SqlCommand com = new SqlCommand(sqlquery, con))
                {
                 //Parameter values based on user input from textboxes and combo boxes
                    com.Parameters.AddWithValue("@First_Name", txtFirstna.Text);
                    com.Parameters.AddWithValue("@Last_Name", txtLastna.Text);
                    com.Parameters.AddWithValue("@Date_Of_Birth", dateOfBirth.Text);
                    com.Parameters.AddWithValue("@Gender", cbGender.Text);
                    com.Parameters.AddWithValue("@Age", cbAge.Text);
                    com.Parameters.AddWithValue("@Address", txtAddress.Text);

                    com.Parameters.AddWithValue("@Phone_Number", txtPhone.Text);
                    com.Parameters.AddWithValue("@Email", txtEmail.Text);
                    com.Parameters.AddWithValue("@NIC_Number", txtNIC.Text);

                    com.Parameters.AddWithValue("@Cooking_Clubs", cbCooking.Text);

                    com.Parameters.AddWithValue("@Payment_Method", cbPayM.Text);
                    com.Parameters.AddWithValue("@Payment", cbPayment.Text);
                    com.Parameters.AddWithValue("@Date_of_Reg", dateOfReg.Text);




                    //SQL command to insert data into the database
                    com.ExecuteNonQuery();
                    MessageBox.Show("Submitted sucessfully !");
                    ;
                }
            }
            catch (SqlException ex)
            {
                // Display a success message to the user
                MessageBox.Show("Error: " + ex.Message);
            }




        }

        private void FrmRegister1_Load(object sender, EventArgs e)
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
    }
}

