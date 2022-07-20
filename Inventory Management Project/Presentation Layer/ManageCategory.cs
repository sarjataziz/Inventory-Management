using Inventory_Management_Project.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_Project.Presentation_Layer
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();

            ProductDataAccess productDataAccess = new ProductDataAccess();

            selectCategoryComboBox.DataSource = productDataAccess.GetAllCategoryNames();
        }

        private void ManageCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryList();

            selectCategoryComboBox.SelectedIndex = -1;
        }

        void LoadCategoryList()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

            categoryListDataGridView1.DataSource = categoryDataAccess.GetCategories();
        } 


        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

            if (categoryDataAccess.AddNewCategory(addCategoryNameTextBox1.Text))
            {
                MessageBox.Show("Category Added.");
                LoadCategoryList();
            }
            else
            {
                MessageBox.Show("Error in adding.");
            }
        }

        private void categoryNameLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

            if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryTextBox2.Text)))
            {
                MessageBox.Show("Category Deleted.");
                LoadCategoryList();
            }
            else
            {
                MessageBox.Show("Error in deleting.");
            }
        }


        private void searchCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

            string value = categoryDataAccess.GetCategoryNameByID(Convert.ToInt32(searchCategoryTextBox.Text));

            if (value == null)
            {
                MessageBox.Show("Category not found.");

                updateCetegoryTextBox.Text = "";
            }
            else
            {
                updateCetegoryTextBox.Text = value;
            } 
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            if ((searchCategoryTextBox.Text == "") || (updateCetegoryTextBox.Text == ""))
            {
                MessageBox.Show("Search proper category to update.");
            }
            else
            {
                CategoryDataAccess categoryDataAccess = new CategoryDataAccess();

                if (categoryDataAccess.UpadateCategory(Convert.ToInt32(searchCategoryTextBox.Text), updateCetegoryTextBox.Text))
                {
                    MessageBox.Show("Category Updated.");
                    LoadCategoryList();
                }
                else
                {
                    MessageBox.Show("Error in Updating.");
                }
            }
        }

        private void categoryListDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selectCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();

            int categoryID = productDataAccess.GetCategoryIdByName(selectCategoryComboBox.Text);

            productDataAccess = new ProductDataAccess();

            selectCategoryListProductDataGridView.DataSource = productDataAccess.GetAllProductsByCategoryID(categoryID);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
             DashBoard dashBoard = new DashBoard();

            dashBoard.Show();
            this.Hide();
        }
    }
}
