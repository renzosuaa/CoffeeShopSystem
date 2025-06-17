using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCommon
{
    public class User
    {
        public int userID { get; set; }
        public string email { get; set; }

        public string password { get; set; }

        public string type { get; set; }

        public User(int userID,string email,string password, string type)
        {
            this.userID = userID;
            this.email = email;
            this.password = password;
            this.type = type;
        }

    }
}
