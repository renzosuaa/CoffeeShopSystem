using System.Collections.Specialized;
using System.Runtime.InteropServices;
using CoffeeShopSystem_BusinessLogic;
using CoffeeShopCommon;
namespace CoffeeShopSystem
{
    internal class CoffeeShop
    {
        internal static CoffeeShopProcess process;
        static void Main(string[] args)
        {
            process = new CoffeeShopProcess();
            StartUp(); 
        }

        static void StartUp()
        {
            do
            {
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine("\tWelcome To Caffeine++");
                Console.WriteLine(" ------------------------------------------\n");
                Console.WriteLine("""
                [0] Login
                [1] Register
                [2] Continue As Guest
                """);
                Console.WriteLine(" ------------------------------------------");
                int input = CoffeeShopProcess.GetUserInputInt();

                if (input == 0)
                {
                    Login();
                }
                else if (input == 1)
                {
                    Register();
                }
                else if (input == 2)
                {
                    new OrderingInterface().Order();
                }
                else
                {
                    Console.WriteLine("Error: Invalid Output");
                    Console.WriteLine(" ------------------------------------------");
                }

                if (IsDone("Program"))
                {
                    Environment.Exit(0);
                }
            } while (true);
        }

        static void Register()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Enter Username:");
            string userNameInput = CoffeeShopProcess.GetUserInput();
            Console.WriteLine("Enter Password:");
            string userPassword = CoffeeShopProcess.GetUserInput();
            Console.WriteLine("Confirm Password:");
            string userConfirmPassword = CoffeeShopProcess.GetUserInput();
            Console.WriteLine(" ------------------------------------------");

            if (!UserProcess.ValidatePassword(userPassword, userConfirmPassword))
            {
                Console.WriteLine("Error: Password Don't Match!");
                Console.WriteLine(" ------------------------------------------");
                Register();
            }
            else
            {
                UserProcess.RegisterUser(userNameInput, userPassword);
                Console.WriteLine("Success: Registration Complete");
                StartUp();
            }

        }

        static void Login()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(" Enter Username: ");
            string userNameInput = CoffeeShopProcess.GetUserInput();
            Console.WriteLine(" Enter Password: ");
            string userPasswordInput = CoffeeShopProcess.GetUserInput();
            Console.WriteLine(" ------------------------------------------");

            if (UserProcess.ValidateUser(userNameInput, userPasswordInput))
            {
                new OrderingInterface().Order();
            }
            else if (UserProcess.ValidateAdmin(userNameInput, userPasswordInput))
            {
                AdminAccess();
            }
            else
            {
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine("Error: Wrong Username or Password!");
                Console.WriteLine(" ------------------------------------------");
            }

        }

        static void AdminAccess()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("""
                [0] View Sold Summary
                [1] Add Item
                [2] Delete Item
                """);
            /*
                [3] Hide Item
                [4] Unhide Item
                [5] Add Item Type
                [6] Delete Item Type
                [7] Hide Item Type
                [8] Unhide Item Type
             */
            int choice = CoffeeShopProcess.GetUserInputInt();

            switch (choice)
            {
                case 0:
                    ViewSoldSummary();
                    break;
                case 1:
                    AddItem();
                    break;
                case 2:
                    DeleteItem();
                    break;
                default:
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Error: Invalid Input!");
                    AdminAccess();
                    break;
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
            PrintPerItemSummary(process.GetItemsPerType(itemType));
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Total: " + process.GetTotalSoldPerItemType(itemType));
            Console.WriteLine(" ------------------------------------------\n\n");
        }

        static void PrintPerItemSummary(List<Item> _items)
        {
            foreach (Item j in _items)
            {
                double totalSoldPerDrink = j.soldCount * j.cost;
                Console.WriteLine(j.name + " \t\t" + j.cost + "\t" + j.soldCount + "\t" + totalSoldPerDrink);
            }
        }

        internal static Boolean IsDone(string ActionType)
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Do You Want To Continue With " + ActionType + " ?");
            Console.WriteLine("[0] Yes  \t [1] No");
            Console.WriteLine("");
            int choice = CoffeeShopProcess.GetUserInputInt();
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
            string itemType = CoffeeShopProcess.GetUserInput();
            Console.WriteLine("Enter Item Name: ");
            string itemName = CoffeeShopProcess.GetUserInput();
            Console.WriteLine("Enter " + itemType + "Cost: ");
            double itemCost = CoffeeShopProcess.GetUserInputDouble();
            process.AddItem(itemName, itemCost, itemType);
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(itemName + " is ADDED successfully");
            Console.WriteLine(" ------------------------------------------");
        }

        static void DeleteItem()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Enter Item Name: ");
            string itemName = CoffeeShopProcess.GetUserInput();

            if (process.DeleteItem(itemName))
            {
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
            var itemTypes = process.GetItemTypes();
            if (itemTypes == null || itemTypes.Count() == 0)
            {
                Console.WriteLine("No items sold yet.");
                return;
            }

            double grandTotal = 0;
            foreach (string itemType in itemTypes)
            {
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(itemType + " \t\t" + "COST" + "\t" + "Sold  Count" + "\t" + "Total");
                Console.WriteLine(" ------------------------------------------");

                var items = process.GetItemsPerType(itemType);
                if (items != null && items.Count > 0)
                {
                    double totalSoldPerType = 0;
                    foreach (var item in items)
                    {
                        double totalSoldPerItem = item.soldCount * item.cost;
                        totalSoldPerType += totalSoldPerItem;
                        Console.WriteLine(item.name + " \t\t" + item.cost + "\t" + item.soldCount + "\t" + totalSoldPerItem);
                    }
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Total for " + itemType + ": " + totalSoldPerType);
                    grandTotal += totalSoldPerType;
                }
                else
                {
                    Console.WriteLine("No items sold in this category.");
                }
                Console.WriteLine(" ------------------------------------------\n");
            }
            Console.WriteLine("Grand Total: " + grandTotal);
        }
    }
}