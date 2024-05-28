using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2db
{
    public class Cashier
    {
        private string cashierID;
        private int cashInRegister;
        private readonly string connectionString;

        public Cashier(string cashierID, int initialCashInRegister, string connectionString)
        {
            this.cashierID = cashierID;
            cashInRegister = initialCashInRegister;
            this.connectionString = connectionString;
        }

        public decimal ProcessCashPayment(string studentID, int totalAmount, int paymentAmount)
        {
            // Check if the payment amount is sufficient
            if (paymentAmount < totalAmount)
            {
                throw new InvalidOperationException("Insufficient payment amount");
            }

            // Calculate change
            int change = paymentAmount - totalAmount;

            // Update cash in register (assuming the cashier gives change from the register)
            cashInRegister -= change;

            // Update database with cash payment information
            UpdateCashPaymentDatabase(studentID, totalAmount, paymentAmount, change);

            return change;
        }

        private void UpdateCashPaymentDatabase(string studentID, int totalAmount, int paymentAmount, int change)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Assuming there is a CashPayments table with appropriate columns
                string insertQuery = "INSERT INTO CashPayments (CashierID, StudentID, TotalAmount, PaymentAmount, Change) " +
                                     "VALUES (@CashierID, @StudentID, @TotalAmount, @PaymentAmount, @Change)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@CashierID", cashierID);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    command.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                    command.Parameters.AddWithValue("@Change", change);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
