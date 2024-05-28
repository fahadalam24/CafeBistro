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
    public partial class AddMenuItem : Form
    {
       private MenuManage parentForm; // Reference to the parent form
       private List<MenuItem> menuItems; // Reference to the menuItems list in the parent form
        public AddMenuItem(MenuManage parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        public AddMenuItem(MenuManage parentForm, List<MenuItem> menuItems)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.menuItems = menuItems;
        }

        public AddMenuItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate and add the new menu item to the database

            string itemName = btnItemName.Text;
            string description = btnDescription.Text;
            decimal price = decimal.Parse(btnPrice.Text);
            string category = btnCategory.Text;

            // Create a new MenuItem
            MenuItem newItem = new MenuItem
            {
                ItemName = itemName,
                Description = description,
                Price = price,
                Category = category
            };

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();

                    // Insert the new menu item into the database
                    string insertQuery = "INSERT INTO MenuItems (ItemName, Description, Price, Category) VALUES (@ItemName, @Description, @Price, @Category)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", newItem.ItemName);
                        command.Parameters.AddWithValue("@Description", newItem.Description);
                        command.Parameters.AddWithValue("@Price", newItem.Price);
                        command.Parameters.AddWithValue("@Category", newItem.Category);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Menu item added successfully.");
                // Update the menuItems list in the parent form
                menuItems.Clear();
                parentForm.LoadMenuItems();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding menu item: {ex.Message}");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuManage cartdisp = new MenuManage();
            cartdisp.Show();
            this.Hide();
        }
    }
}
