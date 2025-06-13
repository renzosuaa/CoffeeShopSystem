using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCommon
{

    public class Item
    {
        public string name { get; set; }
        public double cost { get; set; }
        public int soldCount { get; set; }
        public string type { get; set; }

        public Item(string name, double cost, string type, int soldCount = 0)
        {
            this.name = name;
            this.cost = cost;
            this.type = type;
            this.soldCount = soldCount;
        }

        public Item()
        {
        }
    }
}
