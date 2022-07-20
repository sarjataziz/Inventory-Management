using Inventory_Management_Project.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Project.Presentation_Layer
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();

            ProductDataAccess productDataAccess = new ProductDataAccess();
            productListDataGridView.DataSource = productDataAccess.GetAllProducts();

            productDataAccess = new ProductDataAccess();
            addCategoryComboBox.DataSource = productDataAccess.GetAllCategoryNames();

            productDataAccess = new ProductDataAccess();
            updateProductCategoryComboBox.DataSource = productDataAccess.GetAllCategoryNames();
        }

        private void ManageProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void UpdateProductList()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();

            productListDataGridView.DataSource = productDataAccess.GetAllProducts();
        }

        
        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();

            int categoryId = productDataAccess.GetCategoryIdByName(addCategoryComboBox.Text);

            if (categoryId > 0)
            {
                productDataAccess = new ProductDataAccess();

                if (productDataAccess.AddNewProduct(productNameTextBox.Text, Convert.ToDouble(productPriceTextBox.Text), categoryId))
                {
                    MessageBox.Show("Product Added.");
                    UpdateProductList();
                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }
            }
            else
            {
                MessageBox.Show("Category not found.");
            }
        }

        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();

            Product product = productDataAccess.GetProductByID(Convert.ToInt32(deleteProductTextBox.Text));

            if (product != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    productDataAccess = new ProductDataAccess();

                    if (productDataAccess.DeleteProduct(product.ProductId))
                    {
                        MessageBox.Show("Product Deleted.");
                        UpdateProductList();
                    }
                    else
                    {
                        MessageBox.Show("Error in Deleting.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void productListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateProductIDTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateProductNameTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateProductPriceTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            int categoryID = (int) productListDataGridView.Rows[e.RowIndex].Cells[3].Value;

            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

            string categoryName = categoryDataAccess.GetCategoryNameByID(categoryID);

            updateProductCategoryComboBox.Text = categoryName;          
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();

            int categoryId = productDataAccess.GetCategoryIdByName(updateProductCategoryComboBox.Text);

            if (categoryId > 0)
            {
                productDataAccess = new ProductDataAccess();

                if (productDataAccess.UpdateProduct(Convert.ToInt32(updateProductIDTextBox.Text), updateProductNameTextBox.Text, Convert.ToDouble(updateProductPriceTextBox.Text), categoryId))
                {
                    MessageBox.Show("Product Updated.");
                    UpdateProductList();
                }
                else
                {
                    MessageBox.Show("Error in Updating.");
                }
            }
            else
            {
                MessageBox.Show("Category not found.");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchProductsTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();

            SearchProductsDataGridView.DataSource = productDataAccess.GetProductsByName(SearchProductsTextBox.Text);
        }
    }
}
