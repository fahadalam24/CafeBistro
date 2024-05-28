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
    public partial class CartDisplayForm : Form
    {
        private string studentID;
        private Cart cart;
        public CartDisplayForm()
        {
            InitializeComponent();
            dataGridView_cart.Columns.Add("ItemName", "Item Name");
            dataGridView_cart.Columns.Add("Quantity", "Quantity");
            dataGridView_cart.Columns.Add("Price", "Price");
           // dataGridViewCart.Columns.Add("PreparationTime", "Preparation Time (minutes)");
        }

        public CartDisplayForm(string studentID, Cart cart)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.cart = cart;
            dataGridView_cart.Columns.Add("ItemName", "Item Name");
            dataGridView_cart.Columns.Add("Quantity", "Quantity");
            dataGridView_cart.Columns.Add("Price", "Price");

            paymentComboBox.Items.Add("Credit/Debit card");
            paymentComboBox.Items.Add("JazzCash/EasyPaisa");
            paymentComboBox.Items.Add("Cash");

            //dataGridViewCart.Columns.Add("PreparationTime", "Preparation Time (minutes)");
            // Initialize the form and store the cart information
            DisplayCartItems();
        }

        private void DisplayCartItems()
        {
            // Clear the existing rows
            dataGridView_cart.Rows.Clear();

            // Set column headers
            dataGridView_cart.Columns.Clear();
            dataGridView_cart.Columns.Add("ItemName", "Item Name");
            dataGridView_cart.Columns.Add("Quantity", "Quantity");
            dataGridView_cart.Columns.Add("Price", "Price");
            //  dataGridViewCart.Columns.Add("PreparationTime", "Preparation Time");

            // Set column widths and adjust auto-size behavior
            dataGridView_cart.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView_cart.Columns["Quantity"].Width = 80; // Set your desired width
            dataGridView_cart.Columns["Price"].Width = 80;

            dataGridView_cart.AllowUserToAddRows = false;
            int totalHeight = dataGridView_cart.ColumnHeadersHeight;
            // Add the cart items to the DataGridView
            foreach (CartItem cartItem in cart.GetCartItems())
            {
                DataGridViewRow cartRow = new DataGridViewRow();
              //  int constantPreparationTime = 10;
                cartRow.CreateCells(dataGridView_cart, cartItem.MenuItem.ItemName, cartItem.Quantity, cartItem.MenuItem.Price);
                dataGridView_cart.Rows.Add(cartRow);
            }

            foreach (DataGridViewRow row in dataGridView_cart.Rows)
            {
                totalHeight += row.Height;
            }
            dataGridView_cart.Height = totalHeight;


            // Update the total price label
            decimal totalPrice = cart.CalculateTotalPrice();
            Total_label.Text = $"Total Price: {totalPrice:C}";
        }





        private void CartDisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";
            // Get the selected payment method
            string selectedPaymentMethod = paymentComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPaymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }


            if (selectedPaymentMethod.Equals("Credit/Debit card", StringComparison.OrdinalIgnoreCase))
            {
                // Insert the payment into the database
                decimal totalAmount = cart.CalculateTotalPrice();

                // Pass studentID and totalAmount to Cardform
                Cardform cardForm = new Cardform(studentID, totalAmount);

                // Show the Cardform
                cardForm.Show();

                // Optionally, you can hide the current CartDisplayForm
                this.Hide();
            }

            else if (selectedPaymentMethod.Equals("JazzCash/EasyPaisa", StringComparison.OrdinalIgnoreCase))
            {
                decimal totalAmount = cart.CalculateTotalPrice();

                JazzCash jazzform = new JazzCash(studentID, totalAmount);
                jazzform.Show();
                this.Hide();
            }



            else
            {

                MessageBox.Show("Kindly pay at the counter when picking up your order, thank you.");


            }

            // Insert the payment into the database
            // decimal totalAmount = cart.CalculateTotalPrice();
            //string paymentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Format the date as per your database schema
            // Pass studentID and totalAmount to Cardform
            //   decimal totalAmount = cart.CalculateTotalPrice();

            // Cardform cardForm = new Cardform(studentID, totalAmount);
            // Show the DisplayCartForm
            //cardForm.Show();

            // Optionally, you can hide the current Menu form
            //  this.Hide();
            // Helper.InsertPayment(studentID, totalAmount, paymentDate, selectedPaymentMethod);
            //Helper dbHelper = new Helper(connectionString); // replace with your actual connection string
            // dbHelper.InsertPayment(studentID, totalAmount, paymentDate, selectedPaymentMethod);




        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Menu men = new Menu(studentID);
            men.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Form1 men = new Form1();
            men.Show();
            this.Hide();
        }
    }
}
