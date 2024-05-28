namespace project_2db
{
    partial class InventoryIM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.backToIM = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewInventory.Location = new System.Drawing.Point(23, 64);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 62;
            this.dataGridViewInventory.RowTemplate.Height = 33;
            this.dataGridViewInventory.Size = new System.Drawing.Size(882, 333);
            this.dataGridViewInventory.TabIndex = 0;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellContentClick);
            // 
            // backToIM
            // 
            this.backToIM.BackColor = System.Drawing.Color.SeaShell;
            this.backToIM.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToIM.ForeColor = System.Drawing.Color.IndianRed;
            this.backToIM.Location = new System.Drawing.Point(23, 12);
            this.backToIM.Name = "backToIM";
            this.backToIM.Size = new System.Drawing.Size(102, 39);
            this.backToIM.TabIndex = 1;
            this.backToIM.Text = "Back";
            this.backToIM.UseVisualStyleBackColor = false;
            this.backToIM.Click += new System.EventHandler(this.backToIM_Click_1);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.SeaShell;
            this.btnDeleteItem.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDeleteItem.Location = new System.Drawing.Point(614, 421);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(147, 39);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click_1);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.SeaShell;
            this.btnAddItem.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAddItem.Location = new System.Drawing.Point(378, 421);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(155, 39);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.BackColor = System.Drawing.Color.SeaShell;
            this.btnEditQuantity.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEditQuantity.Location = new System.Drawing.Point(159, 421);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(156, 39);
            this.btnEditQuantity.TabIndex = 4;
            this.btnEditQuantity.Text = "Edit Quantity";
            this.btnEditQuantity.UseVisualStyleBackColor = false;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click_1);
            // 
            // InventoryIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(936, 482);
            this.Controls.Add(this.btnEditQuantity);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.backToIM);
            this.Controls.Add(this.dataGridViewInventory);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "InventoryIM";
            this.Text = "InventoryIM";
            this.Load += new System.EventHandler(this.InventoryIM_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewInventory;
        private Button backToIM;
        private Button btnDeleteItem;
        private Button btnAddItem;
        private Button btnEditQuantity;
    }
}