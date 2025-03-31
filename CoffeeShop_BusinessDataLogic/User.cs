using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSystem_BusinessDataLogic
{
    public class User
    {
        public string userusername;
        public string password;

        public User(string Name,string Password)
        {
            this.userusername = Name;
            this.password = Password;
        }

    }
}
