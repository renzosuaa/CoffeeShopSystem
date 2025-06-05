using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCommon
{
    public class User
    {
        public string email { get; set; }

        public string password { get; set; }

        public string type { get; set; }

        public User(string email,string password, string type)
        {
            this.email = email;
            this.password = password;
            this.type = type;
        }

    }
}
