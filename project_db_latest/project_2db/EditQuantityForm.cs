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
    public partial class EditQuantityForm : Form
    {
        public EditQuantityForm()
        {
            InitializeComponent();
        }
        public int NewQuantity { get; private set; }

        public EditQuantityForm(string ingredientName, int currentQuantity)
        {
            InitializeComponent();

            // Initialize form controls and display the current quantity
            labelIngredientName.Text = "Ingredient: " + ingredientName;
            numericUpDownQuantity.Value = currentQuantity;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Set the NewQuantity property to the value entered by the user
            NewQuantity = (int)numericUpDownQuantity.Value;

            // Close the form with DialogResult set to OK
            DialogResult = DialogResult.OK;
            Close();

            // Show a success message box
            MessageBox.Show("Quantity successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult set to Cancel
            DialogResult = DialogResult.Cancel;
            Close();
            // Open the InventoryForm
            var inventoryForm = new InventoryIM();
            inventoryForm.Show();
        }
        private void EditQuantityForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            // Set the NewQuantity property to the value entered by the user
            NewQuantity = (int)numericUpDownQuantity.Value;

            // Close the form with DialogResult set to OK
            DialogResult = DialogResult.OK;
            Close();

            // Show a success message box
            MessageBox.Show("Quantity successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            // Close the form with DialogResult set to Cancel
            DialogResult = DialogResult.Cancel;
            Close();
            // Open the InventoryForm
            var inventoryForm = new InventoryIM();
            inventoryForm.Show();
        }
    }
}
