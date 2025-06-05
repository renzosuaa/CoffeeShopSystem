using CoffeeShopCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class UserDataService_SQLServer : IUserDataService
    {
        static string connectionString
        = "Data Source =DESKTOP-55DMAU9\\SQLEXPRESS02; Initial Catalog = CoffeeShop; Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void RegisterUser(string email, string password)
        {
            var insertStatement = "INSERT INTO Users VALUES (@email, @password, @type)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@email", email);
            insertCommand.Parameters.AddWithValue("@password", password);
            insertCommand.Parameters.AddWithValue("@type", "Customer");
            sqlConnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public bool ValidateAdmin(string email, string password)
        {
            string selectStatement = "SELECT email FROM Users WHERE type = 'Admin' AND (email = '"+email+"' AND password = '"+password+"')";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            if (reader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public bool ValidateUser(string email, string password)
        {
            string selectStatement = "SELECT email FROM Users WHERE email = '" + email + "' AND password = '" + password +"'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            if (reader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            sqlConnection.Close();
            return false;
        }
        public bool ValidatePassword(string password, string password2)
        {
            return password == password2;
        }
    }
}
