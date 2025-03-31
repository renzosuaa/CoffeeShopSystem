using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopSystem_BusinessDataLogic
{
    public class ItemProcess
    {
        public static List<Item> items = new List<Item>();
        public static string[] itemTypes = { "Beverage", "Snack" };

        public static void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(itemName, itemCost, itemType));
        }

        public static void AddSoldCount(string name, int orderQuantity)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    items[i].soldCount += orderQuantity;
                }
            }
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

        public static int GetItemCount()
        {
            return items.Count;
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
