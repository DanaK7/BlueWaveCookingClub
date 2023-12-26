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

        private void btnNext_Click(object sender, EventArgs e)
        {
            {
                // Create a new instance for registration form 2
                FrmRegister2 Registration2 = new FrmRegister2();


                // Show the registration form 2
                Registration2.Show();

                //Hide the current form (register form 1)
                this.Hide();
            }
        }
    }
}
