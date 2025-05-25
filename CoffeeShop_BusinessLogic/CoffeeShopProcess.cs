using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCommon;
using CoffeeShop_DataLayer;

namespace CoffeeShopSystem_BusinessLogic
{

    // general actions
    public class CoffeeShopProcess
    {
        public static List<Item> orderList;
        internal static ItemProcess_SQLServer DataProcess = new ItemProcess_SQLServer();

        public CoffeeShopProcess()
        {
            orderList = new List<Item>();
        }

        public void AddSoldCountOfOrder(string name, int quantity)
        {
            DataProcess.AddSoldCount(name, quantity);
        }

        public static string GetOrderName(int order)
        {
            return orderList[order].name;
        }

        public static int GetOrderListCount()
        {
            return orderList.Count;
        }

        public void AddItemToOrderList(string itemType)
        {
            foreach (Item _item in DataProcess.GetItemsPerType(itemType))
            {
                orderList.Add(_item);
            }
        }

        public double GetTotalSoldPerItemType(string itemType)
        {
            double total = 0;
            List<Item> _items = new List<Item>(DataProcess.GetItemsPerType(itemType));
            foreach (Item item in _items)
            {
                double totalSoldPerDrink = item.soldCount * item.cost;
                total += totalSoldPerDrink;
            }
            return total;
        }

        public double GetTotalPriceOfOrder()
        {
            double total = 0.00;
            foreach (string itemType in DataProcess.GetItemTypes())
            {
                total += GetTotalSoldPerItemType(itemType);
            }
            return total;
        }

        public void UpdateOrderList()
        {
            orderList = new List<Item>(GetAllItems());
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

        //helper methods to connect datalayer and UI

        public bool DeleteItem(string itemName)
        {
            return DataProcess.DeleteItem(itemName);
        }

        public List<Item> GetItemsPerType(string itemType)
        {
            return DataProcess.GetItemsPerType(itemType);
        }
        public void AddItem(string itemName, double itemCost, string itemType)
        {
            DataProcess.AddItem(itemName, itemCost, itemType);
            orderList.Add(new Item(itemName, itemCost, itemType));
        }

        public string[] GetItemTypes()
        {
            return DataProcess.GetItemTypes();
        }

        public List<Item> GetAllItems()
        {
            return DataProcess.GetItems();
        }
    }


}
