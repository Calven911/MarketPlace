namespace MarketPlace
{
    partial class MarketPlace_Dashboard
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
            panel1 = new Panel();
            Login = new Button();
            Sale = new Button();
            Shop_All = new Button();
            search = new Button();
            Vendor = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Suppliers = new Button();
            Add_Product = new Button();
            Inventory = new Button();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colSold = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Login);
            panel1.Controls.Add(Sale);
            panel1.Controls.Add(Shop_All);
            panel1.Controls.Add(search);
            panel1.Controls.Add(Vendor);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            Login.BackColor = Color.Gold;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Login.Location = new Point(912, 43);
            Login.Name = "Login";
            Login.Size = new Size(80, 28);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button1_Click_1;
            // 
            // Sale
            // 
            Sale.BackColor = Color.Gold;
            Sale.FlatAppearance.BorderSize = 0;
            Sale.FlatStyle = FlatStyle.Flat;
            Sale.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Sale.Location = new Point(98, 46);
            Sale.Name = "Sale";
            Sale.Size = new Size(80, 28);
            Sale.TabIndex = 5;
            Sale.Text = "Sale";
            Sale.UseVisualStyleBackColor = false;
            // 
            // Shop_All
            // 
            Shop_All.BackColor = Color.Gold;
            Shop_All.FlatAppearance.BorderSize = 0;
            Shop_All.FlatStyle = FlatStyle.Flat;
            Shop_All.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Shop_All.Location = new Point(12, 46);
            Shop_All.Name = "Shop_All";
            Shop_All.Size = new Size(80, 28);
            Shop_All.TabIndex = 4;
            Shop_All.Text = "Shop All";
            Shop_All.UseVisualStyleBackColor = false;
            Shop_All.Click += button2_Click;
            // 
            // search
            // 
            search.BackColor = Color.Gold;
            search.FlatAppearance.BorderSize = 0;
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.Location = new Point(912, 8);
            search.Name = "search";
            search.Size = new Size(87, 29);
            search.TabIndex = 1;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += button1_Click;
            // 
            // Vendor
            // 
            Vendor.AutoSize = true;
            Vendor.BackColor = Color.Black;
            Vendor.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vendor.ForeColor = Color.Transparent;
            Vendor.Location = new Point(12, 11);
            Vendor.Name = "Vendor";
            Vendor.Size = new Size(80, 26);
            Vendor.TabIndex = 1;
            Vendor.Text = "Vendor";
            Vendor.Click += Vendor_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(96, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(819, 29);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 0);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1014, 50);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Suppliers);
            panel4.Controls.Add(Add_Product);
            panel4.Controls.Add(Inventory);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 433);
            panel4.TabIndex = 3;
            // 
            // Suppliers
            // 
            Suppliers.Dock = DockStyle.Top;
            Suppliers.FlatAppearance.BorderSize = 0;
            Suppliers.FlatStyle = FlatStyle.Flat;
            Suppliers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Suppliers.Location = new Point(0, 90);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(180, 45);
            Suppliers.TabIndex = 7;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = true;
            Suppliers.Click += button1_Click_2;
            // 
            // Add_Product
            // 
            Add_Product.Dock = DockStyle.Top;
            Add_Product.FlatAppearance.BorderSize = 0;
            Add_Product.FlatStyle = FlatStyle.Flat;
            Add_Product.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Product.Location = new Point(0, 45);
            Add_Product.Name = "Add_Product";
            Add_Product.Size = new Size(180, 45);
            Add_Product.TabIndex = 5;
            Add_Product.Text = "Add Product";
            Add_Product.UseVisualStyleBackColor = true;
            Add_Product.Click += Product_Catalog_Click;
            // 
            // Inventory
            // 
            Inventory.Dock = DockStyle.Top;
            Inventory.FlatAppearance.BorderSize = 0;
            Inventory.FlatStyle = FlatStyle.Flat;
            Inventory.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inventory.Location = new Point(0, 0);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(180, 45);
            Inventory.TabIndex = 4;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colPrice, colSold, colStatus });
            dataGridView1.Location = new Point(165, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(834, 433);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colName.HeaderText = "Product Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            colName.Width = 158;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Resizable = DataGridViewTriState.False;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Resizable = DataGridViewTriState.False;
            // 
            // colSold
            // 
            colSold.HeaderText = "Sold";
            colSold.Name = "colSold";
            colSold.ReadOnly = true;
            colSold.Resizable = DataGridViewTriState.False;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Resizable = DataGridViewTriState.False;
            // 
            // MarketPlace_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 513);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MarketPlace_Dashboard";
            Text = "MarketPlace Dashboard";
            Load += MarketPlace_Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label Vendor;
        private Button search;
        private Panel panel2;
        private Panel panel3;
        private Button Shop_All;
        private Button Sale;
        private Button Login;
        private Panel panel4;
        private Button Inventory;
        private Button Suppliers;
        private Button Add_Product;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colSold;
        private DataGridViewTextBoxColumn colStatus;
    }
}
