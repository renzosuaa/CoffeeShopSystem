
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
        OrderProcess process;
        int userID = 0;
        public OrderingInterface(int userID)
        {
            process = new OrderProcess(userID);
            this.userID = userID;
        }

        
        internal void Order()
        {
            Console.WriteLine("------------------------------------------");
            OrderingTemplate();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Order Success! \nHere is Your Receipt: ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(process.PrintReceipt());
            Console.WriteLine("------------------------------------------");
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
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("Items: ");
                Console.WriteLine("------------------------------------------");
                PrintItemMenu(CoffeeShop.process.GetAllItems());
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Options:");
                Console.WriteLine("[V] View Cart");
                Console.WriteLine("[C] Clear Cart");
                if (userID != 0)
                {
                    Console.WriteLine("[S] See Orders");
                }
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("Enter Order: ");
                string strorder = CoffeeShopProcess.GetUserInput();
                try
                {
                    
                    int order = Convert.ToInt32(strorder);
                    Console.WriteLine("Enter Quantity: ");
                    int orderQuantity = CoffeeShopProcess.GetUserInputInt();

                    if (CoffeeShop.process.GetOrderListCount() > order)
                    {
                        Item item = CoffeeShop.process.GetOrderName(order);
                        Item newItem = new Item(item.itemID,item.name, item.cost, item.type, orderQuantity);
                        process.AddOrder(newItem);
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Invalid Input");
                    }

                    if (CoffeeShop.IsDone("Ordering"))
                    {
                        isOrdering = false;
                        CoffeeShop.process.AddSoldCount(process.GetAllOrderItems());
                        process.SaveCurrentOrder();
                    }
                }
                catch (FormatException)
                {
                    if (strorder.ToUpper().Trim() == "V")
                    {
                        Console.WriteLine(process.PrintReceipt());
                    }
                    else if (strorder.ToUpper().Trim() == "C")
                    {
                        process.ClearOrder();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Cart Cleared.");
                        Console.WriteLine("------------------------------------------");
                        
                    }
                    else if (strorder.ToUpper().Trim() == "S")
                    {
                        if (userID != 0)
                        {
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine(process.GetUserOrders());
                            
                            Console.WriteLine("------------------------------------------");
                        } else
                        {
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("Invalid Input, Please enter a valid number or 'done' to finish ordering.");
                            Console.WriteLine("------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Invalid Input, Please enter a valid number or 'done' to finish ordering.");
                        Console.WriteLine("------------------------------------------");
                    }
                }
            } while (isOrdering);
        }

    }
}