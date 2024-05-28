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
    public partial class ManagerControl : Form
    {
        public ManagerControl()
        {
            InitializeComponent();
        }

        private void ManagerControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Invent_Click(object sender, EventArgs e)
        {
            InventoryM controlInvent = new InventoryM();
            controlInvent.Show();
            this.Hide();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            ManageStaff controlInvent = new ManageStaff();
            controlInvent.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the InventoryIM form
            ManagerMain inventoryIMForm = new ManagerMain();

            // Show the InventoryIM form
            inventoryIMForm.Show();
            this.Hide();
        }
    }
}
