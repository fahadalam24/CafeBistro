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
    public partial class Payment : Form
    {
        private decimal totalAmount;
        public Payment(decimal totalAmount)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // Display the total amount in a label or textbox
            labelTotalAmount.Text = $"Total Amount: {totalAmount:C}";
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Display the total amount in a label or textbox
            labelTotalAmount.Text = $"Total Amount: {totalAmount:C}";
        }
    }
}
