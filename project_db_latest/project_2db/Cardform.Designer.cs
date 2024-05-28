namespace project_2db
{
    partial class Cardform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardHoldertxt = new System.Windows.Forms.TextBox();
            this.cardNumbertxt = new System.Windows.Forms.TextBox();
            this.Cvvtxt = new System.Windows.Forms.TextBox();
            this.BillingAddresstxt = new System.Windows.Forms.TextBox();
            this.pay_button = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(211, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Payment Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(170, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "CardNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(170, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "CVV(3digit)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(172, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Billing Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(170, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "CardHolder\'s Name";
            // 
            // cardHoldertxt
            // 
            this.cardHoldertxt.BackColor = System.Drawing.Color.SeaShell;
            this.cardHoldertxt.Location = new System.Drawing.Point(408, 127);
            this.cardHoldertxt.Name = "cardHoldertxt";
            this.cardHoldertxt.Size = new System.Drawing.Size(125, 27);
            this.cardHoldertxt.TabIndex = 5;
            // 
            // cardNumbertxt
            // 
            this.cardNumbertxt.BackColor = System.Drawing.Color.SeaShell;
            this.cardNumbertxt.Location = new System.Drawing.Point(408, 176);
            this.cardNumbertxt.Name = "cardNumbertxt";
            this.cardNumbertxt.Size = new System.Drawing.Size(125, 27);
            this.cardNumbertxt.TabIndex = 6;
            // 
            // Cvvtxt
            // 
            this.Cvvtxt.BackColor = System.Drawing.Color.SeaShell;
            this.Cvvtxt.Location = new System.Drawing.Point(408, 235);
            this.Cvvtxt.Name = "Cvvtxt";
            this.Cvvtxt.Size = new System.Drawing.Size(125, 27);
            this.Cvvtxt.TabIndex = 7;
            // 
            // BillingAddresstxt
            // 
            this.BillingAddresstxt.BackColor = System.Drawing.Color.SeaShell;
            this.BillingAddresstxt.Location = new System.Drawing.Point(408, 297);
            this.BillingAddresstxt.Name = "BillingAddresstxt";
            this.BillingAddresstxt.Size = new System.Drawing.Size(125, 27);
            this.BillingAddresstxt.TabIndex = 8;
            // 
            // pay_button
            // 
            this.pay_button.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pay_button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pay_button.ForeColor = System.Drawing.Color.IndianRed;
            this.pay_button.Location = new System.Drawing.Point(356, 388);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(94, 42);
            this.pay_button.TabIndex = 9;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = false;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.backbtn.Location = new System.Drawing.Point(12, 37);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 40);
            this.backbtn.TabIndex = 10;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Cardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.BillingAddresstxt);
            this.Controls.Add(this.Cvvtxt);
            this.Controls.Add(this.cardNumbertxt);
            this.Controls.Add(this.cardHoldertxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cardform";
            this.Text = "Cardform";
            this.Load += new System.EventHandler(this.Cardform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cardHoldertxt;
        private TextBox cardNumbertxt;
        private TextBox Cvvtxt;
        private TextBox BillingAddresstxt;
        private Button pay_button;
        private Button backbtn;
    }
}