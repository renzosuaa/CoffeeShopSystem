using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSystem_BusinessDataLogic
{
    public class CoffeeShopProcess
    {
        static string username = "user1", userPassword = "123", adminName = "admin1", adminPassword = "admin123";
        static List<Item> items = new List<Item>();
        public static string orderReceipt = "";
        public static List<Item> orderList = new List<Item>();
        public static string[] itemTypes = {"Beverage","Snack"};

        public static bool ValidateUser(string usernameInput,string passwordInput)
        {
            return (usernameInput == username && passwordInput == userPassword);
        }

        public static bool ValidateAdmin(string usernameInput, string passwordInput)
        {
            return (usernameInput == adminName && passwordInput == adminPassword);
        }

        public static void AddOrder(int order, int quantity,string itemType)
        { 
            List<Item> orderList = new List<Item>(GetItemsPerType(itemType));
            orderReceipt += order + " " + orderList[order].name + " :" + quantity * orderList[order].cost + "\n";
            AddSoldCount(orderList[order].name, quantity);
        }

        public static void AddItemToOrderList(string itemType)
        {
            foreach (Item _item in GetItemsPerType(itemType))
            {
                orderList.Add(_item);
            }
        }

        public static void AddItemTypeInReceipt(string itemType)
        {
            orderReceipt += itemType + " \n";
        }

        public static void AddTotaltoReceipt()
        {
            
            orderReceipt += " Total: " + GetTotalPriceOfOrder();

        }

        public static double GetTotalPriceOfOrder()
        {
            double total = 0.00;
            foreach (string itemType in itemTypes)
            {
                total += GetTotalSoldPerItemType(itemType);
            }
            
            return total;

        }

        public static double GetTotalSoldPerItemType(string itemType)
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

        public static bool DeleteItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == itemName)
                {
                    items.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(itemName, itemCost, itemType));
        }

        static void AddSoldCount(string name, int orderQuantity)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    items[i].soldCount += orderQuantity;
                }
            }
        }

        public static List<Item> GetItemsPerType(string itemType)
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

        public static void ClearReceipt()
        {
            orderReceipt = "";
        }

        public static void ClearOrderList()
        {
            orderList.Clear();
        }
        public static void InitialDrinks()
        {
            items.Add(new Item("Milktea", 67.00, "Beverage"));
            items.Add(new Item("Taco", 100.50, "Snack"));
            items.Add(new Item("Coffee", 69.00, "Beverage"));
            items.Add(new Item("Pizza", 120.99, "Snack"));
            items.Add(new Item("Iced Coffee", 80.00, "Beverage"));
            items.Add(new Item("Waffle", 50.25, "Snack"));

        }
    }
}
