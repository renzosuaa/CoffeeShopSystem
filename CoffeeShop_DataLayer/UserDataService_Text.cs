using CoffeeShopCommon;
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

        public UserDataService_Text()
        {
            GetData();
            foreach(User user in userList)
            {
                Console.WriteLine(user.email + " " + user.password + " " + user.type);
            }
        }

        void GetData()
        {
            var lines = File.ReadAllLines(file_path);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                userList.Add(new User(
                    parts[0],
                    parts[1],
                    parts[2])
                );
            }
        }

        public void RegisterUser(string email, string password)
        {
            userList.Add(new User(email, password, "Customer"));
            var newLine = $"{email}|{password}|Customer";
            File.AppendAllText(file_path, newLine);
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
    }
}
