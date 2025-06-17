using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop_DataLayer;
using CoffeeShopCommon;

namespace CoffeeShopSystem_BusinessLogic
{
    public class UserProcess
    {
        UserDataService_JSON userDataService = new UserDataService_JSON();

        public bool ValidatePassword(string password, string password2)
        {
            return userDataService.ValidatePassword(password, password2);
        }

        public bool ValidateAdmin(string email, string password)
        {
            return userDataService.ValidateAdmin(email, password);
        }

        public void RegisterUser(string email, string password)
        {
            userDataService.RegisterUser(email, password);
        }

        public bool ValidateUser(string email,string password)
        {
            return userDataService.ValidateUser(email, password);
        }

    }
}
