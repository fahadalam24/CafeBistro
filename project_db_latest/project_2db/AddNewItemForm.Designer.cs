namespace project_2db
{
    partial class AddNewItemForm
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
            this.textBoxIngredientName = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMenuItemID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIngredientName
            // 
            this.textBoxIngredientName.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxIngredientName.Location = new System.Drawing.Point(250, 164);
            this.textBoxIngredientName.Name = "textBoxIngredientName";
            this.textBoxIngredientName.Size = new System.Drawing.Size(156, 31);
            this.textBoxIngredientName.TabIndex = 0;
            this.textBoxIngredientName.TextChanged += new System.EventHandler(this.textBoxIngredientName_TextChanged);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxQuantity.Location = new System.Drawing.Point(250, 235);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(156, 31);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxThreshold.Location = new System.Drawing.Point(689, 169);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(172, 31);
            this.textBoxThreshold.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glasgow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(45, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingredient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Glasgow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(45, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingredient Quanity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Glasgow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(463, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingredient Threshold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Glasgow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(463, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu Item ID";
            // 
            // textBoxMenuItemID
            // 
            this.textBoxMenuItemID.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxMenuItemID.Location = new System.Drawing.Point(689, 235);
            this.textBoxMenuItemID.Name = "textBoxMenuItemID";
            this.textBoxMenuItemID.Size = new System.Drawing.Size(172, 31);
            this.textBoxMenuItemID.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.SeaShell;
            this.btnOK.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.ForeColor = System.Drawing.Color.IndianRed;
            this.btnOK.Location = new System.Drawing.Point(237, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(145, 50);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Add";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(530, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Glasgow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(305, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 57);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add A New Item";
            // 
            // AddNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(935, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxMenuItemID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxThreshold);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxIngredientName);
            this.Name = "AddNewItemForm";
            this.Text = "AddNewItemForm";
            this.Load += new System.EventHandler(this.AddNewItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxIngredientName;
        private TextBox textBoxQuantity;
        private TextBox textBoxThreshold;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMenuItemID;
        private Button btnOK;
        private Button btnCancel;
        private Label label5;
    }
}