using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeShop_DataLayer
{
    public class ItemDataService_Text : IItemDataService
    {

        string file_path = "items.txt";
        protected static List<Item> items = new List<Item>();
        protected string[] itemTypes = { "Beverage", "Snack" };

        int IDCounter = 0;


        public ItemDataService_Text()
        {
            GetDataFromFile();
            IntializeIDCounter();
        }

        private void IntializeIDCounter()
        {
            foreach (var item in items)
            {
                if (item.itemID > IDCounter)
                {
                    IDCounter = item.itemID;
                }
            }
        }


        private void UpdateFile()
        {
            var lines = new string[items.Count];

            for (int i = 0; i < items.Count; i++)
            {
                lines[i] = $"{items[i].name}|{items[i].cost}|{items[i].type}|{items[i].soldCount}";
            }

            File.WriteAllLines(file_path, lines);
        }

        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(file_path);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                items.Add(new Item(
                    Convert.ToInt32(parts[0]), 
                    parts[1],
                    Convert.ToDouble(parts[2]),
                    parts[3],
                    Convert.ToInt16(parts[4])
                ));
            }
        }

        public void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(IDCounter+1,itemName, itemCost, itemType));
            var newLine = $"{itemName}|{itemCost}|{itemType}|0";
            File.AppendAllText(file_path, newLine);
        }

        public void AddSoldCount(string name, int orderQuantity)
        {
            for (int i = 0;i < items.Count;i++)
            {
                if (items[i].name == name)
                {
                    items[i].soldCount += orderQuantity;
                    UpdateFile();
                    break;
                }
            }
        }



        public bool DeleteItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == itemName)
                {
                    items.RemoveAt(i);
                    UpdateFile();
                    return true;
                }
            }
            return false;
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
