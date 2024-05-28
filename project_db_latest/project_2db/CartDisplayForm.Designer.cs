namespace project_2db
{
    partial class CartDisplayForm
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
            this.dataGridView_cart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_label = new System.Windows.Forms.Label();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.checkout_btn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cart
            // 
            this.dataGridView_cart.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cart.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridView_cart.Location = new System.Drawing.Point(70, 102);
            this.dataGridView_cart.Name = "dataGridView_cart";
            this.dataGridView_cart.RowHeadersWidth = 51;
            this.dataGridView_cart.RowTemplate.Height = 29;
            this.dataGridView_cart.Size = new System.Drawing.Size(677, 223);
            this.dataGridView_cart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(296, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(25, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total in Rs:";
            // 
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total_label.ForeColor = System.Drawing.Color.RosyBrown;
            this.Total_label.Location = new System.Drawing.Point(196, 370);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(59, 25);
            this.Total_label.TabIndex = 3;
            this.Total_label.Text = "label3";
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.paymentComboBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentComboBox.ForeColor = System.Drawing.Color.IndianRed;
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(339, 362);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(187, 33);
            this.paymentComboBox.TabIndex = 4;
            // 
            // checkout_btn
            // 
            this.checkout_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.checkout_btn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkout_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.checkout_btn.Location = new System.Drawing.Point(657, 362);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(116, 38);
            this.checkout_btn.TabIndex = 5;
            this.checkout_btn.Text = "CheckOut";
            this.checkout_btn.UseVisualStyleBackColor = false;
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.backbtn.Location = new System.Drawing.Point(25, 46);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 39);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exitbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.exitbtn.Location = new System.Drawing.Point(679, 47);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(94, 38);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // CartDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_cart);
            this.Name = "CartDisplayForm";
            this.Text = "CartDisplayForm";
            this.Load += new System.EventHandler(this.CartDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_cart;
        private Label label1;
        private Label label2;
        private Label Total_label;
        private ComboBox paymentComboBox;
        private Button checkout_btn;
        private Button backbtn;
        private Button exitbtn;
    }
}