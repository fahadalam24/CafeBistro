namespace project_2db
{
    partial class EditQuantityForm
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
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelIngredientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.ForeColor = System.Drawing.Color.RosyBrown;
            this.numericUpDownQuantity.Location = new System.Drawing.Point(512, 182);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(186, 31);
            this.numericUpDownQuantity.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.SeaShell;
            this.btnOK.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.ForeColor = System.Drawing.Color.IndianRed;
            this.btnOK.Location = new System.Drawing.Point(107, 378);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(134, 45);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(690, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Font = new System.Drawing.Font("Glasgow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIngredientName.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelIngredientName.Location = new System.Drawing.Point(231, 182);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(107, 29);
            this.labelIngredientName.TabIndex = 3;
            this.labelIngredientName.Text = "Ingredient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Glasgow", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(311, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Quantity";
            // 
            // EditQuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(902, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIngredientName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Name = "EditQuantityForm";
            this.Text = "EditQuantityForm";
            this.Load += new System.EventHandler(this.EditQuantityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownQuantity;
        private Button btnOK;
        private Button btnCancel;
        private Label labelIngredientName;
        private Label label1;
    }
}