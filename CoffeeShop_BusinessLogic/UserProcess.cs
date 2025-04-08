using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCommon;

namespace CoffeeShopSystem_BusinessLogic
{
    public class UserProcess
    {
        static List<User> userList = new List<User>();
        static string adminName = "admin1", adminPassword = "admin123";

        public static bool ValidatePassword(string password, string password2)
        {
            return password == password2;
        }

        public static bool ValidateAdmin(string username, string password)
        {
            return (username == adminName && password == adminPassword);
        }

        public static void RegisterUser(string username, string password)
        {
            userList.Add(new User(username, password));
        }

        public static bool ValidateUser(string username,string password)
        {
            foreach(User user in userList)
            {
                if (user.userusername == username && user.password == password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
