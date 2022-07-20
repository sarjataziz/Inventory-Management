using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Project.Data_Access_Layer
{
    internal class DataAccess:IDisposable
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;

        public DataAccess()
        {
            this.sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMS"].ConnectionString);
            this.sqlConnection.Open();
        }

        public SqlDataReader GetData(string sql)                                
        {
            this.sqlCommand = new SqlCommand(sql, sqlConnection);
            return this.sqlCommand.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.sqlCommand = new SqlCommand(sql, sqlConnection);
            return this.sqlCommand.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.sqlConnection.Close();
        }

        /*
        ~DataAccess()  //Useing destractor I get Exception after closing From.
        {
            this.sqlConnection.Close();                                     //Destractor use for closing the sql
        }
        //We can alse close sql by using Dispose() methd. For that we need inheru=it IDespose interface 1st.
        */
    }
}
