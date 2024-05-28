using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2db
{
    public partial class Cardform : Form
    {

        private readonly Helper dbHelper;
        private readonly string studentID;
        private readonly decimal totalAmount;

        public Cardform()
        {
            InitializeComponent();
        }

        public Cardform(string studentID, decimal totalAmount)
        {
            InitializeComponent();

            this.studentID = studentID;
            this.totalAmount = totalAmount;
            dbHelper = new Helper("Data Source=Cactus\\\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"); 
        }



        private void Cardform_Load(object sender, EventArgs e)
        {

        }

        private bool IsCardNumberValid(string cardNumber)
        {
            int sum = 0;
            bool alternate = false;

            foreach (char digit in cardNumber.Reverse())
            {
                if (char.IsDigit(digit))
                {
                    int num = (digit - '0') * (alternate ? 2 : 1);
                    sum += num > 9 ? num - 9 : num;
                    alternate = !alternate;
                }
                else
                {
                   
                    return false;
                }
            }

            return sum % 10 == 0;
        }

        private void pay_button_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";
            string cardHolderName = cardHoldertxt.Text;
            string cardNumber = cardNumbertxt.Text;
            string cvv = Cvvtxt.Text;
            string billingAddress = BillingAddresstxt.Text;

            if (cardNumber.Length < 16)
            {
                MessageBox.Show("Card number is too short. Please enter a valid card number.");
                cardNumbertxt.Clear();
              //    Passwordtxt.Clear();
                    return;
            }
            
            
         //   string maskedCardNumber = new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);

            dbHelper.InsertPayment(studentID, totalAmount, cardHolderName, cardNumber, billingAddress);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            // Verify card using Luhn algo
            //if (IsCardNumberValid(cardNumber))
            //{
            //    // Mark as paid and insert into the Payments table
            //    //InsertPayment(cardHolderName, cardNumber, cvv, billingAddress);
            //    Helper dbHelper = new Helper(connectionString); // replace with your actual connection string

            //    // Insert the payment into the database
            //    dbHelper.InsertPayment(studentID, totalAmount, cardHolderName, maskedCardNumber, billingAddress);
            //    // Optionally, show a success message or navigate to another form
            //    MessageBox.Show("Payment successful!");
            //}
            //else
            //{
            //    // Show an error message for invalid card
            //    MessageBox.Show("Invalid card number. Please check and try again.");
            //   // cardNumbertxt.Clear();
            //}
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CartDisplayForm cartdisp = new CartDisplayForm();
            cartdisp.Show();
            this.Hide();
        }
    }
}
