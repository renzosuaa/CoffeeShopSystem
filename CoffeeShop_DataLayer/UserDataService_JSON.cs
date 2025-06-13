using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class UserDataService_JSON : IUserDataService
    {

        List<User> userList = new List<User>();
        string file_path = "users.json";


        public UserDataService_JSON()
        {
            ReadJsonDataFromFile();
        }
        private void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(file_path);

            userList = JsonSerializer.Deserialize<List<User>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

        }
        private void UpdateFile()
        {
            string jsonString = JsonSerializer.Serialize(userList, new JsonSerializerOptions
            { WriteIndented = false });

            File.WriteAllText(file_path, jsonString);
        }


        public void RegisterUser(string email, string password)
        {
            userList.Add(new User(email, password, "Customer"));
            UpdateFile();
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
