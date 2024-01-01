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
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
            {
                con.Open();
                string sqselect = "select * from "
                SqlCommand sqlcmd = new SqlCommand("")

            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False");

                con.Open();

                string sqlquery = "INSERT INTO tbl_BlueWave VALUES(FirstName, LastName, Email, Address, Gender, Phone, Age, CookingInterest, PaymentMethod) " +
                                  "VALUES (@FirstName, @LastName, @Email, @Address, @Gender, @Phone, @Age, @CookingInterest, @PaymentMethod)";


                SqlCommand com = new SqlCommand(sqlquery, con);
                com.Parameters.AddWithValue("@Registration_No", txtRegno.Text);
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





                com.ExecuteNonQuery();



                MessageBox.Show("Submitted sucessfully !");

                ;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
    }
}
}
    




