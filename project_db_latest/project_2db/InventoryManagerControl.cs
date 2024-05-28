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
    public partial class InventoryManagerControl : Form
    {
        public InventoryManagerControl()
        {
            InitializeComponent();
        }

        private void InventoryManagerControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the InventoryIM form
            InventoryIM inventoryIMForm = new InventoryIM();

            // Show the InventoryIM form
            inventoryIMForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the InventoryIM form
            Form1 inventoryIMForm = new Form1();

            // Show the InventoryIM form
            inventoryIMForm.Show();
            this.Hide();
        }
    }
}
