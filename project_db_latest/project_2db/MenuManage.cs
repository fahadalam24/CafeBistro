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
    public partial class MenuManage : Form
    {
        private List<MenuItem> menuItems;

        public MenuManage()
        {
            InitializeComponent();

            // Initialize the list
            menuItems = new List<MenuItem>();

            // Load menu items into the list (you can fetch them from the database)
            LoadMenuItems();
        }


        public void LoadMenuItems()
        {
            menuItems.Clear(); // Clear the existing items before loading from the database

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM MenuItems";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MenuItem menuItem = new MenuItem
                                {
                                    ItemName = reader["ItemName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    Category = reader["Category"].ToString()
                                };

                                menuItems.Add(menuItem);
                            }
                        }
                    }
                }

                // Display menu items in the DataGridView
                DisplayMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu items: {ex.Message}");
            }
        }

        private void DisplayMenuItems()
        {


            // Clear existing columns before adding new ones
            dataGridViewMenuItems.Columns.Clear();

            dataGridViewMenuItems.Columns.Add("ItemName", "Item Name");
            dataGridViewMenuItems.Columns.Add("Description", "Description");
            dataGridViewMenuItems.Columns.Add("Price", "Price");
            dataGridViewMenuItems.Columns.Add("Category", "Category");

            // Assuming you have a List<MenuItem> named menuItems
            foreach (MenuItem menuItem in menuItems)
            {
                dataGridViewMenuItems.Rows.Add(menuItem.ItemName, menuItem.Description, menuItem.Price, menuItem.Category);
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //// Open a form to add a new menu item
            //AddMenuItemForm addItemForm = new AddMenuItemForm();
            //addItemForm.ShowDialog();

            //// After adding, refresh the display
            //DisplayMenuItems();
        }


        private void MenuManage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {

            // Open a form to add a new menu item
            //AddMenuItem addItemForm = new AddMenuItem();
            //addItemForm.ShowDialog();
            // Open a form to add a new menu item, passing the MenuManage form and menuItems list as parameters
            AddMenuItem addItemForm = new AddMenuItem(this, menuItems);
            addItemForm.ShowDialog();

            // After adding, refresh the display
            DisplayMenuItems();


        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            // Get the selected menu item from the DataGridView
            if (dataGridViewMenuItems.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewMenuItems.SelectedRows[0].Index;
                MenuItem selectedItem = menuItems[selectedIndex];

                // Open the update form with the selected menu item
                UpdateMenuItem updateForm = new UpdateMenuItem(selectedItem, this);
                updateForm.ShowDialog();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Get the selected menu item from the DataGridView
    if (dataGridViewMenuItems.SelectedRows.Count > 0)
    {
        int selectedIndex = dataGridViewMenuItems.SelectedRows[0].Index;
        MenuItem selectedItem = menuItems[selectedIndex];

        // Open the remove form with the selected menu item
        RemoveMenuItem removeForm = new RemoveMenuItem(selectedItem, this);
        removeForm.ShowDialog();
    }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ManagerMain managemain = new ManagerMain();
            managemain.Show();
            this.Hide();
        }

        private void dataGridViewMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
