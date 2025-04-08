﻿
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
        static Order Orders = new Order();
        internal static void Order()
        {
            Console.WriteLine(" ------------------------------------------");
            foreach (string item in CoffeeShopProcess.GetItemTypes())
            {
                OrderingTemplate(item);
            }
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Order Success! \nHere is Your Receipt: ");
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(Orders.PrintReceipt());
            Console.WriteLine(" ------------------------------------------");
        }

        static void PrintItemMenu(List<Item> menu)
        {
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine("[" + i + "] " + menu[i].name + ":  " + menu[i].cost);
            }
        }

        static void OrderingTemplate(String itemType)
        {
            Boolean isOrdering = true;
            CoffeeShopProcess.AddItemToOrderList(itemType);
            do
            {
                Console.WriteLine(itemType);
                Console.WriteLine(" ------------------------------------------");
                PrintItemMenu(CoffeeShopProcess.orderList);
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine("Enter Order: ");
                int order = CoffeeShopProcess.GetUserInputInt();
                Console.WriteLine("Enter Quantity: ");
                int orderQuantity = CoffeeShopProcess.GetUserInputInt();

                if (CoffeeShopProcess.GetOrderListCount() > order)
                {
                    string orderName = CoffeeShopProcess.GetOrderName(order);
                    CoffeeShopProcess.AddSoldCountOfOrder(orderName, orderQuantity);
                    Orders.AddOrder(orderName, orderQuantity);
                    
                    
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Invalid Input");
                }

                if (CoffeeShop.IsDone(itemType))
                {
                    isOrdering = false;
                    CoffeeShopProcess.ClearOrderList();
                }

            } while (isOrdering);
        }
    }
}
