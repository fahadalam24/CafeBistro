namespace project_2db
{
    partial class Menu
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.Proceed = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewMenu.Location = new System.Drawing.Point(75, 58);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 29;
            this.dataGridViewMenu.Size = new System.Drawing.Size(591, 228);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddToCart.Font = new System.Drawing.Font("Gill Sans MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddToCart.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAddToCart.Location = new System.Drawing.Point(680, 221);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(94, 45);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "AddToCart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // Cart
            // 
            this.Cart.AutoSize = true;
            this.Cart.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cart.ForeColor = System.Drawing.Color.RosyBrown;
            this.Cart.Location = new System.Drawing.Point(359, 9);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(91, 46);
            this.Cart.TabIndex = 3;
            this.Cart.Text = "Cart";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.BackColor = System.Drawing.Color.AntiqueWhite;
            this.numericUpDownQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(726, 93);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(40, 27);
            this.numericUpDownQuantity.TabIndex = 4;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewCart.Location = new System.Drawing.Point(147, 292);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 29;
            this.dataGridViewCart.Size = new System.Drawing.Size(361, 146);
            this.dataGridViewCart.TabIndex = 5;
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(542, 373);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(0, 20);
            this.Pricelabel.TabIndex = 6;
            this.Pricelabel.Click += new System.EventHandler(this.Pricelabel_Click);
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Proceed.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Proceed.ForeColor = System.Drawing.Color.IndianRed;
            this.Proceed.Location = new System.Drawing.Point(647, 362);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(127, 44);
            this.Proceed.TabIndex = 7;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 31);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewMenu;
        private Button btnAddToCart;
        private Label Cart;
        private NumericUpDown numericUpDownQuantity;
        private DataGridView dataGridViewCart;
        private Label Pricelabel;
        private Button Proceed;
        private Button backbtn;
    }
}