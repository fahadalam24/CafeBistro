namespace project_2db
{
    partial class StudentMain
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(236, 113);
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
            this.label3.Location = new System.Drawing.Point(236, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.SeaShell;
            this.txtStudentID.Location = new System.Drawing.Point(371, 113);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(125, 27);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.SeaShell;
            this.txtPassword.Location = new System.Drawing.Point(371, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonLogin.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonLogin.Location = new System.Drawing.Point(388, 250);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 36);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCreateAccount.Location = new System.Drawing.Point(324, 377);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(194, 49);
            this.buttonCreateAccount.TabIndex = 6;
            this.buttonCreateAccount.Text = "CreateAccount";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(178, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create an account if you already don\'t have one!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentMain";
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtPassword;
        private Button buttonLogin;
        private Button buttonCreateAccount;
        private Label label4;
        private Button button1;
    }
}