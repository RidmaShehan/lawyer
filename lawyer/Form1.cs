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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Create an instance of the registration form
            Register_form Register_form = new Register_form();

            // Hide the login form
            this.Hide();

            // Show the registration form
            Register_form.Show();

        }
    }
}
