using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CoffeeShopCommon;

namespace CoffeeShop_DataLayer
{
    public class ItemProcess_InMemory : AItemProcess, IItemProcess
    {
        ItemProcess_InMemory()
        {
            InitialDrinks();
        }

        public void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(itemName, itemCost, itemType));
        }

        public  void AddSoldCount(string name, int orderQuantity)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    items[i].soldCount += orderQuantity;
                }
            }
        }

        public  bool DeleteItem(string itemName)
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

        public void InitialDrinks()
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
