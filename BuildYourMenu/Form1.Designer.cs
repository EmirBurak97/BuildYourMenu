namespace BuildYourMenu
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
            gbxCategorySearch = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxNameSearch = new GroupBox();
            tbxProductName = new TextBox();
            lblProductName = new Label();
            dgwProducts = new DataGridView();
            gbxAddProduct = new GroupBox();
            btnAddProduct = new Button();
            cbxAddCategory = new ComboBox();
            tbxAddUnitPrice = new TextBox();
            lblAddUnitPrice = new Label();
            lblAddCategories = new Label();
            tbxAddProductName = new TextBox();
            lblAddProductName = new Label();
            gbxUpdateProduct = new GroupBox();
            btnUpdateProduct = new Button();
            cbxUpdateCategory = new ComboBox();
            tbxUpdateUnitPrice = new TextBox();
            lblUpdateUnitPrice = new Label();
            lblUpdateCategory = new Label();
            tbxUpdateProductName = new TextBox();
            lblUpdateProductName = new Label();
            btnDeleteProduct = new Button();
            gbxCategorySearch.SuspendLayout();
            gbxNameSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAddProduct.SuspendLayout();
            gbxUpdateProduct.SuspendLayout();
            SuspendLayout();
            // 
            // gbxCategorySearch
            // 
            gbxCategorySearch.Controls.Add(cbxCategory);
            gbxCategorySearch.Controls.Add(lblCategory);
            gbxCategorySearch.Location = new Point(12, 12);
            gbxCategorySearch.Name = "gbxCategorySearch";
            gbxCategorySearch.Size = new Size(480, 100);
            gbxCategorySearch.TabIndex = 0;
            gbxCategorySearch.TabStop = false;
            gbxCategorySearch.Text = "Ürün Kategorisine Göre Arama";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(72, 41);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(162, 23);
            cbxCategory.TabIndex = 1;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(6, 44);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(60, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategori : ";
            // 
            // gbxNameSearch
            // 
            gbxNameSearch.Controls.Add(tbxProductName);
            gbxNameSearch.Controls.Add(lblProductName);
            gbxNameSearch.Location = new Point(516, 12);
            gbxNameSearch.Name = "gbxNameSearch";
            gbxNameSearch.Size = new Size(480, 100);
            gbxNameSearch.TabIndex = 1;
            gbxNameSearch.TabStop = false;
            gbxNameSearch.Text = "Ürün Adına Göre Arama";
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(75, 41);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(162, 23);
            tbxProductName.TabIndex = 2;
            tbxProductName.TextChanged += tbxProductName_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 44);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(63, 15);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Ürün Adı : ";
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 118);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(984, 329);
            dgwProducts.TabIndex = 2;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // gbxAddProduct
            // 
            gbxAddProduct.Controls.Add(btnAddProduct);
            gbxAddProduct.Controls.Add(cbxAddCategory);
            gbxAddProduct.Controls.Add(tbxAddUnitPrice);
            gbxAddProduct.Controls.Add(lblAddUnitPrice);
            gbxAddProduct.Controls.Add(lblAddCategories);
            gbxAddProduct.Controls.Add(tbxAddProductName);
            gbxAddProduct.Controls.Add(lblAddProductName);
            gbxAddProduct.Location = new Point(12, 452);
            gbxAddProduct.Name = "gbxAddProduct";
            gbxAddProduct.Size = new Size(750, 125);
            gbxAddProduct.TabIndex = 3;
            gbxAddProduct.TabStop = false;
            gbxAddProduct.Text = "Ürün Ekle";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(642, 30);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(90, 64);
            btnAddProduct.TabIndex = 10;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // cbxAddCategory
            // 
            cbxAddCategory.FormattingEnabled = true;
            cbxAddCategory.Location = new Point(105, 71);
            cbxAddCategory.Name = "cbxAddCategory";
            cbxAddCategory.Size = new Size(162, 23);
            cbxAddCategory.TabIndex = 9;
            // 
            // tbxAddUnitPrice
            // 
            tbxAddUnitPrice.Location = new Point(454, 30);
            tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            tbxAddUnitPrice.Size = new Size(162, 23);
            tbxAddUnitPrice.TabIndex = 8;
            // 
            // lblAddUnitPrice
            // 
            lblAddUnitPrice.AutoSize = true;
            lblAddUnitPrice.Location = new Point(361, 33);
            lblAddUnitPrice.Name = "lblAddUnitPrice";
            lblAddUnitPrice.Size = new Size(87, 15);
            lblAddUnitPrice.TabIndex = 7;
            lblAddUnitPrice.Text = "Ürünün Fiyatı : ";
            // 
            // lblAddCategories
            // 
            lblAddCategories.AutoSize = true;
            lblAddCategories.Location = new Point(36, 74);
            lblAddCategories.Name = "lblAddCategories";
            lblAddCategories.Size = new Size(60, 15);
            lblAddCategories.TabIndex = 5;
            lblAddCategories.Text = "Kategori : ";
            // 
            // tbxAddProductName
            // 
            tbxAddProductName.Location = new Point(105, 30);
            tbxAddProductName.Name = "tbxAddProductName";
            tbxAddProductName.Size = new Size(162, 23);
            tbxAddProductName.TabIndex = 4;
            // 
            // lblAddProductName
            // 
            lblAddProductName.AutoSize = true;
            lblAddProductName.Location = new Point(36, 33);
            lblAddProductName.Name = "lblAddProductName";
            lblAddProductName.Size = new Size(63, 15);
            lblAddProductName.TabIndex = 3;
            lblAddProductName.Text = "Ürün Adı : ";
            // 
            // gbxUpdateProduct
            // 
            gbxUpdateProduct.Controls.Add(btnUpdateProduct);
            gbxUpdateProduct.Controls.Add(cbxUpdateCategory);
            gbxUpdateProduct.Controls.Add(tbxUpdateUnitPrice);
            gbxUpdateProduct.Controls.Add(lblUpdateUnitPrice);
            gbxUpdateProduct.Controls.Add(lblUpdateCategory);
            gbxUpdateProduct.Controls.Add(tbxUpdateProductName);
            gbxUpdateProduct.Controls.Add(lblUpdateProductName);
            gbxUpdateProduct.Location = new Point(12, 592);
            gbxUpdateProduct.Name = "gbxUpdateProduct";
            gbxUpdateProduct.Size = new Size(750, 125);
            gbxUpdateProduct.TabIndex = 4;
            gbxUpdateProduct.TabStop = false;
            gbxUpdateProduct.Text = "Ürünü Güncelle";
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(642, 32);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(90, 64);
            btnUpdateProduct.TabIndex = 11;
            btnUpdateProduct.Text = "Ürünü Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // cbxUpdateCategory
            // 
            cbxUpdateCategory.FormattingEnabled = true;
            cbxUpdateCategory.Location = new Point(105, 73);
            cbxUpdateCategory.Name = "cbxUpdateCategory";
            cbxUpdateCategory.Size = new Size(162, 23);
            cbxUpdateCategory.TabIndex = 15;
            // 
            // tbxUpdateUnitPrice
            // 
            tbxUpdateUnitPrice.Location = new Point(454, 32);
            tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            tbxUpdateUnitPrice.Size = new Size(162, 23);
            tbxUpdateUnitPrice.TabIndex = 14;
            // 
            // lblUpdateUnitPrice
            // 
            lblUpdateUnitPrice.AutoSize = true;
            lblUpdateUnitPrice.Location = new Point(361, 35);
            lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            lblUpdateUnitPrice.Size = new Size(87, 15);
            lblUpdateUnitPrice.TabIndex = 13;
            lblUpdateUnitPrice.Text = "Ürünün Fiyatı : ";
            // 
            // lblUpdateCategory
            // 
            lblUpdateCategory.AutoSize = true;
            lblUpdateCategory.Location = new Point(36, 76);
            lblUpdateCategory.Name = "lblUpdateCategory";
            lblUpdateCategory.Size = new Size(60, 15);
            lblUpdateCategory.TabIndex = 11;
            lblUpdateCategory.Text = "Kategori : ";
            // 
            // tbxUpdateProductName
            // 
            tbxUpdateProductName.Location = new Point(105, 32);
            tbxUpdateProductName.Name = "tbxUpdateProductName";
            tbxUpdateProductName.Size = new Size(162, 23);
            tbxUpdateProductName.TabIndex = 10;
            // 
            // lblUpdateProductName
            // 
            lblUpdateProductName.AutoSize = true;
            lblUpdateProductName.Location = new Point(36, 35);
            lblUpdateProductName.Name = "lblUpdateProductName";
            lblUpdateProductName.Size = new Size(63, 15);
            lblUpdateProductName.TabIndex = 9;
            lblUpdateProductName.Text = "Ürün Adı : ";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteProduct.Location = new Point(768, 460);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(228, 257);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Ürün Sil";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnDeleteProduct);
            Controls.Add(gbxUpdateProduct);
            Controls.Add(gbxAddProduct);
            Controls.Add(dgwProducts);
            Controls.Add(gbxNameSearch);
            Controls.Add(gbxCategorySearch);
            Name = "Form1";
            Text = "BuildYourMenu";
            Load += Form1_Load;
            gbxCategorySearch.ResumeLayout(false);
            gbxCategorySearch.PerformLayout();
            gbxNameSearch.ResumeLayout(false);
            gbxNameSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAddProduct.ResumeLayout(false);
            gbxAddProduct.PerformLayout();
            gbxUpdateProduct.ResumeLayout(false);
            gbxUpdateProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCategorySearch;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxNameSearch;
        private TextBox tbxProductName;
        private Label lblProductName;
        private DataGridView dgwProducts;
        private GroupBox gbxAddProduct;
        private GroupBox gbxUpdateProduct;
        private Button btnDeleteProduct;
        private ComboBox cbxAddCategory;
        private TextBox tbxAddUnitPrice;
        private Label lblAddUnitPrice;
        private Label lblAddCategories;
        private TextBox tbxAddProductName;
        private Label lblAddProductName;
        private ComboBox cbxUpdateCategory;
        private TextBox tbxUpdateUnitPrice;
        private Label lblUpdateUnitPrice;
        private Label lblUpdateCategory;
        private TextBox tbxUpdateProductName;
        private Label lblUpdateProductName;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
    }
}