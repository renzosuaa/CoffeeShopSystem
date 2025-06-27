using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCommon;

namespace CoffeeShop_DataLayer
{
    public class Order_DataService_InMemory
    {
        Order order = new Order();

        static List<Order> orders = new List<Order>();

        public Order_DataService_InMemory(int userID)
        {
            order.orderID = IDCounter + 1;
            order.userID = userID;
        }

        int IDCounter = 0;
        private void InitializeIDCounter()
        {
            AddDummyOrder();
            foreach (var order in orders)
            {
                if (order.orderID > IDCounter)
                {
                    IDCounter = order.orderID;
                }
            }
        }

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


        public void AddOrderToList(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrders(int _userID)
        {
            List<Order> userOrders = new List<Order>();

            foreach (Order order in orders)
            {

                if (order.userID == _userID)
                {
                    userOrders.Add(order);
                }
            }

            return userOrders;
        }

        private bool checkIfContains(string name)
        {
            return order.items.Any(item => item.name == name);
        }

        public Order GetCurrentOrder()
        {
            return order;
        }

        public void AddDummyOrder()
        {
            orders.Add(new Order
            {
                orderID = 1,
                userID = 1,
                items = new List<Item>
                {
                    new Item { name = "Coffee", cost = 2.5, type = "Beverage", soldCount = 1 },
                    new Item { name = "Muffin", cost = 1.5, type = "Food", soldCount = 2 }
                }
            });
        }
    }
}