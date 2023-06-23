using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lawyer
{
    public partial class B_day_form : Form
    {
        public B_day_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
              
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void B_day_form_Load(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            // Create an instance of the registration form
            Contact_form Contact_form = new Contact_form();

            // Hide the login form
            this.Hide();

            // Show the registration form
            Contact_form.Show();
        }
    }
}
