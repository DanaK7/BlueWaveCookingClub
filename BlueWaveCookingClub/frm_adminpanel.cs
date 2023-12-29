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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            {
                // Check if a row is selected in the dataGridView1
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Retrieve data from the selected row
                    string firstName = Convert.ToString(selectedRow.Cells["First_Name"].Value);
                    string lastName = Convert.ToString(selectedRow.Cells["Last_Name"].Value);
                    string dateOfBirth = Convert.ToString(selectedRow.Cells["Date_Of_Birth"].Value);
                    string gender = Convert.ToString(selectedRow.Cells["Gender"].Value);
                    string age = Convert.ToString(selectedRow.Cells["Age"].Value);
                    string address = Convert.ToString(selectedRow.Cells["Address"].Value);
                    string phoneNumber = Convert.ToString(selectedRow.Cells["Phone_Number"].Value);
                    string email = Convert.ToString(selectedRow.Cells["Email"].Value);
                    string nicNumber = Convert.ToString(selectedRow.Cells["NIC_Number"].Value);
                    string cookingClubs = Convert.ToString(selectedRow.Cells["Cooking_Clubs"].Value);
                    string paymentMethod = Convert.ToString(selectedRow.Cells["Payment_Method"].Value);
                    string payment = Convert.ToString(selectedRow.Cells["Payment"].Value);
                    string dateOfReg = Convert.ToString(selectedRow.Cells["Date_of_Reg"].Value);

                    // Assuming that you have textboxes and other controls on your form
                    // Populate your form controls with the selected data
                    txtFirstna.Text = firstName;
                    txtLastna.Text = lastName;
                    dateOfBirth.Value = DateTime.Parse(dateOfBirth); // Assuming dateOfBirthPicker is a DateTimePicker
                    cbGender.Text = gender;
                    cbAge.Text = age;
                    txtAddress.Text = address;
                    txtPhone.Text = phoneNumber;
                    txtEmail.Text = email;
                    txtNIC.Text = nicNumber;
                    cbCooking.Text = cookingClubs;
                    cbPayM.Text = paymentMethod;
                    cbPayment.Text = payment;
                    dateOfReg.Value = DateTime.Parse(dateOfReg); // Assuming dateOfRegPicker is a DateTimePicker

                    // Now the user can modify the data in the form's controls

                    // After modifications, you can use the existing code for inserting data into the database with slight modifications
                    using (SqlConnection con = new SqlConnection("Your connection string"))
                    {
                        try
                        {
                            con.Open();
                            string sqlquery = "UPDATE tbl_BlueWave SET First_Name = @First_Name, Last_Name = @Last_Name, Date_Of_Birth = @Date_Of_Birth, Gender = @Gender, Age = @Age, Address = @Address, Phone_Number = @Phone_Number, Email = @Email, NIC_Number = @NIC_Number, Cooking_Clubs = @Cooking_Clubs, Payment_Method = @Payment_Method, Payment = @Payment, Date_of_Reg = @Date_of_Reg WHERE YourPrimaryKeyColumn = @





                        }
                } }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();

                        // Assuming you want to search based on the first name
                        string searchFirstName = txtFirstna.Text;

                        string sqlquery = "SELECT * FROM tbl_BlueWave WHERE First_Name LIKE @SearchFirstName";
                        using (SqlCommand com = new SqlCommand(sqlquery, con))
                        {
                            com.Parameters.AddWithValue("@SearchFirstName", "%" + searchFirstName + "%");

                            SqlDataAdapter sqlDa = new SqlDataAdapter(com);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);

                            dataGridView1.DataSource = dtbl;

                            if (dtbl.Rows.Count == 0)
                            {
                                MessageBox.Show("No matching records found.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Assuming you have a unique identifier for the record (e.g., ID)
            int selectedRowID = GetSelectedRowID(); // Implement this method to get the selected row's ID

            // Ensure a valid ID is selected
            if (selectedRowID > 0)
            {
                // Delete the record from the database
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM tbl_BlueWave WHERE ID = @ID";

                        using (SqlCommand com = new SqlCommand(deleteQuery, con))
                        {
                            com.Parameters.AddWithValue("@ID", selectedRowID);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                // Refresh the DataGridView after deletion
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        // Method to get the ID of the selected row in the DataGridView
        private int GetSelectedRowID()
        {
            int selectedRowID = 0;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assuming the first cell in the selected row contains the ID
                selectedRowID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            }

            return selectedRowID;
        }

        // Method to refresh the DataGridView after deletion
        private void RefreshDataGridView()
        {
            using (SqlConnection con = new SqlConnection("Your_Connection_String_Here"))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tbl_BlueWave", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();

                        // Warning: This query will delete all records in the table. Be cautious when using it.
                        string deleteQuery = "DELETE FROM tbl_BlueWave";

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

                // Refresh the DataGridView if needed
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

            // Assuming FrmLogin is the name of your login form
            FrmLogin loginForm = new FrmLogin();

            // Close the current form
            this.Close();

            // Show the login form
            loginForm.Show();
        }
    }
}

