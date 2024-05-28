using Microsoft.Data.SqlClient;
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
    public partial class InventoryM : Form
    {
        private readonly Helper dbHelper = new Helper("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True");

        public InventoryM()
        {
            InitializeComponent();
        }


        private void InventoryM_Load(object sender, EventArgs e)
        {
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

        private void backToManager_Click(object sender, EventArgs e)
        {
            // Show the ManagerControl form
            ManagerControl managerControlForm = new ManagerControl();
            managerControlForm.Show();

            // Close the current InventoryM form
            this.Close();
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
