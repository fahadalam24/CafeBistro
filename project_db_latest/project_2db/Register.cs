using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2db
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";
           
            string password = Passwordtxt.Text;
            string confirmPassword = reEntertxt.Text;

            // Check if the entered password and confirmed password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirmed password do not match. Please re-enter the passwords.");
                // Optionally clear the password and confirm password textboxes
                Passwordtxt.Clear();
                reEntertxt.Clear();
                // You might want to return or exit the method here
                return;
            }
            // Create an instance of the Helper class
            Helper helper = new Helper(connectionString);

            // If passwords match, proceed with registration
            // Continue with the rest of your registration logic, including calling InsertStudent method

            // Assuming helper is an instance of your Helper class
            Student newStudent = new Student
            {
                StudentID = StudentIDtxt.Text,
                Password = Passwordtxt.Text,
                PhoneNumber = Phonetxt.Text,
                StudentName = Nametxt.Text
            };

            helper.InsertStudent(newStudent);


            
            MessageBox.Show("Registration successful!");

            // Close the current registration form
            this.Close();

            // Show the login form
            StudentMain loginForm = new StudentMain();
            loginForm.Show();
            this.Hide();


        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            StudentMain loginForm = new StudentMain();
            loginForm.Show();
            // Optionally, you can hide the current form
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
