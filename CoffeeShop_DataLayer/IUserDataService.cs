using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public interface IUserDataService
    {
        public bool ValidateAdmin(string email, string password);

        public void RegisterUser(string email, string password);

        public bool ValidateUser(string email, string password);
    }
}
