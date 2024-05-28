namespace project_2db
{
    partial class MenuManage
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
            this.dataGridViewMenuItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenuItems
            // 
            this.dataGridViewMenuItems.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenuItems.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewMenuItems.Location = new System.Drawing.Point(23, 91);
            this.dataGridViewMenuItems.Name = "dataGridViewMenuItems";
            this.dataGridViewMenuItems.RowHeadersWidth = 51;
            this.dataGridViewMenuItems.RowTemplate.Height = 29;
            this.dataGridViewMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenuItems.Size = new System.Drawing.Size(743, 261);
            this.dataGridViewMenuItems.TabIndex = 0;
            this.dataGridViewMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuItems_CellContentClick);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddItem.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAddItem.Location = new System.Drawing.Point(181, 409);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 29);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUpdateItem.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateItem.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUpdateItem.Location = new System.Drawing.Point(348, 409);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateItem.TabIndex = 2;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(238, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Item to Menu";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.removeBtn.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.removeBtn.Location = new System.Drawing.Point(518, 409);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(94, 29);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backbtn.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.backbtn.Location = new System.Drawing.Point(23, 33);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 29);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // MenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dataGridViewMenuItems);
            this.Name = "MenuManage";
            this.Text = "MenuManage";
            this.Load += new System.EventHandler(this.MenuManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewMenuItems;
        private Button btnAddItem;
        private Button btnUpdateItem;
        private Label label1;
        private Button removeBtn;
        private Button backbtn;
    }
}