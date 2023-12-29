using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BlueWaveCookingClub
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False");
               
                con.Open();

                string sqlquery = "INSERT INTO tbl_BlueWave VALUES('" + txtFirstna.Text + "','" + txtLastna.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + cbGender.Text + "','" + txtPhone.Text + "','" + cbSubscription.Text + "','" + cbAge.Text + "','" + cbCooking.Text + "','" + cbPayment.Text + "', '" + cbExperience.Text + "')";

                SqlCommand com = new SqlCommand(sqlquery, con);
                com.ExecuteNonQuery();
                MessageBox.Show("dsfsdfsdcv");
            }
            catch(SqlException ex)
            {
               MessageBox.Show("Error: " + ex.Message);
            }
            
            
            
            
            }*/


            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    string sqlquery = "INSERT INTO tbl_BlueWave VALUES(@First_Name, @Last_Name, @Date_Of_Birth, @Gender, @Age, @Address, @Phone_Number, @Email, @NIC_Number, @Cooking_Clubs, @Payment_Method, @Payment, @Date_of_Reg)";
                    using (SqlCommand com = new SqlCommand(sqlquery, con))
                    {
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
                        MessageBox.Show("Data inserted successfully!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {

                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbl_BlueWave", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;







            }
        }
    }

}
