using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Project.Data_Access_Layer
{
    internal class ProductDataAccess : DataAccess
    {
        public List<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM Products";

            SqlDataReader sqlDataReader = this.GetData(sql);


            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ProductId = (int)sqlDataReader["ProductId"];
                product.ProductName = sqlDataReader["ProductName"].ToString();
                product.Price = Convert.ToDouble(sqlDataReader["Price"]);
                product.CategoryId = (int)sqlDataReader["CategoryId"];
                products.Add(product);
            }

            return products;
        }

        //Add New Product
        public bool AddNewProduct(string productName, double price, int categoryId)
        {
            string sql = "INSERT INTO Products(ProductName,Price,CategoryId) VALUES('" + productName + "'," + price + "," + categoryId + ")";

            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        //Delete Product
        public bool DeleteProduct(int productId)
        {
            string sql = "DELETE FROM Products WHERE ProductId = " + productId;

            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        //For Update
        public Product GetProductByID(int productID)
        {
            string sql = "SELECT * FROM Products WHERE ProductId = " + productID;

            SqlDataReader sqlDataReader = this.GetData(sql);


            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ProductId = (int)sqlDataReader["ProductId"];
                product.ProductName = sqlDataReader["ProductName"].ToString();
                product.Price = Convert.ToDouble(sqlDataReader["Price"]);
                product.CategoryId = (int)sqlDataReader["CategoryId"];

                return product;
            }

            return null;
        }

        //Update Products
        public bool UpdateProduct(int productId, string productName, double price, int categoryId)
        {
            string sql = "UPDATE Products SET ProductName = '" + productName + "', Price = " + price + ", CategoryId = " + categoryId + " WHERE ProductId = " + productId;

            int result = this.ExecuteQuery(sql);

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        //For Category Name to Combo Box
        public List<string> GetAllCategoryNames()
        {
            string sql = "SELECT * FROM Categories";

            SqlDataReader sqlDataReader = this.GetData(sql);


            List<string> categoryName = new List<string>();

            while (sqlDataReader.Read())
            {
                categoryName.Add(sqlDataReader["CategoryName"].ToString());
            }

            return categoryName;
        }


        public int GetCategoryIdByName(string categoryName)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryName='" + categoryName + "'";
            SqlDataReader sqlDataReader = this.GetData(sql);
            if (sqlDataReader.Read())
            {
                return (int)sqlDataReader["CategoryId"];
            }
            return -1;
        }

        public List<Product> GetAllProductsByCategoryID(int categoryID)
        {
            string sql = "SELECT * FROM Products WHERE CategoryId =" + categoryID;

            SqlDataReader sqlDataReader = this.GetData(sql);


            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ProductId = (int)sqlDataReader["ProductId"];
                product.ProductName = sqlDataReader["ProductName"].ToString();
                product.Price = Convert.ToDouble(sqlDataReader["Price"]);
                product.CategoryId = (int)sqlDataReader["CategoryId"];
                products.Add(product);
            }

            return products;
        }

        public List<Product> GetProductsByName(string productName)
        {
            string sql = "SELECT * FROM Products WHERE ProductName LIKE '"+ productName +"%'";

            SqlDataReader sqlDataReader = this.GetData(sql);


            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product();

                product.ProductId = (int)sqlDataReader["ProductId"];
                product.ProductName = sqlDataReader["ProductName"].ToString();
                product.Price = Convert.ToDouble(sqlDataReader["Price"]);
                product.CategoryId = (int)sqlDataReader["CategoryId"];
                products.Add(product);
            }

            return products;
        }
    }
}
