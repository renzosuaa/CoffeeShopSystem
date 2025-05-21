using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoffeeShop_DataLayer
{
    public class ItemProcess_Text : AItemProcess, IItemProcess
    {
        string file_path = "items.txt";

        public ItemProcess_Text()
        {
            GetDataFromFile();
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
                    parts[0],
                    Convert.ToDouble(parts[1]),
                    parts[2],
                    Convert.ToInt16(parts[3])
                ));
            }
        }

        public void AddItem(string itemName, double itemCost, string itemType)
        {
            items.Add(new Item(itemName, itemCost, itemType));
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
    }
}
