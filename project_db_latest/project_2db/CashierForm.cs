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
    public partial class CashierForm : Form
    {
        private string cashierID;

        public CashierForm()
        {
            InitializeComponent();
            // Initialize other components if needed
        }

        // Add a constructor that takes the cashierID as an argument
        public CashierForm(string cashierID) 
        {
            InitializeComponent();
            this.cashierID = cashierID;
        }



        private void CashierForm_Load(object sender, EventArgs e)
        {

        }

        private void ProcessPaymentbtn_Click(object sender, EventArgs e)
        {
            string studentID = Studentidtxt.Text;
            int payableAmount = int.Parse(Payabletxt.Text);
            int paidAmount = int.Parse(recievedtxt.Text);

            // Assume you have a Cashier instance
            Cashier cashier = new Cashier(cashierID,15000, "Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                int change = (int)cashier.ProcessCashPayment(studentID, payableAmount, paidAmount);
                MessageBox.Show($"Payment processed successfully. Change: {change:C}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CashierLogin cashL = new CashierLogin();
            cashL.Show();
            this.Hide();
        }

        private void recievedtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
