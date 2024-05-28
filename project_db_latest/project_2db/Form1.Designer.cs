namespace project_2db
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentButton = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.StaffButton = new System.Windows.Forms.Button();
            this.buttonIM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentButton
            // 
            this.StudentButton.BackColor = System.Drawing.Color.MistyRose;
            this.StudentButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentButton.Location = new System.Drawing.Point(99, 312);
            this.StudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(144, 48);
            this.StudentButton.TabIndex = 2;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = false;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // ManagerButton
            // 
            this.ManagerButton.BackColor = System.Drawing.Color.MistyRose;
            this.ManagerButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManagerButton.Location = new System.Drawing.Point(302, 312);
            this.ManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(157, 48);
            this.ManagerButton.TabIndex = 3;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = false;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // StaffButton
            // 
            this.StaffButton.BackColor = System.Drawing.Color.MistyRose;
            this.StaffButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StaffButton.Location = new System.Drawing.Point(757, 312);
            this.StaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.StaffButton.Name = "StaffButton";
            this.StaffButton.Size = new System.Drawing.Size(155, 48);
            this.StaffButton.TabIndex = 4;
            this.StaffButton.Text = "Staff";
            this.StaffButton.UseVisualStyleBackColor = false;
            this.StaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // buttonIM
            // 
            this.buttonIM.BackColor = System.Drawing.Color.MistyRose;
            this.buttonIM.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIM.Location = new System.Drawing.Point(521, 312);
            this.buttonIM.Name = "buttonIM";
            this.buttonIM.Size = new System.Drawing.Size(186, 48);
            this.buttonIM.TabIndex = 5;
            this.buttonIM.Text = "Inventory Manager";
            this.buttonIM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIM.UseVisualStyleBackColor = false;
            this.buttonIM.Click += new System.EventHandler(this.buttonIM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Glasgow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(341, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 68);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_2db.Properties.Resources.cafe45;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.buttonIM);
            this.Controls.Add(this.StaffButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button StudentButton;
        private Button ManagerButton;
        private Button StaffButton;
        private Button buttonIM;
        private Label label2;
        private Label label1;
    }
}