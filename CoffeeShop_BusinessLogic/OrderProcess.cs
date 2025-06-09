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
        Order_DataService Data_Service = new Order_DataService();
       public void AddOrder(Item item)
       {
            Data_Service.AddOrder(item);
       }


        List<string> GetOrderItemTypes()
        {
            HashSet<string> types = new HashSet<string>();
            foreach (Item item in Data_Service.GetItems())
            {
                types.Add(item.type);
            }
            return types.ToList();
        }

        string GetSummaryPerItemType(string itemType)
        {
            string summary = "";
            summary += "----------------\n";
            foreach (Item order in Data_Service.GetItems())
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
            foreach (Item order in Data_Service.GetItems())
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