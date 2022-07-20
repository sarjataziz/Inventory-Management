namespace Inventory_Management_Project.Presentation_Layer
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            this.ProductListGroupBox = new System.Windows.Forms.GroupBox();
            this.productListDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewProductListGroupBox = new System.Windows.Forms.GroupBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productPriceLebal = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.deleteProductroupBox = new System.Windows.Forms.GroupBox();
            this.deleteProductTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductIDLabel = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateProductIDTextBox = new System.Windows.Forms.TextBox();
            this.updateProductIDLabel = new System.Windows.Forms.Label();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.updateProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.updateProductCategoryLabel = new System.Windows.Forms.Label();
            this.updateProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.updatePriceLabel = new System.Windows.Forms.Label();
            this.updateProductNameTextBox = new System.Windows.Forms.TextBox();
            this.updateProductNameLabel = new System.Windows.Forms.Label();
            this.SearchGroupBoxOfProducts = new System.Windows.Forms.GroupBox();
            this.SearchProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchProductsTextBox = new System.Windows.Forms.TextBox();
            this.LabelOfSearchProductsName = new System.Windows.Forms.Label();
            this.ProductsBackButton = new System.Windows.Forms.Button();
            this.ProductListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
            this.addNewProductListGroupBox.SuspendLayout();
            this.deleteProductroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SearchGroupBoxOfProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductListGroupBox
            // 
            this.ProductListGroupBox.Controls.Add(this.productListDataGridView);
            this.ProductListGroupBox.Location = new System.Drawing.Point(597, 12);
            this.ProductListGroupBox.Name = "ProductListGroupBox";
            this.ProductListGroupBox.Size = new System.Drawing.Size(509, 332);
            this.ProductListGroupBox.TabIndex = 0;
            this.ProductListGroupBox.TabStop = false;
            this.ProductListGroupBox.Text = "Product List";
            // 
            // productListDataGridView
            // 
            this.productListDataGridView.AllowUserToAddRows = false;
            this.productListDataGridView.AllowUserToDeleteRows = false;
            this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListDataGridView.Location = new System.Drawing.Point(27, 36);
            this.productListDataGridView.Name = "productListDataGridView";
            this.productListDataGridView.ReadOnly = true;
            this.productListDataGridView.Size = new System.Drawing.Size(455, 272);
            this.productListDataGridView.TabIndex = 0;
            this.productListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productListDataGridView_CellClick);
            this.productListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productListDataGridView_CellContentClick);
            // 
            // addNewProductListGroupBox
            // 
            this.addNewProductListGroupBox.Controls.Add(this.addProductButton);
            this.addNewProductListGroupBox.Controls.Add(this.addCategoryComboBox);
            this.addNewProductListGroupBox.Controls.Add(this.productCategoryLabel);
            this.addNewProductListGroupBox.Controls.Add(this.productPriceTextBox);
            this.addNewProductListGroupBox.Controls.Add(this.productPriceLebal);
            this.addNewProductListGroupBox.Controls.Add(this.productNameTextBox);
            this.addNewProductListGroupBox.Controls.Add(this.productNameLabel);
            this.addNewProductListGroupBox.Location = new System.Drawing.Point(24, 12);
            this.addNewProductListGroupBox.Name = "addNewProductListGroupBox";
            this.addNewProductListGroupBox.Size = new System.Drawing.Size(531, 188);
            this.addNewProductListGroupBox.TabIndex = 1;
            this.addNewProductListGroupBox.TabStop = false;
            this.addNewProductListGroupBox.Text = "Add New Products";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(153, 156);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(335, 34);
            this.addProductButton.TabIndex = 6;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.Location = new System.Drawing.Point(153, 122);
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(335, 27);
            this.addCategoryComboBox.TabIndex = 5;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(29, 125);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(71, 19);
            this.productCategoryLabel.TabIndex = 4;
            this.productCategoryLabel.Text = "Category";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(153, 82);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(335, 26);
            this.productPriceTextBox.TabIndex = 3;
            // 
            // productPriceLebal
            // 
            this.productPriceLebal.AutoSize = true;
            this.productPriceLebal.Location = new System.Drawing.Point(29, 85);
            this.productPriceLebal.Name = "productPriceLebal";
            this.productPriceLebal.Size = new System.Drawing.Size(43, 19);
            this.productPriceLebal.TabIndex = 2;
            this.productPriceLebal.Text = "Price";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(153, 44);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(335, 26);
            this.productNameTextBox.TabIndex = 1;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(29, 47);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(104, 19);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name";
            // 
            // deleteProductroupBox
            // 
            this.deleteProductroupBox.Controls.Add(this.deleteProductTextBox);
            this.deleteProductroupBox.Controls.Add(this.deleteProductIDLabel);
            this.deleteProductroupBox.Controls.Add(this.deleteProductButton);
            this.deleteProductroupBox.Location = new System.Drawing.Point(24, 234);
            this.deleteProductroupBox.Name = "deleteProductroupBox";
            this.deleteProductroupBox.Size = new System.Drawing.Size(531, 151);
            this.deleteProductroupBox.TabIndex = 2;
            this.deleteProductroupBox.TabStop = false;
            this.deleteProductroupBox.Text = "Delete Product";
            // 
            // deleteProductTextBox
            // 
            this.deleteProductTextBox.Location = new System.Drawing.Point(153, 43);
            this.deleteProductTextBox.Name = "deleteProductTextBox";
            this.deleteProductTextBox.Size = new System.Drawing.Size(335, 26);
            this.deleteProductTextBox.TabIndex = 2;
            // 
            // deleteProductIDLabel
            // 
            this.deleteProductIDLabel.AutoSize = true;
            this.deleteProductIDLabel.Location = new System.Drawing.Point(29, 43);
            this.deleteProductIDLabel.Name = "deleteProductIDLabel";
            this.deleteProductIDLabel.Size = new System.Drawing.Size(82, 19);
            this.deleteProductIDLabel.TabIndex = 1;
            this.deleteProductIDLabel.Text = "Product ID";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(153, 90);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(335, 32);
            this.deleteProductButton.TabIndex = 0;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateProductIDTextBox);
            this.groupBox1.Controls.Add(this.updateProductIDLabel);
            this.groupBox1.Controls.Add(this.updateProductButton);
            this.groupBox1.Controls.Add(this.updateProductCategoryComboBox);
            this.groupBox1.Controls.Add(this.updateProductCategoryLabel);
            this.groupBox1.Controls.Add(this.updateProductPriceTextBox);
            this.groupBox1.Controls.Add(this.updatePriceLabel);
            this.groupBox1.Controls.Add(this.updateProductNameTextBox);
            this.groupBox1.Controls.Add(this.updateProductNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 270);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Updates Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // updateProductIDTextBox
            // 
            this.updateProductIDTextBox.Location = new System.Drawing.Point(153, 51);
            this.updateProductIDTextBox.Name = "updateProductIDTextBox";
            this.updateProductIDTextBox.Size = new System.Drawing.Size(335, 26);
            this.updateProductIDTextBox.TabIndex = 8;
            // 
            // updateProductIDLabel
            // 
            this.updateProductIDLabel.AutoSize = true;
            this.updateProductIDLabel.Location = new System.Drawing.Point(29, 51);
            this.updateProductIDLabel.Name = "updateProductIDLabel";
            this.updateProductIDLabel.Size = new System.Drawing.Size(82, 19);
            this.updateProductIDLabel.TabIndex = 7;
            this.updateProductIDLabel.Text = "Product ID";
            // 
            // updateProductButton
            // 
            this.updateProductButton.Location = new System.Drawing.Point(153, 207);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(335, 34);
            this.updateProductButton.TabIndex = 6;
            this.updateProductButton.Text = "Update";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // updateProductCategoryComboBox
            // 
            this.updateProductCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateProductCategoryComboBox.FormattingEnabled = true;
            this.updateProductCategoryComboBox.Location = new System.Drawing.Point(153, 173);
            this.updateProductCategoryComboBox.Name = "updateProductCategoryComboBox";
            this.updateProductCategoryComboBox.Size = new System.Drawing.Size(335, 27);
            this.updateProductCategoryComboBox.TabIndex = 5;
            // 
            // updateProductCategoryLabel
            // 
            this.updateProductCategoryLabel.AutoSize = true;
            this.updateProductCategoryLabel.Location = new System.Drawing.Point(29, 176);
            this.updateProductCategoryLabel.Name = "updateProductCategoryLabel";
            this.updateProductCategoryLabel.Size = new System.Drawing.Size(71, 19);
            this.updateProductCategoryLabel.TabIndex = 4;
            this.updateProductCategoryLabel.Text = "Category";
            // 
            // updateProductPriceTextBox
            // 
            this.updateProductPriceTextBox.Location = new System.Drawing.Point(153, 133);
            this.updateProductPriceTextBox.Name = "updateProductPriceTextBox";
            this.updateProductPriceTextBox.Size = new System.Drawing.Size(335, 26);
            this.updateProductPriceTextBox.TabIndex = 3;
            // 
            // updatePriceLabel
            // 
            this.updatePriceLabel.AutoSize = true;
            this.updatePriceLabel.Location = new System.Drawing.Point(29, 136);
            this.updatePriceLabel.Name = "updatePriceLabel";
            this.updatePriceLabel.Size = new System.Drawing.Size(43, 19);
            this.updatePriceLabel.TabIndex = 2;
            this.updatePriceLabel.Text = "Price";
            // 
            // updateProductNameTextBox
            // 
            this.updateProductNameTextBox.Location = new System.Drawing.Point(153, 95);
            this.updateProductNameTextBox.Name = "updateProductNameTextBox";
            this.updateProductNameTextBox.Size = new System.Drawing.Size(335, 26);
            this.updateProductNameTextBox.TabIndex = 1;
            // 
            // updateProductNameLabel
            // 
            this.updateProductNameLabel.AutoSize = true;
            this.updateProductNameLabel.Location = new System.Drawing.Point(29, 98);
            this.updateProductNameLabel.Name = "updateProductNameLabel";
            this.updateProductNameLabel.Size = new System.Drawing.Size(104, 19);
            this.updateProductNameLabel.TabIndex = 0;
            this.updateProductNameLabel.Text = "Product Name";
            // 
            // SearchGroupBoxOfProducts
            // 
            this.SearchGroupBoxOfProducts.Controls.Add(this.SearchProductsTextBox);
            this.SearchGroupBoxOfProducts.Controls.Add(this.LabelOfSearchProductsName);
            this.SearchGroupBoxOfProducts.Controls.Add(this.SearchProductsDataGridView);
            this.SearchGroupBoxOfProducts.Location = new System.Drawing.Point(597, 350);
            this.SearchGroupBoxOfProducts.Name = "SearchGroupBoxOfProducts";
            this.SearchGroupBoxOfProducts.Size = new System.Drawing.Size(509, 344);
            this.SearchGroupBoxOfProducts.TabIndex = 1;
            this.SearchGroupBoxOfProducts.TabStop = false;
            this.SearchGroupBoxOfProducts.Text = "Search Products";
            // 
            // SearchProductsDataGridView
            // 
            this.SearchProductsDataGridView.AllowUserToAddRows = false;
            this.SearchProductsDataGridView.AllowUserToDeleteRows = false;
            this.SearchProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchProductsDataGridView.Location = new System.Drawing.Point(27, 113);
            this.SearchProductsDataGridView.Name = "SearchProductsDataGridView";
            this.SearchProductsDataGridView.ReadOnly = true;
            this.SearchProductsDataGridView.Size = new System.Drawing.Size(455, 211);
            this.SearchProductsDataGridView.TabIndex = 0;
            // 
            // SearchProductsTextBox
            // 
            this.SearchProductsTextBox.Location = new System.Drawing.Point(147, 69);
            this.SearchProductsTextBox.Name = "SearchProductsTextBox";
            this.SearchProductsTextBox.Size = new System.Drawing.Size(335, 26);
            this.SearchProductsTextBox.TabIndex = 3;
            this.SearchProductsTextBox.TextChanged += new System.EventHandler(this.SearchProductsTextBox_TextChanged);
            // 
            // LabelOfSearchProductsName
            // 
            this.LabelOfSearchProductsName.AutoSize = true;
            this.LabelOfSearchProductsName.Location = new System.Drawing.Point(23, 72);
            this.LabelOfSearchProductsName.Name = "LabelOfSearchProductsName";
            this.LabelOfSearchProductsName.Size = new System.Drawing.Size(104, 19);
            this.LabelOfSearchProductsName.TabIndex = 2;
            this.LabelOfSearchProductsName.Text = "Product Name";
            // 
            // ProductsBackButton
            // 
            this.ProductsBackButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ProductsBackButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductsBackButton.Image")));
            this.ProductsBackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBackButton.Location = new System.Drawing.Point(72, 703);
            this.ProductsBackButton.Name = "ProductsBackButton";
            this.ProductsBackButton.Size = new System.Drawing.Size(105, 34);
            this.ProductsBackButton.TabIndex = 9;
            this.ProductsBackButton.Text = "Back";
            this.ProductsBackButton.UseVisualStyleBackColor = false;
            // 
            // ManageProducts
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 765);
            this.Controls.Add(this.ProductsBackButton);
            this.Controls.Add(this.SearchGroupBoxOfProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteProductroupBox);
            this.Controls.Add(this.addNewProductListGroupBox);
            this.Controls.Add(this.ProductListGroupBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageProducts_FormClosing);
            this.ProductListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
            this.addNewProductListGroupBox.ResumeLayout(false);
            this.addNewProductListGroupBox.PerformLayout();
            this.deleteProductroupBox.ResumeLayout(false);
            this.deleteProductroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SearchGroupBoxOfProducts.ResumeLayout(false);
            this.SearchGroupBoxOfProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductListGroupBox;
        private System.Windows.Forms.DataGridView productListDataGridView;
        private System.Windows.Forms.GroupBox addNewProductListGroupBox;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label productPriceLebal;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.GroupBox deleteProductroupBox;
        private System.Windows.Forms.TextBox deleteProductTextBox;
        private System.Windows.Forms.Label deleteProductIDLabel;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox updateProductIDTextBox;
        private System.Windows.Forms.Label updateProductIDLabel;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.ComboBox updateProductCategoryComboBox;
        private System.Windows.Forms.Label updateProductCategoryLabel;
        private System.Windows.Forms.TextBox updateProductPriceTextBox;
        private System.Windows.Forms.Label updatePriceLabel;
        private System.Windows.Forms.TextBox updateProductNameTextBox;
        private System.Windows.Forms.Label updateProductNameLabel;
        private System.Windows.Forms.GroupBox SearchGroupBoxOfProducts;
        private System.Windows.Forms.DataGridView SearchProductsDataGridView;
        private System.Windows.Forms.TextBox SearchProductsTextBox;
        private System.Windows.Forms.Label LabelOfSearchProductsName;
        private System.Windows.Forms.Button ProductsBackButton;
    }
}