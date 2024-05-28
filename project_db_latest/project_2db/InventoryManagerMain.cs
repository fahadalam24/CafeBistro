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
    public partial class InventoryManagerMain : Form
    {
        public InventoryManagerMain()
        {
            InitializeComponent();
        }

        private void InventoryManagerMain_Load(object sender, EventArgs e)
        {

        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";

            string username = Usernametxt.Text;
            string password = Passwordtxt.Text;

            // Create an instance of the Helper class
            Helper dbHelper = new Helper(connectionString);

            // Verify manager login
            if (dbHelper.VerifyInventManagerLogin(username, password))
            {
                MessageBox.Show("Manager login successful!");
                // Perform any additional actions after successful login

                InventoryManagerControl controlmenu = new InventoryManagerControl();
                controlmenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the InventoryIM form
            Form1 inventoryIMForm = new Form1();

            // Show the InventoryIM form
            inventoryIMForm.Show();
            this.Hide();
        }
    }
}
