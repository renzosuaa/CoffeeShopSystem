using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSystem_BusinessDataLogic
{
    public class CoffeeShopProcess
    {
        public static string orderReceipt = "";
        public static List<Item> orderList = new List<Item>();

        public static void AddOrderToReceipt(int order, int quantity)
        { 
            orderReceipt += quantity + " " + orderList[order].name + " :" + quantity * orderList[order].cost + "\n";
        }

        public static void AddSoldCountOfOrder(string name, int quantity)
        {
            ItemProcess.AddSoldCount(name, quantity);
        }

        public static string GetOrderName(int order)
        {
            return orderList[order].name;
        }

        public static int GetOrderListCount()
        {
            return orderList.Count;
        }

        public static void AddItemToOrderList(string itemType)
        {
            foreach (Item _item in ItemProcess.GetItemsPerType(itemType))
            {
                orderList.Add(_item);
            }
        }

        public static void AddItemTypeInReceipt(string itemType)
        {
            orderReceipt += itemType + " \n";
        }

        public static void AddTotaltoReceipt()
        {
            orderReceipt += " Total: " + GetTotalPriceOfOrder();
        }

        public static double GetTotalPriceOfOrder()
        {
            double total = 0.00;
            foreach (string itemType in ItemProcess.itemTypes)
            {
                total += GetTotalSoldPerItemType(itemType);
            }     
            return total;
        }

        public static double GetTotalSoldPerItemType(string itemType)
        {
            double total = 0;
            List<Item> _items = new List<Item>(ItemProcess.GetItemsPerType(itemType));
            foreach (Item item in _items)
            {
                double totalSoldPerDrink = item.soldCount * item.cost;
                total += totalSoldPerDrink;
            }
            return total;
        }

        public static void ClearReceipt()
        {
            orderReceipt = "";
        }

        public static void ClearOrderList()
        {
            orderList.Clear();
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static int GetUserInputInt()
        {
            return Convert.ToInt16(GetUserInput());
        }

        public static double GetUserInputDouble()
        {
            return Convert.ToDouble(GetUserInput());
        }
    }
}
