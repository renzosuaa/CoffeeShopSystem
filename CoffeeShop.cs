using System.Runtime.InteropServices;
using CoffeeShopSystem_BusinessDataLogic;
namespace CoffeeShopSystem
{
    internal class CoffeeShop
    {
        static void Main(string[] args)
        {
            CoffeeShopProcess.InitialDrinks();
            Login();
        }

        static void Login()

        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("\tWelcome To Caffeine++");
            do
            {
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(" Enter Username: ");
                string userNameInput = GetUserInput();
                Console.WriteLine(" Enter Password: ");
                string userPasswordInput = GetUserInput();
                Console.WriteLine(" ------------------------------------------");

                if (CoffeeShopProcess.ValidateUser(userNameInput, userPasswordInput))
                {
                    Order();
                }
                else if (CoffeeShopProcess.ValidateAdmin(userNameInput, userPasswordInput))
                {
                    AdminAccess();
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Wrong Username Or Password!");
                    Console.WriteLine(" ------------------------------------------");
                }

                if (!IsDone("Program"))
                {
                    Login();
                }

                Environment.Exit(0);

            } while (true);

        }

        static void Order()
        {
            OrderingTemplate("Beverage");
            OrderingTemplate("Snack");
            CoffeeShopProcess.AddTotaltoReceipt();
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Order Success! \nHere is Your Receipt: ");
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(CoffeeShopProcess.orderReceipt);
            Console.WriteLine(" ------------------------------------------");
            CoffeeShopProcess.ClearReceipt();
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
            CoffeeShopProcess.AddItemTypeInReceipt(itemType);
            do
            {
                Console.WriteLine(itemType);
                Console.WriteLine(" ------------------------------------------");
                PrintItemMenu(CoffeeShopProcess.orderList);
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine("Enter Order: ");
                int order = GetUserInputInt();
                Console.WriteLine("Enter Quantity: ");
                int orderQuantity = GetUserInputInt();

                if (CoffeeShopProcess.orderList.Count() > order)
                {
                    CoffeeShopProcess.AddOrder(order, orderQuantity, itemType);
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Invalid Input");
                }

                if (IsDone(itemType))
                {
                    isOrdering = false;
                    CoffeeShopProcess.ClearOrderList();
                }
                
            } while (isOrdering);

            
        }

        static void AdminAccess()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("""
                [0] View Sold Summary
                [1] Add Item
                [2] Delete Item
                """);
            int choice = GetUserInputInt();
            if (choice == 0)
            {
                ViewSoldSummary();
            }
            else if (choice == 1)
            {
                AddItem();

            }
            else if (choice == 2)
            {
                DeleteItem();
            }
            else
            {
                AdminAccess();
            }

            if (!IsDone("Admin Access"))
            {
                AdminAccess();
            }

            return;

        }   

        static void PrintPerItemTypeSummary(string itemType)
        {          
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(itemType + " \t\t" + "COST" + "\t" + "Sold  Count" + "\t" + "Total");
            Console.WriteLine(" ------------------------------------------\n");
            PrintPerItemSummary(CoffeeShopProcess.GetItemsPerType(itemType));
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Total: " + CoffeeShopProcess.GetTotalSoldPerItemType(itemType));
            Console.WriteLine(" ------------------------------------------\n\n");
        }

        //yung sold thingy di pa tatanggal
        static void PrintPerItemSummary(List<Item> _items)
        {
            foreach (Item j in _items)
            {
                double totalSoldPerDrink = j.soldCount * j.cost;
                Console.WriteLine(j.name + " \t\t" + j.cost + "\t" + j.soldCount + "\t" + totalSoldPerDrink);
            }
        }
        
        static Boolean IsDone(string ActionType)
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Do You Want To Continue With " + ActionType + " ?");
            Console.WriteLine("[0] Yes  \t [1] No");
            Console.WriteLine("");
            int choice = GetUserInputInt();
            Console.WriteLine(" ------------------------------------------");

            if (choice == 0)
            {
                return false;
            }
            else if (choice == 1)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                IsDone(ActionType);
            }
            return false;

        }

        static void AddItem()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Enter Item Type: ");
            string itemType = GetUserInput();
            Console.WriteLine("Enter Item Name: ");
            string itemName = GetUserInput();
            Console.WriteLine("Enter Beverage Cost: ");
            double itemCost = GetUserInputDouble();
            CoffeeShopProcess.AddItem(itemName,itemCost,itemType);
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(itemName + " is ADDED successfully");
            Console.WriteLine(" ------------------------------------------");
        }

        static void DeleteItem()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Enter Beverage Name: ");
            string itemName = GetUserInput();

            if (CoffeeShopProcess.DeleteItem(itemName)) {
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(itemName + " is DELETED successfully");
                Console.WriteLine(" ------------------------------------------");
            }
            else
            {
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(itemName + " does NOT EXIST");
                Console.WriteLine(" ------------------------------------------");
            }
            
        }

        static void ViewSoldSummary()
        {
           
            PrintPerItemTypeSummary("Beverage");
            PrintPerItemTypeSummary("Snack");
            Console.WriteLine("Total: " + CoffeeShopProcess.GetTotalPriceOfOrder());
        }

        static string GetUserInput()
        {
            return Console.ReadLine();
        }

        static int GetUserInputInt()
        {
            return Convert.ToInt16(GetUserInput());
        }

        static double GetUserInputDouble()
        {
            return Convert.ToDouble(GetUserInput());
        }

    }
    
}
