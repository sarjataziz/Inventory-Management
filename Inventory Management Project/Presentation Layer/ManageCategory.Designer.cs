namespace Inventory_Management_Project.Presentation_Layer
{
    partial class ManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            this.categoryList1 = new System.Windows.Forms.GroupBox();
            this.categoryListDataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNewCategoryGroupBox1 = new System.Windows.Forms.GroupBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryNameTextBox1 = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryDeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryTextBox2 = new System.Windows.Forms.TextBox();
            this.categoryDeleteLabel = new System.Windows.Forms.Label();
            this.updateCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.searchCategoryButton = new System.Windows.Forms.Button();
            this.searchCategoryTextBox = new System.Windows.Forms.TextBox();
            this.searchCategoryLabel = new System.Windows.Forms.Label();
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.updateCetegoryTextBox = new System.Windows.Forms.TextBox();
            this.updateCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryWiseGroupBox = new System.Windows.Forms.GroupBox();
            this.selectCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.selectCategoryListProductDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.categoryList1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView1)).BeginInit();
            this.addNewCategoryGroupBox1.SuspendLayout();
            this.categoryDeleteGroupBox.SuspendLayout();
            this.updateCategoryGroupBox.SuspendLayout();
            this.CategoryWiseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectCategoryListProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryList1
            // 
            this.categoryList1.BackColor = System.Drawing.Color.LightGray;
            this.categoryList1.Controls.Add(this.categoryListDataGridView1);
            this.categoryList1.Location = new System.Drawing.Point(712, 21);
            this.categoryList1.Name = "categoryList1";
            this.categoryList1.Size = new System.Drawing.Size(421, 256);
            this.categoryList1.TabIndex = 0;
            this.categoryList1.TabStop = false;
            this.categoryList1.Text = "Category List";
            // 
            // categoryListDataGridView1
            // 
            this.categoryListDataGridView1.AllowUserToAddRows = false;
            this.categoryListDataGridView1.AllowUserToDeleteRows = false;
            this.categoryListDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryListDataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryListDataGridView1.Location = new System.Drawing.Point(41, 38);
            this.categoryListDataGridView1.Name = "categoryListDataGridView1";
            this.categoryListDataGridView1.ReadOnly = true;
            this.categoryListDataGridView1.Size = new System.Drawing.Size(335, 184);
            this.categoryListDataGridView1.TabIndex = 0;
            this.categoryListDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryListDataGridView1_CellContentClick);
            // 
            // addNewCategoryGroupBox1
            // 
            this.addNewCategoryGroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.addNewCategoryGroupBox1.Controls.Add(this.addCategoryButton);
            this.addNewCategoryGroupBox1.Controls.Add(this.addCategoryNameTextBox1);
            this.addNewCategoryGroupBox1.Controls.Add(this.categoryNameLabel);
            this.addNewCategoryGroupBox1.Location = new System.Drawing.Point(52, 21);
            this.addNewCategoryGroupBox1.Name = "addNewCategoryGroupBox1";
            this.addNewCategoryGroupBox1.Size = new System.Drawing.Size(538, 184);
            this.addNewCategoryGroupBox1.TabIndex = 1;
            this.addNewCategoryGroupBox1.TabStop = false;
            this.addNewCategoryGroupBox1.Text = "Add New Category";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(173, 112);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(318, 33);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addCategoryNameTextBox1
            // 
            this.addCategoryNameTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addCategoryNameTextBox1.Location = new System.Drawing.Point(173, 53);
            this.addCategoryNameTextBox1.Name = "addCategoryNameTextBox1";
            this.addCategoryNameTextBox1.Size = new System.Drawing.Size(318, 26);
            this.addCategoryNameTextBox1.TabIndex = 1;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(21, 53);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(124, 19);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "Category Name: ";
            this.categoryNameLabel.Click += new System.EventHandler(this.categoryNameLabel_Click);
            // 
            // categoryDeleteGroupBox
            // 
            this.categoryDeleteGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryDeleteGroupBox.Controls.Add(this.deleteCategoryButton);
            this.categoryDeleteGroupBox.Controls.Add(this.deleteCategoryTextBox2);
            this.categoryDeleteGroupBox.Controls.Add(this.categoryDeleteLabel);
            this.categoryDeleteGroupBox.Location = new System.Drawing.Point(52, 211);
            this.categoryDeleteGroupBox.Name = "categoryDeleteGroupBox";
            this.categoryDeleteGroupBox.Size = new System.Drawing.Size(538, 208);
            this.categoryDeleteGroupBox.TabIndex = 2;
            this.categoryDeleteGroupBox.TabStop = false;
            this.categoryDeleteGroupBox.Text = "Delete Category";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(173, 120);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(318, 33);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Delete Category";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // deleteCategoryTextBox2
            // 
            this.deleteCategoryTextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteCategoryTextBox2.Location = new System.Drawing.Point(173, 56);
            this.deleteCategoryTextBox2.Name = "deleteCategoryTextBox2";
            this.deleteCategoryTextBox2.Size = new System.Drawing.Size(318, 26);
            this.deleteCategoryTextBox2.TabIndex = 1;
            // 
            // categoryDeleteLabel
            // 
            this.categoryDeleteLabel.AutoSize = true;
            this.categoryDeleteLabel.Location = new System.Drawing.Point(43, 59);
            this.categoryDeleteLabel.Name = "categoryDeleteLabel";
            this.categoryDeleteLabel.Size = new System.Drawing.Size(102, 19);
            this.categoryDeleteLabel.TabIndex = 0;
            this.categoryDeleteLabel.Text = "Category ID: ";
            // 
            // updateCategoryGroupBox
            // 
            this.updateCategoryGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.updateCategoryGroupBox.Controls.Add(this.searchCategoryButton);
            this.updateCategoryGroupBox.Controls.Add(this.searchCategoryTextBox);
            this.updateCategoryGroupBox.Controls.Add(this.searchCategoryLabel);
            this.updateCategoryGroupBox.Controls.Add(this.updateCategoryButton);
            this.updateCategoryGroupBox.Controls.Add(this.updateCetegoryTextBox);
            this.updateCategoryGroupBox.Controls.Add(this.updateCategoryLabel);
            this.updateCategoryGroupBox.Location = new System.Drawing.Point(52, 425);
            this.updateCategoryGroupBox.Name = "updateCategoryGroupBox";
            this.updateCategoryGroupBox.Size = new System.Drawing.Size(538, 208);
            this.updateCategoryGroupBox.TabIndex = 3;
            this.updateCategoryGroupBox.TabStop = false;
            this.updateCategoryGroupBox.Text = "Update Category";
            // 
            // searchCategoryButton
            // 
            this.searchCategoryButton.Location = new System.Drawing.Point(354, 52);
            this.searchCategoryButton.Name = "searchCategoryButton";
            this.searchCategoryButton.Size = new System.Drawing.Size(128, 26);
            this.searchCategoryButton.TabIndex = 5;
            this.searchCategoryButton.Text = "Search";
            this.searchCategoryButton.UseVisualStyleBackColor = true;
            this.searchCategoryButton.Click += new System.EventHandler(this.searchCategoryButton_Click);
            // 
            // searchCategoryTextBox
            // 
            this.searchCategoryTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchCategoryTextBox.Location = new System.Drawing.Point(164, 52);
            this.searchCategoryTextBox.Name = "searchCategoryTextBox";
            this.searchCategoryTextBox.Size = new System.Drawing.Size(174, 26);
            this.searchCategoryTextBox.TabIndex = 4;
            // 
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Location = new System.Drawing.Point(43, 55);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(102, 19);
            this.searchCategoryLabel.TabIndex = 3;
            this.searchCategoryLabel.Text = "Category ID: ";
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.Location = new System.Drawing.Point(164, 149);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(318, 33);
            this.updateCategoryButton.TabIndex = 2;
            this.updateCategoryButton.Text = "Update Category";
            this.updateCategoryButton.UseVisualStyleBackColor = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // updateCetegoryTextBox
            // 
            this.updateCetegoryTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateCetegoryTextBox.Location = new System.Drawing.Point(164, 101);
            this.updateCetegoryTextBox.Name = "updateCetegoryTextBox";
            this.updateCetegoryTextBox.Size = new System.Drawing.Size(318, 26);
            this.updateCetegoryTextBox.TabIndex = 1;
            // 
            // updateCategoryLabel
            // 
            this.updateCategoryLabel.AutoSize = true;
            this.updateCategoryLabel.Location = new System.Drawing.Point(21, 104);
            this.updateCategoryLabel.Name = "updateCategoryLabel";
            this.updateCategoryLabel.Size = new System.Drawing.Size(124, 19);
            this.updateCategoryLabel.TabIndex = 0;
            this.updateCategoryLabel.Text = "Category Name: ";
            // 
            // CategoryWiseGroupBox
            // 
            this.CategoryWiseGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.CategoryWiseGroupBox.Controls.Add(this.selectCategoryComboBox);
            this.CategoryWiseGroupBox.Controls.Add(this.SelectCategoryLabel);
            this.CategoryWiseGroupBox.Controls.Add(this.selectCategoryListProductDataGridView);
            this.CategoryWiseGroupBox.Location = new System.Drawing.Point(625, 283);
            this.CategoryWiseGroupBox.Name = "CategoryWiseGroupBox";
            this.CategoryWiseGroupBox.Size = new System.Drawing.Size(563, 350);
            this.CategoryWiseGroupBox.TabIndex = 1;
            this.CategoryWiseGroupBox.TabStop = false;
            this.CategoryWiseGroupBox.Text = "Product Lists by Category ";
            this.CategoryWiseGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // selectCategoryComboBox
            // 
            this.selectCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategoryComboBox.FormattingEnabled = true;
            this.selectCategoryComboBox.Location = new System.Drawing.Point(169, 45);
            this.selectCategoryComboBox.Name = "selectCategoryComboBox";
            this.selectCategoryComboBox.Size = new System.Drawing.Size(367, 27);
            this.selectCategoryComboBox.TabIndex = 2;
            this.selectCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCategoryComboBox_SelectedIndexChanged);
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Location = new System.Drawing.Point(32, 48);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(116, 19);
            this.SelectCategoryLabel.TabIndex = 1;
            this.SelectCategoryLabel.Text = "Select Category";
            // 
            // selectCategoryListProductDataGridView
            // 
            this.selectCategoryListProductDataGridView.AllowUserToAddRows = false;
            this.selectCategoryListProductDataGridView.AllowUserToDeleteRows = false;
            this.selectCategoryListProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectCategoryListProductDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectCategoryListProductDataGridView.Location = new System.Drawing.Point(36, 99);
            this.selectCategoryListProductDataGridView.Name = "selectCategoryListProductDataGridView";
            this.selectCategoryListProductDataGridView.ReadOnly = true;
            this.selectCategoryListProductDataGridView.Size = new System.Drawing.Size(500, 225);
            this.selectCategoryListProductDataGridView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SkyBlue;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.Location = new System.Drawing.Point(77, 691);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 41);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CategoryWiseGroupBox);
            this.Controls.Add(this.updateCategoryGroupBox);
            this.Controls.Add(this.categoryDeleteGroupBox);
            this.Controls.Add(this.addNewCategoryGroupBox1);
            this.Controls.Add(this.categoryList1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Categories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCategory_FormClosing);
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.categoryList1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView1)).EndInit();
            this.addNewCategoryGroupBox1.ResumeLayout(false);
            this.addNewCategoryGroupBox1.PerformLayout();
            this.categoryDeleteGroupBox.ResumeLayout(false);
            this.categoryDeleteGroupBox.PerformLayout();
            this.updateCategoryGroupBox.ResumeLayout(false);
            this.updateCategoryGroupBox.PerformLayout();
            this.CategoryWiseGroupBox.ResumeLayout(false);
            this.CategoryWiseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectCategoryListProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryList1;
        private System.Windows.Forms.DataGridView categoryListDataGridView1;
        private System.Windows.Forms.GroupBox addNewCategoryGroupBox1;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox addCategoryNameTextBox1;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.GroupBox categoryDeleteGroupBox;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.TextBox deleteCategoryTextBox2;
        private System.Windows.Forms.Label categoryDeleteLabel;
        private System.Windows.Forms.GroupBox updateCategoryGroupBox;
        private System.Windows.Forms.Button searchCategoryButton;
        private System.Windows.Forms.TextBox searchCategoryTextBox;
        private System.Windows.Forms.Label searchCategoryLabel;
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.TextBox updateCetegoryTextBox;
        private System.Windows.Forms.Label updateCategoryLabel;
        private System.Windows.Forms.GroupBox CategoryWiseGroupBox;
        private System.Windows.Forms.DataGridView selectCategoryListProductDataGridView;
        private System.Windows.Forms.ComboBox selectCategoryComboBox;
        private System.Windows.Forms.Label SelectCategoryLabel;
        private System.Windows.Forms.Button BackButton;
    }
}