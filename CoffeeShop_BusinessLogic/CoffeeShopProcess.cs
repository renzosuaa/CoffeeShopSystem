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
        internal ItemDataService_SQLServer DataProcess = new ItemDataService_SQLServer();
        public  List<Item> itemList  = new List<Item>();

        public CoffeeShopProcess()
        {
            itemList = new List<Item>(DataProcess.GetItems());
        }

        
        public  List<Item> GetAllItems()
        {
            return itemList;
        }

        public void AddSoldCount(List<Item> order)
        {
            foreach (Item item in order)
            {
                DataProcess.AddSoldCount(item.name, item.soldCount);
            }
            
        }

        public Item GetOrderName(int order)
        {
            return itemList[order];
        }

        public int  GetOrderListCount()
        {
            return itemList.Count;
        }


        public double GetTotalPerType(string itemType)
        {
            double total = 0;
            foreach (Item order in itemList)
            {
                if (order.type == itemType)
                {
                    total += order.cost * order.soldCount;
                }
            }
            return total;
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

        // use for admin access stuffs
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
