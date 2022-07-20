using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Project.Data_Access_Layer
{
    internal class CategoryDataAccess:DataAccess
    {
        public List<Category> GetCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader sqlDataReader = this.GetData(sql);

            List<Category> categories = new List<Category>();

            while(sqlDataReader.Read())
            {
                Category category = new Category();

                category.CategoryId = (int) sqlDataReader["CategoryId"];
                category.CategoryName = sqlDataReader["CategoryName"].ToString();
                categories.Add(category);
            }
            return categories;
        }

        public bool AddNewCategory(string categoryName)                         //Add Category
        {
            string sql = "INSERT INTO Categories(CategoryName) VALUES('" + categoryName +"')";

            int result = this.ExecuteQuery(sql);

            if(result > 0)
            {
                return true;
            }  
            return false;
        }

        public bool DeleteCategory(int categoryId)                              //Delete Category
        {
            string sql = "DELETE FROM Categories WHERE CategoryId=" + categoryId;

            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return true;
            }
            return false;
        }
        
        public string GetCategoryNameByID(int categoryID)                           //Search by ID
        {
            string sql = "SELECT * FROM Categories WHERE CategoryId = " + categoryID;

            SqlDataReader sqlDataReader = this.GetData(sql);

            if(sqlDataReader.Read())
            {
                return sqlDataReader["CategoryName"].ToString();
            }

            return null;
        }
        
        public bool UpadateCategory(int categoryId, string categoryName)                //Update Category
        {
            string sql = "UPDATE Categories SET CategoryName = '"+ categoryName +"'  WHERE CategoryId=" + categoryId;

            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
