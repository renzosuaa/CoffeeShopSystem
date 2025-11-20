using CoffeeShopCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopAPI.Controllers
{
    [Route("CoffeeShopAPI/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        CoffeeShopSystem_BusinessLogic.CoffeeShopProcess itemProcess;
        
        public ItemController(CoffeeShopSystem_BusinessLogic.CoffeeShopProcess itemProcess)
        {
            this.itemProcess = itemProcess;
        }

        [HttpGet]
        public IEnumerable<Item> GetAllItems()
        {
            return itemProcess.GetAllItems();
        }

        [HttpGet("types")]
        public List<String> GetItemTypes()
        {
            List<String> itemTypes = new List<string>( itemProcess.GetItemTypes());
            return itemTypes;
        }

        [HttpGet("{orderID}")]
        public Item GetOrderName(int orderid)
        {
            return itemProcess.GetOrderName(orderid);
        }

        [HttpGet("count")]
        public int GetOrderListCount()
        {
            return itemProcess.itemList.Count;
        }

        [HttpGet("total-per-type/{itemType}")]
        public double GetTotalPerType(string itemType)
        {
            return itemProcess.GetTotalPerType(itemType);
        }

        [HttpGet("type/{itemType}")]
        public List<Item> GetItemsPerType(string itemType)
        {
            return itemProcess.GetItemsPerType(itemType);
        }

        [HttpPatch("sold-count")]
        public void AddSoldCount(List<Item> order, string email)
        {
            itemProcess.AddSoldCount(order, email);
        }

        [HttpPost]
        public void AddItem(string itemName, double itemCost, string itemType)
        {
            itemProcess.AddItem(itemName, itemCost, itemType);
        }

        [HttpDelete("{itemName}")]
        public bool DeleteItem(string itemName)
        {
            return itemProcess.DeleteItem(itemName);
        }
    }
}
