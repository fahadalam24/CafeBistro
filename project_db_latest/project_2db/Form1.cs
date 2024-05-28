namespace project_2db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Student Section");
            // Open the StudentMain form
            StudentMain studentMainForm = new StudentMain();
            studentMainForm.Show();
            // Hide the current form
            this.Hide();
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Manager Section");

            // Open the ManagerMain form (replace ManagerMain with the actual form name)
            ManagerMain managerMainForm = new ManagerMain();
            managerMainForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Staff Section");

            // Open the StaffMain form (replace StaffMain with the actual form name)
            CashierLogin staffMainForm = new CashierLogin();
            staffMainForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void buttonIM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Inventory Manager Section");

            // Open the StaffMain form (replace StaffMain with the actual form name)
            InventoryManagerMain staffMainForm = new InventoryManagerMain();
            staffMainForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}