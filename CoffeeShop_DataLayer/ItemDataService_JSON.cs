using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class ItemDataService_JSON : IItemDataService
    {
        internal List<Item> items;
        string file_path = "items.json";

        int IDCounter = 0;

        public ItemDataService_JSON()
        {
            ReadJsonDataFromFile();
            InitializeIDCounter();
        }

        private void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(file_path);

            items = JsonSerializer.Deserialize<List<Item>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void InitializeIDCounter()
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
            string jsonString = JsonSerializer.Serialize(items, new JsonSerializerOptions
            { WriteIndented = false });

            File.WriteAllText(file_path, jsonString);
        }

        public void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(IDCounter+1,itemName, itemCost, itemType));
            UpdateFile();

        }

        public void AddSoldCount(string name, int orderQuantity)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    items[i].soldCount += orderQuantity;
                    UpdateFile();

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

        //will be remove later

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
