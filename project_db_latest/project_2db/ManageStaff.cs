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
    public partial class ManageStaff : Form
    {
        private readonly Helper dbHelper = new Helper("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True");
        public ManageStaff()
        {
            InitializeComponent();
            LoadStaffData();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {

        }
        private void LoadStaffData()
        {
            try
            {
                // Retrieve staff data from the database
                var staffData = dbHelper.GetStaff();

                // Set the retrieved data as the DataSource for the DataGridView
                dataGridViewStaff.DataSource = staffData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewStaff.SelectedRows.Count > 0)
            {
                int selectedStaffID = (int)dataGridViewStaff.SelectedRows[0].Cells["StaffID"].Value;

                try
                {
                    dbHelper.FireStaffMember(selectedStaffID);
                    MessageBox.Show("Staff member fired successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Manually refresh the DataGridView
                    dataGridViewStaff.DataSource = null;
                    dataGridViewStaff.DataSource = dbHelper.GetStaff();


                    //  LoadStaffData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error firing staff member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to fire.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            var addStaffForm = new AddStaff(dbHelper);

            // Show the form as a dialog
            if (addStaffForm.ShowDialog() == DialogResult.OK)
            {
                // If the dialog result is OK, it means the user successfully added a staff member
                // Refresh the DataGridView by calling LoadStaffData
                LoadStaffData();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count > 0)
            {
                try
                {
                    int row = dataGridViewStaff.SelectedRows[0].Index;
                    DataGridViewCellCollection cells = dataGridViewStaff.Rows[row].Cells;
                    int selectedStaffID =Convert.ToInt32(cells["StaffID"].Value);

                    
                    UpdateStaffForm updateStaffForm = new UpdateStaffForm(dbHelper, selectedStaffID);
                    DialogResult result = updateStaffForm.ShowDialog();
                    dataGridViewStaff.DataSource = null;
                    dataGridViewStaff.DataSource = dbHelper.GetStaff();
                    // Show the form as a dialog
                    if (result == DialogResult.OK)
                    {
                        // If the dialog result is OK, it means the user successfully updated a staff member
                        // Refresh the DataGridView by calling LoadStaffData
                        // Manually refresh the DataGridView
                        dataGridViewStaff.DataSource = null;
                        dataGridViewStaff.DataSource = dbHelper.GetStaff();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving StaffID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Show the ManagerControl form
            ManagerControl managerControlForm = new ManagerControl();
            managerControlForm.Show();

            // Close the current InventoryM form
            this.Close();
        }

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
