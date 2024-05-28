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
    public partial class JazzCash : Form
    {

        private readonly Helper dbHelper;
        private readonly string studentID;
        private readonly decimal totalAmount;
        public JazzCash()
        {
            InitializeComponent();
        }

        public JazzCash(string studentID, decimal totalAmount){

            InitializeComponent();
            this.studentID = studentID;
            this.totalAmount = totalAmount;
            dbHelper = new Helper("Data Source=Cactus\\\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True");
             comboBox1.Items.Add("JazzCash");
             comboBox1.Items.Add("EasyPaisa");
////
        }


        private void JazzCash_Load(object sender, EventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True";
            string cardHolderName = AccountHolderNametxt.Text;
            string cardNumber = accountNumbertxt.Text;
            string cvv = Pintxt.Text;
            string billingAddress = Addresstxt.Text;

            if (cardNumber.Length < 11)
            {
                MessageBox.Show("Account number is too short. Please enter a valid account number.");
                accountNumbertxt.Clear();
            
                return;
            }


            //   string maskedCardNumber = new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);

            dbHelper.InsertPayment_2(studentID, totalAmount, cardHolderName, cardNumber, billingAddress);



        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CartDisplayForm cartdisp = new CartDisplayForm();
            cartdisp.Show();
            this.Hide();
        }

        private void Addresstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
