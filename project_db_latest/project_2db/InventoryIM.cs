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
    public partial class InventoryIM : Form
    {
        private readonly Helper dbHelper = new Helper("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True");
        public InventoryIM()
        {
            InitializeComponent();
        }
        

        private void InventoryIM_Load(object sender, EventArgs e)
        {
            // LoadInventoryData();
            // Call the GetInventoryItems method to fetch inventory items from the database
            List<InventoryItem> inventoryItems = dbHelper.GetInventoryItems();

            // Clear existing columns
            dataGridViewInventory.Columns.Clear();

            // Add columns based on InventoryItem properties
            //dataGridViewInventory.Columns.Add("InventoryID", "Inventory ID");
            //dataGridViewInventory.Columns.Add("MenuItemID", "Menu Item ID");
            //dataGridViewInventory.Columns.Add("IngredientName", "Ingredient Name");
            //dataGridViewInventory.Columns.Add("Quantity", "Quantity");
            //dataGridViewInventory.Columns.Add("Threshold", "Threshold");
            //dataGridViewInventory.Columns.Add("LastUpdated", "Last Updated");

            // Set the DataSource
            dataGridViewInventory.DataSource = inventoryItems;

            // You can customize column properties as needed, e.g., format the date column:
            dataGridViewInventory.Columns["LastUpdated"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }

        private void LoadInventoryData()
        {
            List<InventoryItem> inventoryItems = dbHelper.GetInventoryItems();
            dataGridViewInventory.DataSource = inventoryItems;
        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            // Get the selected item from the DataGridView
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                // Assuming that Quantity is the column name for the quantity in the DataGridView
                int rowIndex = dataGridViewInventory.SelectedRows[0].Index;
                DataGridViewCellCollection cells = dataGridViewInventory.Rows[rowIndex].Cells;

                // Get the values of the selected item
                int inventoryID = Convert.ToInt32(cells["InventoryID"].Value);
                string ingredientName = cells["IngredientName"].Value.ToString();
                int currentQuantity = Convert.ToInt32(cells["Quantity"].Value);

                // Show a form or dialog to edit the quantity
                EditQuantityForm editQuantityForm = new EditQuantityForm(ingredientName, currentQuantity);
                DialogResult result = editQuantityForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Update the quantity in the database
                    dbHelper.UpdateInventoryItemQuantity(inventoryID, editQuantityForm.NewQuantity);

                    // Refresh the DataGridView to reflect the changes
                    LoadInventoryData();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Edit Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Show a form or dialog to add a new inventory item
            AddNewItemForm addItemForm = new AddNewItemForm();
            DialogResult result = addItemForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Insert the new item into the database
                dbHelper.InsertInventoryItem(addItemForm.NewItem);

                // Refresh the DataGridView to reflect the changes
                LoadInventoryData();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // Get the selected item from the DataGridView
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                // Assuming that InventoryID is the column name for the inventory ID in the DataGridView
                int inventoryID = Convert.ToInt32(dataGridViewInventory.SelectedRows[0].Cells["InventoryID"].Value);

                // Show a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the item from the database
                    dbHelper.DeleteInventoryItem(inventoryID);

                    // Refresh the DataGridView to reflect the changes
                    LoadInventoryData();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void backToIM_Click(object sender, EventArgs e)
        {
            // Show the ManagerControl form
            InventoryManagerControl managerControlForm = new InventoryManagerControl();
            managerControlForm.Show();

            // Close the current InventoryM form
            this.Close();
        }
        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryIM_Load_1(object sender, EventArgs e)
        {

            // LoadInventoryData();
            // Call the GetInventoryItems method to fetch inventory items from the database
            List<InventoryItem> inventoryItems = dbHelper.GetInventoryItems();

            // Clear existing columns
            dataGridViewInventory.Columns.Clear();

            // Add columns based on InventoryItem properties
            //dataGridViewInventory.Columns.Add("InventoryID", "Inventory ID");
            //dataGridViewInventory.Columns.Add("MenuItemID", "Menu Item ID");
            //dataGridViewInventory.Columns.Add("IngredientName", "Ingredient Name");
            //dataGridViewInventory.Columns.Add("Quantity", "Quantity");
            //dataGridViewInventory.Columns.Add("Threshold", "Threshold");
            //dataGridViewInventory.Columns.Add("LastUpdated", "Last Updated");

            // Set the DataSource
            dataGridViewInventory.DataSource = inventoryItems;

            // You can customize column properties as needed, e.g., format the date column:
            dataGridViewInventory.Columns["LastUpdated"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }

        private void btnEditQuantity_Click_1(object sender, EventArgs e)
        {
            // Get the selected item from the DataGridView
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                // Assuming that Quantity is the column name for the quantity in the DataGridView
                int rowIndex = dataGridViewInventory.SelectedRows[0].Index;
                DataGridViewCellCollection cells = dataGridViewInventory.Rows[rowIndex].Cells;

                // Get the values of the selected item
                int inventoryID = Convert.ToInt32(cells["InventoryID"].Value);
                string ingredientName = cells["IngredientName"].Value.ToString();
                int currentQuantity = Convert.ToInt32(cells["Quantity"].Value);

                // Show a form or dialog to edit the quantity
                EditQuantityForm editQuantityForm = new EditQuantityForm(ingredientName, currentQuantity);
                DialogResult result = editQuantityForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Update the quantity in the database
                    dbHelper.UpdateInventoryItemQuantity(inventoryID, editQuantityForm.NewQuantity);

                    // Refresh the DataGridView to reflect the changes
                    LoadInventoryData();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Edit Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            // Show a form or dialog to add a new inventory item
            AddNewItemForm addItemForm = new AddNewItemForm();
            DialogResult result = addItemForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Insert the new item into the database
                dbHelper.InsertInventoryItem(addItemForm.NewItem);

                // Refresh the DataGridView to reflect the changes
                LoadInventoryData();
            }

        }

        private void btnDeleteItem_Click_1(object sender, EventArgs e)
        {
            // Get the selected item from the DataGridView
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                // Assuming that InventoryID is the column name for the inventory ID in the DataGridView
                int inventoryID = Convert.ToInt32(dataGridViewInventory.SelectedRows[0].Cells["InventoryID"].Value);

                // Show a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the item from the database
                    dbHelper.DeleteInventoryItem(inventoryID);

                    // Refresh the DataGridView to reflect the changes
                    LoadInventoryData();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backToIM_Click_1(object sender, EventArgs e)
        {
            // Show the ManagerControl form
            InventoryManagerControl managerControlForm = new InventoryManagerControl();
            managerControlForm.Show();

            // Close the current InventoryM form
            this.Close();
        }
    }
}
