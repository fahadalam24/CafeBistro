namespace project_2db
{
    partial class CashierLogin
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
            this.idtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(275, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Cashier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(139, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(139, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.SeaShell;
            this.idtxt.ForeColor = System.Drawing.Color.IndianRed;
            this.idtxt.Location = new System.Drawing.Point(326, 171);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(125, 27);
            this.idtxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.SeaShell;
            this.passwordtxt.ForeColor = System.Drawing.Color.IndianRed;
            this.passwordtxt.Location = new System.Drawing.Point(326, 232);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(125, 27);
            this.passwordtxt.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.login_btn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.login_btn.Location = new System.Drawing.Point(340, 315);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(94, 37);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.backbtn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.backbtn.Location = new System.Drawing.Point(23, 56);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 42);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // CashierLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashierLogin";
            this.Text = "CashierLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idtxt;
        private TextBox passwordtxt;
        private Button login_btn;
        private Button backbtn;
    }
}