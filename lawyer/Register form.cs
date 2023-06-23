using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lawyer
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        private void next_button_Click(object sender, EventArgs e)
        {

            string filePath = "registration.txt"; // Path of the Notepad file

            // Retrieve form data
            string first_nam = first_name.Text;
            string Secound_nam = Secound_name.Text;
            string initialize_nam = initialize_name.Text;
            string id_num = id_number.Text;

            // Construct the data string to be saved
            string data = $"First Name: {first_name}\r\nSecound Name: {Secound_name}\r\nInitialize Name: {initialize_name}\r\nId Number: {id_number}\r\n" ;

            // Write data to the Notepad file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(data);
            }

            MessageBox.Show("Data saved successfully.");

            // Create an instance of the registration form
            B_day_form B_day_form = new B_day_form();

            // Hide the login form
            this.Hide();

            // Show the registration form
            B_day_form.Show();


        }

        private void first_name_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter  ) {
              fist_name_error.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void initialize_name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
