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
    public partial class AddStaff : Form
    {
        private readonly Helper dbHelper;

        public AddStaff(Helper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate input and add staff member
            if (ValidateInput())
            {
                string username = Username.Text;
                string password = Password.Text;
                string firstName = FirstName.Text;
                string lastName = LastName.Text;
                decimal salary = numericUpDownSalary.Value;
                DateTime dateJoined = DateTime.Now; // You may want to use a DateTimePicker for a more user-friendly date input

                try
                {
                    dbHelper.AddStaffMember(username, password, firstName, lastName, salary, dateJoined);
                    MessageBox.Show("Staff member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set DialogResult to OK before closing the form
                    DialogResult = DialogResult.OK;
                    this.Close(); // Close the form after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Implement your validation logic here
            // For simplicity, I'm just checking if the required textboxes are not empty
            if (string.IsNullOrWhiteSpace(Username.Text) ||
                string.IsNullOrWhiteSpace(Password.Text) ||
                string.IsNullOrWhiteSpace(FirstName.Text) ||
                string.IsNullOrWhiteSpace(LastName.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add more validation as needed (e.g., password strength check, salary range check)

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
