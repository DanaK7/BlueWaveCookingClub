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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V2ASSM\\SQLEXPRESS;Initial Catalog=BlueWave;Integrated Security=True;Encrypt=False");
            con.Open();

            string sqlquery = "INSERT INTO tbl_BlueWave VALUES('"+ txtLastna .Text+ "')";

            SqlCommand com = new SqlCommand(sqlquery, con);
            com.ExecuteNonQuery();
            MessageBox.Show("dsfsdfsdcv");

        }
    }
}
