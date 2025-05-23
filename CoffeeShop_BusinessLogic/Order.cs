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

    public class Order
    {
        List<Item> orders = new List<Item>();
        public void AddOrder(string name, int quantity)
        {
            if (checkIfContains(name))
            {
                AddSoldCount(name, quantity);
            }
            else
            {
                orders.Add(new Item(name, CoffeeShopProcess.DataProcess.GetItemCost(name), CoffeeShopProcess.DataProcess.GetItemType(name), quantity));
            }
        }

        public void AddSoldCount(string name, int orderQuantity)
        {
            foreach (Item order in orders)
            {
                if (order.name == name)
                {
                    order.soldCount += orderQuantity;
                    CoffeeShopProcess.DataProcess.AddSoldCount(name,orderQuantity);
                }
            }
        }

        bool checkIfContains(string name)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].name == name)
                {
                    return true;
                }
            }
            return false;
        }

        List<string> GetOrderItemTypes()
        {
            HashSet<string> types = new HashSet<string>();
            foreach (Item order in orders)
            {
                types.Add(order.type);
            }
            return types.ToList();
        }

        string GetSummaryPerItemType(string itemType)
        {
            string summary = "";
            summary += "----------------\n";
            foreach (Item order in orders)
            {
                if (order.type == itemType)
                {
                    summary += GetSummaryItem(order);
                    summary += "\n";
                }
            }
            return summary;
        }

        double GetTotalPerType(string itemType)
        {
            double total = 0;
            foreach (Item order in orders)
            {
                if (order.type == itemType)
                {
                    total += order.cost * order.soldCount;
                }
            }
            return total;
        }

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
    }
}