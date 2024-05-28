using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace project_2db
{
    public partial class Menu : Form
    {
      //  string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";
        private readonly Helper dbHelper = new Helper("Data Source = Cactus\\SQLEXPRESS; Initial Catalog = CafeBistro; Integrated Security = True; TrustServerCertificate=True");

        private Cart cart;
        private string studentID;
        public Menu(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            PopulateMenu();
            cart = new Cart();

            // Add columns to the cart DataGridView
            dataGridViewCart.Columns.Add("ItemName", "Item Name");
            dataGridViewCart.Columns.Add("Quantity", "Quantity");
            dataGridViewCart.Columns.Add("Price", "Price");
           // dataGridViewCart.Columns.Add("NutritionalValue", "NutritionalValue");


        }

        private void PopulateMenu()
        {
            List<MenuItem> menuItems = dbHelper.GetMenuItems(); 
            dataGridViewMenu.DataSource = menuItems;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                MenuItem selectedMenuItem = (MenuItem)dataGridViewMenu.SelectedRows[0].DataBoundItem;

                // Get the quantity from the numericUpDown control
                int quantity = (int)numericUpDownQuantity.Value;

                // Add the selected menu item to the cart
                cart.AddItem(selectedMenuItem, quantity);

                // Insert into the Cart table
                dbHelper.InsertCartItem(studentID, selectedMenuItem.MenuItemID, quantity);

                // Update the cart display
                RefreshCartDataGridView();

                // Show a confirmation message or perform other actions
                MessageBox.Show("Item added to the cart!");
            }
            else
            {
                MessageBox.Show("Please select a menu item first.");
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RefreshCartDataGridView()
        {
            // Clear the existing rows
            dataGridViewCart.Rows.Clear();

            foreach (DataGridViewColumn column in dataGridViewCart.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dataGridViewCart.AllowUserToAddRows = false;
            dataGridViewCart.RowHeadersVisible = false;

            int totalHeight = dataGridViewCart.ColumnHeadersHeight;
            // Add the updated cart items to the DataGridView
            foreach (CartItem cartItem in cart.GetCartItems())
            {
                DataGridViewRow cartRow = new DataGridViewRow();
                cartRow.CreateCells(dataGridViewCart, cartItem.MenuItem.ItemName, cartItem.Quantity, cartItem.MenuItem.Price);
                dataGridViewCart.Rows.Add(cartRow);
            }

            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                totalHeight += row.Height;
            }
            dataGridViewCart.Height = totalHeight;


            // Update the total price label
            decimal totalPrice = cart.CalculateTotalPrice();
            Pricelabel.Text = $"Total Price: {totalPrice:C}";
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            // Create an instance of the DisplayCartForm
           // CartDisplayForm displayCartForm = new CartDisplayForm(cart);
            CartDisplayForm displayCartForm = new CartDisplayForm(studentID, cart);

            CartDisplayForm dispcart=new CartDisplayForm(studentID,cart);
            // Show the DisplayCartForm
            displayCartForm.Show();

            // Optionally, you can hide the current Menu form
            this.Hide();
        }

        private void Pricelabel_Click(object sender, EventArgs e)
        {
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            StudentMain main = new StudentMain();
            main.Show();
            this.Hide();
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
