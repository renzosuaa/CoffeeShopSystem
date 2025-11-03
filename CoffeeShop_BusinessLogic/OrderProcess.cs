using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCommon;
using CoffeeShop_DataLayer;

namespace CoffeeShopSystem_BusinessLogic
{
    //per order action
    public class OrderProcess
    {
        Order_DataService_JSON Data_Service;
        int userID;

        public OrderProcess(int userID = 0)
        {
            Data_Service = new Order_DataService_JSON(userID);
            this.userID = userID;
        }

        public void AddOrder(Item item)
        {
            Data_Service.AddOrder(item);
        }

        public List<Item> GetAllOrderItems()
        {
            return Data_Service.GetItems();
        }

        public void ClearOrder()
        {
            Data_Service.ClearOrder();
        }

        public bool SaveCurrentOrder()
        {
            if (GetAllOrderItems().Count > 0) 
            {
                Data_Service.AddOrderToList(Data_Service.GetCurrentOrder());
                return true;
            }
            else
            {
                return false;
            }
        }

        List<string> GetOrderItemTypes()
        {
            HashSet<string> types = new HashSet<string>();
            foreach (Item item in GetAllOrderItems())
            {
                types.Add(item.type);
            }
            return types.ToList();
        }

        double GetTotalPerType(string itemType)
        {
            double total = 0;
            foreach (Item order in GetAllOrderItems())
            {
                if (order.type == itemType)
                {
                    total += order.cost * order.soldCount;
                }
            }
            return total;
        }

        // for building the receipt
        // will be move to OrderingInterface
        string GetSummaryItem(Item item)
        {
            double total = item.soldCount * item.cost;
            string summary = item.soldCount + " " + item.name + ": " + total;
            return summary;
        }

        public string PrintReceipt()
        {
            double total = 0;
            string receipt = """
                ---------------------------------------
                                Orders
                ---------------------------------------

                """;

            foreach (String type in GetOrderItemTypes())
            {
                double totalPerType = GetTotalPerType(type);
                receipt += type + "\n";
                receipt += GetSummaryPerItemType(type);
                receipt += "   : " + totalPerType + "\n";
                receipt += "---------\n";

                total += totalPerType;
            }
            receipt += "Total: " + total;
            return receipt;
        }

        string GetSummaryPerItemType(string itemType)
        {
            string summary = "";
            summary += "----------------\n";
            foreach (Item order in GetAllOrderItems())
            {
                if (order.type == itemType)
                {
                    summary += GetSummaryItem(order);
                    summary += "\n";
                }
            }
            return summary;
        }

        public string GetUserOrders()
        {
            string orders = "";
            List<Order> userOrders = Data_Service.GetOrders(userID);

            if (userOrders.Count == 0)
            {
                return "No previous orders found for this user.";
            }

            foreach (Order order in userOrders)
            {
                orders += "Order ID: " + order.orderID + "\n";

                if (order.items != null)
                {
                    foreach (Item item in order.items)
                    {
                        orders += GetSummaryItem(item) + "\n";
                    }
                }
                else
                {
                    orders += "No items in this order.\n";
                }
                orders += "-------------------\n";
            }
            return orders;
        }
    }
}