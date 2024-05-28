using Microsoft.Data.SqlClient;
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
    public partial class UpdateMenuItem : Form
    {

        private MenuItem menuItem;
        private MenuManage parentForm;

        public UpdateMenuItem(MenuItem menuItem, MenuManage parentForm)
        {
            InitializeComponent();
            this.menuItem = menuItem;
            this.parentForm = parentForm;

            // Populate the form with the current information of the menu item
            btnItemName.Text = menuItem.ItemName;
            btnDescription.Text = menuItem.Description;
            btnPrice.Text = menuItem.Price.ToString();
            btnCategory.Text = menuItem.Category;
        }


        public UpdateMenuItem()
        {
            InitializeComponent();
        }

        private void UpdateMenuItem_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate and update the menu item in the database
            string updatedItemName = btnItemName.Text;
            string updatedDescription = btnDescription.Text;
            decimal updatedPrice = decimal.Parse(btnPrice.Text);
            string updatedCategory = btnCategory.Text;

            try
            {
                Helper.UpdateMenuItem(menuItem.ItemName, updatedItemName, updatedDescription, updatedPrice, updatedCategory);

                MessageBox.Show("Menu item updated successfully.");
                parentForm.LoadMenuItems(); // Refresh the display in the parent form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating menu item: {ex.Message}");
            }



        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MenuManage cartdisp = new MenuManage();
            cartdisp.Show();
            this.Hide();
        }
    }
}
