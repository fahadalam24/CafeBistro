namespace project_2db
{
    partial class CashierForm
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
            this.Studentidtxt = new System.Windows.Forms.TextBox();
            this.Payabletxt = new System.Windows.Forms.TextBox();
            this.recievedtxt = new System.Windows.Forms.TextBox();
            this.ProcessPaymentbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(291, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(133, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "StudentID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(133, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "AmountPayable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(133, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "AmountRecieved";
            // 
            // Studentidtxt
            // 
            this.Studentidtxt.BackColor = System.Drawing.Color.SeaShell;
            this.Studentidtxt.Location = new System.Drawing.Point(328, 146);
            this.Studentidtxt.Name = "Studentidtxt";
            this.Studentidtxt.Size = new System.Drawing.Size(125, 27);
            this.Studentidtxt.TabIndex = 4;
            // 
            // Payabletxt
            // 
            this.Payabletxt.BackColor = System.Drawing.Color.SeaShell;
            this.Payabletxt.Location = new System.Drawing.Point(328, 226);
            this.Payabletxt.Name = "Payabletxt";
            this.Payabletxt.Size = new System.Drawing.Size(125, 27);
            this.Payabletxt.TabIndex = 5;
            // 
            // recievedtxt
            // 
            this.recievedtxt.BackColor = System.Drawing.Color.SeaShell;
            this.recievedtxt.Location = new System.Drawing.Point(328, 299);
            this.recievedtxt.Name = "recievedtxt";
            this.recievedtxt.Size = new System.Drawing.Size(125, 27);
            this.recievedtxt.TabIndex = 6;
            this.recievedtxt.TextChanged += new System.EventHandler(this.recievedtxt_TextChanged);
            // 
            // ProcessPaymentbtn
            // 
            this.ProcessPaymentbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ProcessPaymentbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcessPaymentbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.ProcessPaymentbtn.Location = new System.Drawing.Point(587, 306);
            this.ProcessPaymentbtn.Name = "ProcessPaymentbtn";
            this.ProcessPaymentbtn.Size = new System.Drawing.Size(129, 39);
            this.ProcessPaymentbtn.TabIndex = 7;
            this.ProcessPaymentbtn.Text = "ProcessPayment";
            this.ProcessPaymentbtn.UseVisualStyleBackColor = false;
            this.ProcessPaymentbtn.Click += new System.EventHandler(this.ProcessPaymentbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.backbtn.Location = new System.Drawing.Point(33, 53);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 38);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.ProcessPaymentbtn);
            this.Controls.Add(this.recievedtxt);
            this.Controls.Add(this.Payabletxt);
            this.Controls.Add(this.Studentidtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Studentidtxt;
        private TextBox Payabletxt;
        private TextBox recievedtxt;
        private Button ProcessPaymentbtn;
        private Button backbtn;
    }
}