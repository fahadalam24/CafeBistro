namespace project_2db
{
    partial class InventoryManagerMain
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
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glasgow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(249, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Glasgow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(249, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Glasgow", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(214, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Manager Login";
            // 
            // Usernametxt
            // 
            this.Usernametxt.BackColor = System.Drawing.Color.SeaShell;
            this.Usernametxt.ForeColor = System.Drawing.Color.IndianRed;
            this.Usernametxt.Location = new System.Drawing.Point(457, 182);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(187, 31);
            this.Usernametxt.TabIndex = 3;
            this.Usernametxt.TextChanged += new System.EventHandler(this.Usernametxt_TextChanged);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.SeaShell;
            this.Passwordtxt.ForeColor = System.Drawing.Color.IndianRed;
            this.Passwordtxt.Location = new System.Drawing.Point(457, 266);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(187, 31);
            this.Passwordtxt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(371, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(18, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InventoryManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(937, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryManagerMain";
            this.Text = "InventoryManagerMain";
            this.Load += new System.EventHandler(this.InventoryManagerMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Usernametxt;
        private TextBox Passwordtxt;
        private Button button1;
        private Button button2;
    }
}