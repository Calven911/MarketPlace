namespace MarketPlace
{
    partial class Form2
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
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtSold = new TextBox();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 38);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(103, 23);
            txtProductName.TabIndex = 0;
            txtProductName.Text = "Product Name:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(12, 67);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(103, 23);
            txtCategory.TabIndex = 1;
            txtCategory.Text = "Category:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(103, 23);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "Price:";
            // 
            // txtSold
            // 
            txtSold.Location = new Point(12, 125);
            txtSold.Name = "txtSold";
            txtSold.Size = new Size(103, 23);
            txtSold.TabIndex = 3;
            txtSold.Text = "Sold:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 512);
            Controls.Add(txtSold);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtSold;
    }
}