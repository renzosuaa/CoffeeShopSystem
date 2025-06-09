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
        internal static ItemProcess_InMemory DataProcess = new ItemProcess_InMemory();
        public static List<Item> itemList  = new List<Item>(DataProcess.GetItems());

        public CoffeeShopProcess()
        {
            
        }

        //returns all the existing items
        public static List<Item> GetAllItems()
        {
            return itemList;
        }

        public void AddSoldCountOfOrder(string name, int quantity)
        {
            DataProcess.AddSoldCount(name, quantity);  
        }


        public static Item GetOrderName(int order)
        {
            return itemList[order];
        }

        public static int  GetOrderListCount()
        {
            return itemList.Count;
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

        public  double GetTotalPriceOfOrder()
        {
            double total = 0.00;
            foreach (string itemType in DataProcess.GetItemTypes())
            {
                total += GetTotalSoldPerItemType(itemType);
            }
            return total;
        }

        public static void UpdateOrderList()
        {
            itemList = new List<Item>(GetAllItems());
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
        }

        public string[] GetItemTypes()
        {
            return DataProcess.GetItemTypes();
        }

        
    }
}
