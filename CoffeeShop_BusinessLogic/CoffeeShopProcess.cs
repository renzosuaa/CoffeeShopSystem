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
        internal ItemDataService_InMemory DataProcess = new ItemDataService_InMemory();
        public  List<Item> itemList  = new List<Item>();
        MailProcess mailProcess;
        public CoffeeShopProcess(MailProcess mailProcess)
        {
            this.mailProcess = mailProcess;
            itemList = new List<Item>(DataProcess.GetItems());
        }

        
        public  List<Item> GetAllItems()
        {
            return itemList;
        }

        public void AddSoldCount(List<Item> order, string email)
        {
            foreach (Item item in order)
            {
                DataProcess.AddSoldCount(item.name, item.soldCount);
            }
            string receipt = "";            
            foreach(Item item in order)
            {
                receipt += $"{item.cost} {item.name} = {item.cost * item.soldCount}\n";
            }

            MailRequest request = new MailRequest(email, "receipt", receipt);
            mailProcess.SendEmail(request);
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
