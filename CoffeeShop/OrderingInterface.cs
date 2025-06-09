
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCommon;
using CoffeeShopSystem_BusinessLogic;

namespace CoffeeShopSystem
{
    internal class OrderingInterface
    {
        OrderProcess process = new OrderProcess();
        internal void Order()
        {
            Console.WriteLine(" ------------------------------------------");
            foreach (string item in CoffeeShop.process.GetItemTypes())
            {
                OrderingTemplate();
            }
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Order Success! \nHere is Your Receipt: ");
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(process.PrintReceipt());
            Console.WriteLine(" ------------------------------------------");
        }

        static void PrintItemMenu(List<Item> menu)
        {
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine("[" + i + "] " + menu[i].name + ":  " + menu[i].cost);
            }
        }

        void OrderingTemplate()
        {
            Boolean isOrdering = true;
            do
            {
                //pprint here all the items
                Console.WriteLine("Items: ");
                Console.WriteLine(" ------------------------------------------");
                PrintItemMenu(CoffeeShopProcess.GetAllItems());
                Console.WriteLine(" ------------------------------------------");

                Console.WriteLine("Enter Order: ");
                int order = CoffeeShopProcess.GetUserInputInt();
                Console.WriteLine("Enter Quantity: ");
                int orderQuantity = CoffeeShopProcess.GetUserInputInt();


                if (CoffeeShopProcess.GetOrderListCount() > order)
                {
                    Item item = CoffeeShopProcess.GetOrderName(order);
                    item.soldCount = orderQuantity;
                    process.AddOrder(item);
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Invalid Input");
                }

                if (CoffeeShop.IsDone("Ordering"))
                {
                    isOrdering = false;
                }

            } while (isOrdering);
        }
    }
}