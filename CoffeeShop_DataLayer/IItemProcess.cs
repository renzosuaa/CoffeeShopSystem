using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public interface IItemProcess 
    {
        public  void AddItem(string itemName, double itemCost, string itemType);
        public void AddSoldCount(string name, int orderQuantity);
        public bool DeleteItem(string itemName);

    }
}
 