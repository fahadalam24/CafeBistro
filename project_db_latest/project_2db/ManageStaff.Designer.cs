namespace project_2db
{
    partial class ManageStaff
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
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.fire = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.GridColor = System.Drawing.Color.RosyBrown;
            this.dataGridViewStaff.Location = new System.Drawing.Point(20, 81);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 62;
            this.dataGridViewStaff.RowTemplate.Height = 33;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1049, 324);
            this.dataGridViewStaff.TabIndex = 0;
            this.dataGridViewStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellContentClick);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.SeaShell;
            this.fire.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fire.ForeColor = System.Drawing.Color.IndianRed;
            this.fire.Location = new System.Drawing.Point(162, 422);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(204, 40);
            this.fire.TabIndex = 1;
            this.fire.Text = "Fire Staff Member";
            this.fire.UseVisualStyleBackColor = false;
            this.fire.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaShell;
            this.add.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.ForeColor = System.Drawing.Color.IndianRed;
            this.add.Location = new System.Drawing.Point(443, 422);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(218, 37);
            this.add.TabIndex = 2;
            this.add.Text = "Add Staff Member";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.SeaShell;
            this.update.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.Color.IndianRed;
            this.update.Location = new System.Drawing.Point(732, 423);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(203, 36);
            this.update.TabIndex = 3;
            this.update.Text = "Update Staff Info";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.IndianRed;
            this.button4.Location = new System.Drawing.Point(20, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1096, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.dataGridViewStaff);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "ManageStaff";
            this.Text = "ManageStaff";
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewStaff;
        private Button fire;
        private Button add;
        private Button update;
        private Button button4;
    }
}