using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCommon;

namespace CoffeeShop_DataLayer
{
    public class Order_DataService
    {
        Order order = new Order();

        public void AddOrder(Item item)
        {
            if (checkIfContains(item.name))
            {
                AddSoldCount(item.name, item.soldCount);
            }
            else
            {
                order.items.Add(item);
            }
        }


        public List<Item> GetItems()
        {
            return order.items;
        }

        public void AddSoldCount(string name, int orderQuantity)
        {
            foreach (Item item in order.items)
            {
                if (item.name == name)
                {
                    item.soldCount += orderQuantity;
                }
            }
        }

        bool checkIfContains(string name)
        {
            for (int i = 0; i < order.items.Count; i++)
            {
                if (order.items[i].name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
