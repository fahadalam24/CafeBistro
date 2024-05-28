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
    public partial class CashierLogin : Form
    {
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            string cashierID = idtxt.Text;
            string password = passwordtxt.Text;




            Helper dbHelper = new Helper("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True");

            if (dbHelper.VerifyCashierLogin(cashierID, password))
            {
               
                
                
                
                MessageBox.Show("Login successful!");
                CashierForm cashierform = new CashierForm(cashierID);
                cashierform.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Invalid cashier ID or password. Please try again.");
            }


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
