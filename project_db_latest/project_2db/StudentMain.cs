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
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";

            string username = txtStudentID.Text;
            string password = txtPassword.Text;

            Helper dbHelper = new Helper(connectionString); // Replace with your actual connection string
             
            if (dbHelper.VerifyStudentLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Perform any additional actions after successful login
                //// Create an instance of the Menu form
                Menu menuForm = new Menu(username);
                menuForm.Show();
                this.Hide();

                // Pass the username to the DashboardStudent form
                //DashboardStudent dash = new DashboardStudent(username);



                //dash.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // Assuming you have a registration form named RegistrationForm
            Register newRegister = new Register();
            newRegister.Show();

            // Optionally, you can hide the current form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            // Optionally, you can hide the current form
            this.Hide();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }
    }
}
