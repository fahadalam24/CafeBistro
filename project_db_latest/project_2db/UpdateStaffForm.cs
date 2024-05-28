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
    public partial class UpdateStaffForm : Form
    {
        private readonly Helper dbHelper;
        private readonly int staffID;
        public UpdateStaffForm(Helper dbHelper, int staffID)
        {
            InitializeComponent();
            // Set the Minimum, Maximum, and Increment properties for the numericUpDownSalary control
            numericUpDownSalary.Minimum = 0;  // Set the minimum value
            numericUpDownSalary.Maximum = 1000000;  // Set the maximum value
            numericUpDownSalary.Increment = 1000;  // Set the increment value

            this.dbHelper = dbHelper;
            this.staffID = staffID;
            LoadStaffDetails();
        }
        private void LoadStaffDetails()
        {
            try
            {
                // Retrieve staff details by staffID
                var staffDetails = dbHelper.GetStaffDetails(staffID);

                // Populate the form with the retrieved details
                if (staffDetails != null)
                {
                    textBoxUsername.Text = staffDetails["Username"].ToString();
                    textBoxPassword.Text = staffDetails["Password"].ToString();
                    textBoxFirstName.Text = staffDetails["FirstName"].ToString();
                    textBoxLastName.Text = staffDetails["LastName"].ToString();
                    numericUpDownSalary.Value = Convert.ToDecimal(staffDetails["Salary"]);

                    // Check if DateJoined exists in the retrieved data
                    if (staffDetails.Table.Columns.Contains("DateJoined"))
                    {
                        // Assume the DateJoined field is a DateTime type
                        DateTime dateJoined = Convert.ToDateTime(staffDetails["DateJoined"]);
                        dateTimePickerDateJoined.Value = dateJoined;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if an error occurs
            }
        }

        private void UpdateStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            // Validate input and update staff member details
            if (ValidateInput())
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                decimal salary = numericUpDownSalary.Value;
                DateTime dateJoined = dateTimePickerDateJoined.Value; // Get the value from the DateTimePicker

                try
                {
                    dbHelper.UpdateStaffMember(staffID, username, password, firstName, lastName, salary, dateJoined);
                    MessageBox.Show("Staff member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close(); // Close the form after a successful update
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateInput()
        {
            // Implement your validation logic here
            // For simplicity, I'm just checking if the required textboxes are not empty
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add more validation as needed (e.g., password strength check, salary range check)

            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
