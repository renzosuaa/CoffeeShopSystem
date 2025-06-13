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
                UpdateSoldCount(item.name, item.soldCount);
            }
            else
            {
                Item newItem = new Item
                {
                    name = item.name,
                    cost = item.cost,
                    type = item.type,
                    soldCount = item.soldCount
                };
                order.items.Add(newItem);

            }
        }

        public void ClearOrder()
        {
            order.items.Clear();
        }

        public List<Item> GetItems()
        {

            return order.items;
        }

        private void UpdateSoldCount(string name, int orderQuantity)
        {  
            for (int i = 0; i < order.items.Count; i++)
            {
                if (order.items[i].name == name)
                {                   
                    order.items[i].soldCount += orderQuantity;                    
                }
            }
        }

        private bool checkIfContains(string name)
        {
            return order.items.Any(item => item.name == name);
        }
    }
}