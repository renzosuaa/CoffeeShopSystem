using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class ItemProcess_JSON : AItemProcess , IItemProcess
    {
        
        public void AddItem(string itemName, double itemCost, string itemType)
        {
            throw new NotImplementedException();
            
        }

        public void AddSoldCount(string name, int orderQuantity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
