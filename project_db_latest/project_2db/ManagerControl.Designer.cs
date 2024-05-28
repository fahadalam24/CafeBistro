namespace project_2db
{
    partial class ManagerControl
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
            this.Invent = new System.Windows.Forms.Button();
            this.Staff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Invent
            // 
            this.Invent.BackColor = System.Drawing.Color.SeaShell;
            this.Invent.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Invent.ForeColor = System.Drawing.Color.IndianRed;
            this.Invent.Location = new System.Drawing.Point(335, 202);
            this.Invent.Name = "Invent";
            this.Invent.Size = new System.Drawing.Size(214, 52);
            this.Invent.TabIndex = 0;
            this.Invent.Text = "Manage Inventory";
            this.Invent.UseVisualStyleBackColor = false;
            this.Invent.Click += new System.EventHandler(this.Invent_Click);
            // 
            // Staff
            // 
            this.Staff.BackColor = System.Drawing.Color.SeaShell;
            this.Staff.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Staff.ForeColor = System.Drawing.Color.IndianRed;
            this.Staff.Location = new System.Drawing.Point(335, 280);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(214, 51);
            this.Staff.TabIndex = 1;
            this.Staff.Text = "Manage Staff";
            this.Staff.UseVisualStyleBackColor = false;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glasgow", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(236, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an Option";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(17, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(908, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Invent);
            this.Name = "ManagerControl";
            this.Text = "ManagerControl";
            this.Load += new System.EventHandler(this.ManagerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Invent;
        private Button Staff;
        private Label label1;
        private Button button1;
    }
}