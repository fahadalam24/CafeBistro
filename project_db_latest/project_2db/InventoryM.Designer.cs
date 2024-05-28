namespace project_2db
{
    partial class InventoryM
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
            this.backToManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(26, 63);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidth = 62;
            this.dataGridViewInventory.RowTemplate.Height = 33;
            this.dataGridViewInventory.Size = new System.Drawing.Size(714, 298);
            this.dataGridViewInventory.TabIndex = 0;
            this.dataGridViewInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventory_CellContentClick);
            // 
            // backToManager
            // 
            this.backToManager.BackColor = System.Drawing.Color.SeaShell;
            this.backToManager.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToManager.ForeColor = System.Drawing.Color.IndianRed;
            this.backToManager.Location = new System.Drawing.Point(26, 14);
            this.backToManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backToManager.Name = "backToManager";
            this.backToManager.Size = new System.Drawing.Size(112, 37);
            this.backToManager.TabIndex = 1;
            this.backToManager.Text = "Back";
            this.backToManager.UseVisualStyleBackColor = false;
            this.backToManager.Click += new System.EventHandler(this.backToManager_Click);
            // 
            // InventoryM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(757, 380);
            this.Controls.Add(this.backToManager);
            this.Controls.Add(this.dataGridViewInventory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryM";
            this.Text = "InventoryM";
            this.Load += new System.EventHandler(this.InventoryM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewInventory;
        private Button backToManager;
    }
}