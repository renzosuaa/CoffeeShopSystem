using CoffeeShopCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class UserDataService_Text : IUserDataService
    {
        List<User> userList = new List<User>();
        string file_path = "users.txt";
        int IDCounter = 0;

        public UserDataService_Text()
        {
            GetData();
            InitializeIDCounter();

        }

        void GetData()
        {
            var lines = File.ReadAllLines(file_path);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                userList.Add(new User(
                    Convert.ToInt32(parts[0]), 
                    parts[1],
                    parts[2],
                    parts[3])
                );
            }
        }

        public void RegisterUser(string email, string password)
        {
            userList.Add(new User(IDCounter+1,email, password, "Customer"));
            var newLine = $"{IDCounter + 1}|{email}|{password}|Customer";
            File.AppendAllText(file_path, newLine);
        }

        public int GetUserID(string email)
        {
            foreach (User user in userList)
            {
                if (user.email == email)
                {
                    return user.userID;
                }

            }
            return -1;
        }

        public bool ValidateAdmin(string email, string password)
        {
            List<User> admins = new List<User>();
            foreach (User user in userList)
            {
                if (user.type == "Admin")
                {
                    admins.Add(user);
                }
            }

            foreach (User admin in admins)
            {
                if (admin.email == email && admin.password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ValidateUser(string email, string password)
        {
            foreach (User user in userList)
            {
                if (user.email == email && user.password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidatePassword(string password, string password2)
        {
            return password == password2;
        }

        private void InitializeIDCounter()
        {
            foreach (var user in userList)
            {
                if (user.userID > IDCounter)
                {
                    IDCounter = user.userID;
                }
            }
        }
    }
}
