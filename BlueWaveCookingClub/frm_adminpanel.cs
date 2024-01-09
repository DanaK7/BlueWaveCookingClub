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
        private int _Registration_No;
        public int Registration_No
        {
            get => _Registration_No;
            set => _Registration_No = value;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False");

                con.Open();

                string sqlquery = "INSERT INTO tbl_BlueWave VALUES('" + txtFirstna.Text + "','" + txtLastna.Text + "','" + dateOfBirth.Text + "','" + cbGender.Text + "','" + cbAge.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtNIC.Text + "','" + cbCooking.Text + "','" + cbPayM.Text + "','" + cbPayment.Text + "','" + dateOfReg.Text + "')";

                SqlCommand com = new SqlCommand(sqlquery, con);
                com.ExecuteNonQuery();

               

                MessageBox.Show("Data Inserted sucessfully !");

               ;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




        }


        /* using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
         {
             try
             {
                 con.Open();
                 string sqlquery =  "INSERT INTO tbl_BlueWave VALUES(@First_Name, @Last_Name, @Date_Of_Birth, @Gender, @Age, @Address, @Phone_Number, @Email, @NIC_Number, @Cooking_Clubs, @Payment_Method, @Payment, @Date_of_Reg)";
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
         }*/



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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {

                try

                {
                        con.Open();

                    if (dataGridView1.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Please select a member to update.", "No Member Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;  // Exit the method to prevent further execution
                    }
                    int selectedRegistrationNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                  
                        string sqlquery = "UPDATE tbl_BlueWave SET First_Name = @First_Name,Last_Name = @Last_Name, Date_of_Birth = @Date_Of_Birth, Gender = @Gender, Age = @Age, Address = @Address, Phone_Number = @Phone_Number, Email = @Email , Cooking_Clubs = @Cooking_Clubs, Payment_Method = @Payment_Method, Payment = @Payment, Date_of_Reg = @Date_of_Reg WHERE Registration_No = @Registration_No";

                        //string sqlquery = "UPDATE INTO tbl_BlueWave VALUES(@First_Name, @Last_Name, @Date_Of_Birth, @Gender, @Age, @Address, @Phone_Number, @Email, @NIC_Number, @Cooking_Clubs, @Payment_Method, @Payment, @Date_of_Reg)";
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
                            com.Parameters.AddWithValue("@Registration_No", selectedRegistrationNo);










                            com.ExecuteNonQuery();
                            MessageBox.Show("Data Updated successfully!");
                        }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
           
            
            
            
            
            
            
            
            }
            


       

        
                    









        }

                


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstna.Clear();
            txtLastna.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtNIC.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSearch.Clear();


              /*  using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();

                        
                        string deleteQuery = "CLEAR FROM tbl_BlueWave";

                        using (SqlCommand com = new SqlCommand(deleteQuery, con))
                        {
                            com.ExecuteNonQuery();
                            MessageBox.Show("Data cleared successfully!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

               */
                RefreshDataGridView();
        }

            private void RefreshDataGridView()
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbl_BlueWave", con);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                }
            }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            // Open Dashboard Form
            FrmDashboard Dashboard = new FrmDashboard();

            // Close the current form
            this.Close();

            // Show the login form
            Dashboard.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* int rowIndex = dataGridView1.SelectedRows[0].Index;

             if(rowIndex >= 0)
             {
                 DialogResult result = MessageBox.Show("Are you sure, Do you really want to Delete this record...?", "Confirmation", MessageBoxButtons.YesNo);

                 if(result == DialogResult.Yes)
                 {

                     try
                     {
                         using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
                         {
                             con.Open();

                             string Registration_No_v = dataGridView1.Rows[rowIndex].Cells["Registration_No"].Value.ToString();
                             string sql = "DELETE FROM tbl_BlueWave WHERE Registration_No = @Registration_No";
                             SqlCommand cmd = new SqlCommand(sql, con);
                             cmd.Parameters.AddWithValue("@Registration_No", Registration_No_v);
                             int rowsAffected = cmd.ExecuteNonQuery();

                             if (rowsAffected > 0)
                             {
                                 MessageBox.Show("Member deleted successfully!");
                             }
                             else
                             {
                                 MessageBox.Show("Failed to delete member.");
                             }

                         }




                     }
                     catch (SqlException ex)
                     {
                         MessageBox.Show("Error deleting member: " + ex.Message);
                     }






                 }
             }
             else
             {
                 MessageBox.Show("Please select a member to delete.");
             }
            */
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select one or more members to delete.", "No Member Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected member(s)?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();

                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)  // Handle multiple selections
                        {
                            string Registration_No_v = row.Cells["Registration_No"].Value.ToString();
                            string sql = "DELETE FROM tbl_BlueWave WHERE Registration_No = @Registration_No";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@Registration_No", Registration_No_v);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Optionally remove the row visually from the grid
                                dataGridView1.Rows.Remove(row);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete member with Registration No: " + Registration_No_v, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        MessageBox.Show("Selected members deleted successfully!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting member(s): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*  SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True");
              con.Open();
              SqlCommand cmd = new SqlCommand("Select * from UserTab Where Registration No=@Registration_No", con);
              cmd.Parameters.AddWithValue("@First_Name", int.Parse(txtFirstna.Text));
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              da.Fill(dt);
              dataGridView1.DataSource=dt;*/

            string registrationId = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(registrationId))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        string sql = @"SELECT * FROM tbl_BlueWave WHERE Registration_No LIKE @Registration_NO";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Registration_NO", "%" + registrationId + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error searching data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a registration ID.");
            }



        }

        private void button1_Click(object sender, EventArgs e)
            
        {    //Refresh the database
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False"))
            {
                
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbl_BlueWave", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;







            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

