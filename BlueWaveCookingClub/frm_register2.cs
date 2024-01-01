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
           


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
    }
}
}
    




