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
    public partial class RemoveMenuItem : Form
    {
        private MenuItem menuItem;
        private MenuManage parentForm;

        public RemoveMenuItem(MenuItem menuItem, MenuManage parentForm)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            this.parentForm = parentForm;

            // Display information about the menu item you are about to remove
            DisplayMenuItemInfo();
        }

        private void DisplayMenuItemInfo()
        {
            // Populate labels or textboxes with information about the menu item
           ItemNametxt.Text = menuItem.ItemName;
            descriptiontxt.Text = menuItem.Description;
            pricetxt.Text = menuItem.Price.ToString();
            categorytxt.Text = menuItem.Category;
        }

        private void RemoveMenuItem_Load(object sender, EventArgs e)
        {

        }

        private void Removebtn_Click(object sender, EventArgs e)
        {

            try
            {
                // Assuming you have a method to remove the menu item from the database in your Helper class
                Helper.RemoveMenuItem(menuItem.ItemName);

                // Once the item is successfully removed, update the parent form
                parentForm.LoadMenuItems();
                MessageBox.Show("Menu item removed successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing menu item: {ex.Message}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuManage cartdisp = new MenuManage();
            cartdisp.Show();
            this.Hide();
        }
    }
}
