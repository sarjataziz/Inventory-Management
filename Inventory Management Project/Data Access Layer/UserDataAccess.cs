using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_Project.Data_Access_Layer
{
    internal class UserDataAccess:DataAccess
    {
        public bool Registration(string name, string username, string email,string password, string dateOfBirth, string gender, string bloodGroup)
        {
            string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,Gender,BloodGroup) " +
                "VALUE ('"+ name +"','"+ username +"','"+ email + "','"+ password +"','"+ dateOfBirth +"','"+ gender +"','"+ bloodGroup+"')";

            int result = this.ExecuteQuery(sql); 

            if(result > 0)
            {
                return true;
            }
            return false;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username = '"+ username +"' AND Password = '"+ password +"'";

            SqlDataReader sqlDataReader = this.GetData(sql);

            if (sqlDataReader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
