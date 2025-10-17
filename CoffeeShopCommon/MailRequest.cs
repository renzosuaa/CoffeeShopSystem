using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCommon
{
    public class MailRequest
    {
       
        public string type { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        public MailRequest(string email, string type) {
            this.email = email;
            this.type = type;
        }

        public MailRequest(string email, string type, string body) { 
            this.type = type;
            this.body = body;
            this.email = email;
        }
    }
}
