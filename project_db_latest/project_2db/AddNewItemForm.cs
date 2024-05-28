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
    public partial class AddNewItemForm : Form
    {
        public InventoryItem NewItem { get; private set; }
        public AddNewItemForm()
        {
            InitializeComponent();
        }
        
            private void btnOK_Click(object sender, EventArgs e)
            {
                // Validate input and create a new InventoryItem
                if (ValidateInput())
                {
                    NewItem = new InventoryItem
                    {
                        MenuItemID = Convert.ToInt32(textBoxMenuItemID.Text),
                        IngredientName = textBoxIngredientName.Text,
                        Quantity = Convert.ToInt32(textBoxQuantity.Text),
                        Threshold = Convert.ToInt32(textBoxThreshold.Text),
                        LastUpdated = DateTime.Now // You might want to use a DateTimePicker for a more user-friendly date input
                    };

                    // Close the form with DialogResult set to OK
                    DialogResult = DialogResult.OK;
                    Close();

                    // Show a success message box
                    MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Add a button for navigating back to the inventory page
                    var backButton = new Button
                    {
                        Text = "Back to Inventory",
                        DialogResult = DialogResult.Cancel, // Set DialogResult to Cancel so that you can handle it in the calling form
                        Size = new Size(120, 30),
                        Location = new Point(10, 10) // Adjust the location as needed
                    };

                    // Attach an event handler to the button's Click event to handle navigation back to the inventory page
                    backButton.Click += (s, args) =>
                    {
                        // Handle the navigation back to the inventory page here
                        // For example, if your inventory form is named 'InventoryForm', you can show it like this:
                        var inventoryForm = new InventoryIM();
                        inventoryForm.Show();
                    };

                    // Add the button to the form's Controls collection
                    Controls.Add(backButton);
                }
            }

        

        private bool ValidateInput()
        {
            // Implement your validation logic here
            // For simplicity, I'm just checking if the required textboxes are not empty
            if (string.IsNullOrWhiteSpace(textBoxMenuItemID.Text) ||
                string.IsNullOrWhiteSpace(textBoxIngredientName.Text) ||
                string.IsNullOrWhiteSpace(textBoxQuantity.Text) ||
                string.IsNullOrWhiteSpace(textBoxThreshold.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add more validation as needed (e.g., numeric checks, range checks)

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult set to Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void AddNewItemForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIngredientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            // Validate input and create a new InventoryItem
            if (ValidateInput())
            {
                NewItem = new InventoryItem
                {
                    MenuItemID = Convert.ToInt32(textBoxMenuItemID.Text),
                    IngredientName = textBoxIngredientName.Text,
                    Quantity = Convert.ToInt32(textBoxQuantity.Text),
                    Threshold = Convert.ToInt32(textBoxThreshold.Text),
                    LastUpdated = DateTime.Now // You might want to use a DateTimePicker for a more user-friendly date input
                };

                // Close the form with DialogResult set to OK
                DialogResult = DialogResult.OK;
                Close();

                // Show a success message box
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Add a button for navigating back to the inventory page
                var backButton = new Button
                {
                    Text = "Back to Inventory",
                    DialogResult = DialogResult.Cancel, // Set DialogResult to Cancel so that you can handle it in the calling form
                    Size = new Size(120, 30),
                    Location = new Point(10, 10) // Adjust the location as needed
                };

                // Attach an event handler to the button's Click event to handle navigation back to the inventory page
                backButton.Click += (s, args) =>
                {
                    // Handle the navigation back to the inventory page here
                    // For example, if your inventory form is named 'InventoryForm', you can show it like this:
                    var inventoryForm = new InventoryIM();
                    inventoryForm.Show();
                };

                // Add the button to the form's Controls collection
                Controls.Add(backButton);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            // Show a message box
            MessageBox.Show("Item not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Close the form with DialogResult set to Cancel
            DialogResult = DialogResult.Cancel;
            Close();

            //// Open the InventoryIm form
            //var inventoryImForm = new InventoryIM();
            //inventoryImForm.Show();
        }

    }
}
