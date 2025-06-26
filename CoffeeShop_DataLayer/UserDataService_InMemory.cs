using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class UserDataService_InMemory : IUserDataService
    {
        List<User> userList = new List<User>();

        int IDCounter = 0;

        public UserDataService_InMemory()
        {
            DummyDatas();
            InitializeIDCounter();
        }


        public bool ValidatePassword(string password, string password2)
        {
            return password == password2;
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

        public void RegisterUser(string email, string password)
        {
            userList.Add(new User(IDCounter+1,email, password, "Customer"));
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

        public void DummyDatas()
        {
            userList.Add(new User(1,"admin1","admin123", "Admin"));
            userList.Add(new User(2,"user1", "user123", "Customer"));
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
