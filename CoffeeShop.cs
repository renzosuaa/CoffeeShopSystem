using System.Runtime.InteropServices;

namespace CoffeeShopSystem
{
    internal class CoffeeShop
    {
        static List<Item> items = new List<Item>();
        static void Main(string[] args)
        {
            InitialDrinks();
            Login();
        }

        static void Login()
        {
            string username = "user1", userPassword = "123", adminName = "admin1", adminPassword = "admin123";
            bool isNotDoneOrdering = true;
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

                if (userNameInput == username && userPasswordInput == userPassword)
                {
                    Order();
                }
                else if (userNameInput == adminName && adminPassword == userPasswordInput)
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

            } while (isNotDoneOrdering);

        }

        static void Order()
        {
            string receipt = "";
            receipt += OrderingTemplate("Beverage");
            receipt += OrderingTemplate("Snack");
            receipt += " Total: " + (GetTotalSoldPerItemType("Beverage") + GetTotalSoldPerItemType("Snack"));
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Order Success! \n Here is Your Receipt: ");
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(receipt);
            Console.WriteLine(" ------------------------------------------");

        }

        static void PrintItemMenu(List<Item> menu)
        {
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine("[" + i + "] " + menu[i].name + ":  " + menu[i].cost);
            }
        }
        static void AddSoldCount(string name, int orderQuantity)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name ==name)
                {
                    items[i].soldCount += orderQuantity;
                }
            }
        }

        static string OrderingTemplate(String itemType)
        {
            Boolean isOrdering = true;
            List<Item> orderList = new List<Item>(GetItemsPerType(itemType));
            String orderReceipt = itemType + "\n";
            do
            {
                Console.WriteLine(itemType);
                Console.WriteLine(" ------------------------------------------");
                PrintItemMenu(orderList);
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine("Enter Order: ");
                int order = GetUserInputInt();
                Console.WriteLine("Enter Quantity: ");
                int orderQuantity = GetUserInputInt();
                if (orderList.Count() > order)
                {
                    orderReceipt += orderQuantity + " " + orderList[order].name + " :" + orderQuantity * orderList[order].cost + "\n";
                    AddSoldCount(orderList[order].name, orderQuantity);
                }
                else
                {
                    Console.WriteLine(" ------------------------------------------");
                    Console.WriteLine("Invalid Input");
                }

                if (IsDone(itemType))
                {
                    isOrdering = false;
                }
                orderList.Clear();

            } while (isOrdering);

            return orderReceipt;
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

        static double GetTotalSoldPerItemType(string itemType)
        {
            double total = 0;
            List<Item> _items = new List<Item>(GetItemsPerType(itemType));
            foreach (Item item in _items)
            {
                double totalSoldPerDrink = item.soldCount * item.cost;          
                total += totalSoldPerDrink;
            }
            return total;
        }

        static void PrintPerItemTypeSummary(string itemType)
        {          
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(itemType + " \t\t" + "COST" + "\t" + "Sold  Count" + "\t" + "Total");
            Console.WriteLine(" ------------------------------------------\n");
            List<Item> _items = GetItemsPerType(itemType);

            PrintPerItemSummary(_items);
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Total: " + GetTotalSoldPerItemType(itemType));
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

        static List<Item> GetItemsPerType(string itemType)
        {
            List<Item> _items = new List<Item>();
            foreach (Item i in items)
            {
                if (i.type == itemType)
                {
                    _items.Add(i);
                }
              
            }
            return _items;
        }

        static void InitialDrinks()
        {
            items.Add(new Item("Milktea", 67.00, "Beverage"));
            items.Add(new Item("Taco", 100.50, "Snack"));
            items.Add(new Item("Coffee", 69.00, "Beverage"));
            items.Add(new Item("Pizza", 120.99, "Snack"));
            items.Add(new Item("Iced Coffee", 80.00, "Beverage"));
            items.Add(new Item("Waffle", 50.25, "Snack"));

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

            items.Add(new Item(itemName, itemCost, itemType));
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(itemName + " is ADDED successfully");
            Console.WriteLine(" ------------------------------------------");
        }

        static void DeleteItem()
        {
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine("Enter Beverage Name: ");
            string itemName = GetUserInput();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == itemName)
                {
                    items.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine(itemName + " is DELETED successfully");
            Console.WriteLine(" ------------------------------------------");
        }

        static void ViewSoldSummary()
        {
            double totalBeverage = GetTotalSoldPerItemType("Beverage");
            double totalSnacks = GetTotalSoldPerItemType("Snack");
            PrintPerItemTypeSummary("Beverage");
            PrintPerItemTypeSummary("Snack");
            Console.WriteLine("Total: " + (totalBeverage + totalSnacks));
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
    public class Item
    {
        public string name;
        public double cost;
        public int soldCount = 0;
        public string type;

        public Item(string name, double cost, string type)
        {
            this.name = name;
            this.cost = cost;
            this.type = type;
        }
    }
}
