using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CoffeeShopCommon;

namespace CoffeeShop_DataLayer
{
    public class ItemDataService_InMemory : IItemDataService
    {
        internal List<Item> items = new List<Item>();
        int IDcounter = 0;
        public ItemDataService_InMemory()
        {
            InitialDrinks();
            InitializeIDCounter();
        }

        private void InitializeIDCounter()
        {
            foreach (var item in items)
            {
                if (item.itemID > IDcounter)
                {
                    IDcounter = item.itemID;
                }
            }
        }

        public void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(IDcounter+1,itemName, itemCost, itemType));
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
            items.Add(new Item(0,"Milktea", 67.00, "Beverage"));
            items.Add(new Item(1,"Taco", 100.50, "Snack"));
            items.Add(new Item(2,"Coffee", 69.00, "Beverage"));
            items.Add(new Item(3,"Pizza", 120.99, "Snack"));
            items.Add(new Item(4,"Iced Coffee", 80.00, "Beverage"));
            items.Add(new Item(5,"Waffle", 50.25, "Snack"));
        }


        //will be remove later

        public String[] GetItemTypes()
        {
            HashSet<string> types = new HashSet<string>();
            foreach (Item item in items)
            {
                types.Add(item.type);
            }
            return types.ToArray();
        }

        public List<Item> GetItemsPerType(string itemType)
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

        public List<Item> GetItems()
        {
            return items;
        }

        public int GetItemCount()
        {
            return items.Count;
        }

        public double GetItemCost(string itemName)
        {
            foreach (Item item in items)
            {
                if (item.name == itemName)
                {
                    return item.cost;
                }
            }
            return 0; //null
        }

        public string GetItemType(string itemName)
        {
            foreach (Item item in items)
            {
                if (item.name == itemName)
                {
                    return item.type;
                }
            }
            return null;
        }
    }
}
