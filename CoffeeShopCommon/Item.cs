﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCommon
{
     public class Item
     {
        public string name;
        public double cost;
        public int soldCount = 0;
        public string type;

        public Item(string name, double cost, string type)
        {
            this.name = name;
            this.cost = cost;
            this.type = type;
        }

        public Item(string name, double cost, string type, int soldCount)
        {
            this.name = name;
            this.cost = cost;
            this.type = type;
            this.soldCount = soldCount;
        }


    }
}
