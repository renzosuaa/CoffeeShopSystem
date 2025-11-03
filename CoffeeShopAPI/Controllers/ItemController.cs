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

        [HttpGet("GetAllItem")]
        public IEnumerable<Item> GetAllItems()
        {
            return itemProcess.GetAllItems();
        }

        [HttpGet("GetItemTypes")]
        public List<String> GetItemTypes()
        {
            List<String> itemTypes = new List<string>( itemProcess.GetItemTypes());
            return itemTypes;
        }

        [HttpGet("Get Order Name")]
        public Item GetOrderName(int order)
        {
            return itemProcess.GetOrderName(order);
        }

        [HttpGet("GetOrderListCount")]
        public int GetOrderListCount()
        {
            return itemProcess.itemList.Count;
        }

        [HttpGet("GetTotalPerType")]
        public double GetTotalPerType(string itemType)
        {
            return itemProcess.GetTotalPerType(itemType);
        }

        [HttpGet("GetItemsPerType")]
        public List<Item> GetItemsPerType(string itemType)
        {
            return itemProcess.GetItemsPerType(itemType);
        }

        [HttpPatch("AddSoldCount")]
        public void AddSoldCount(List<Item> order, string email)
        {
            itemProcess.AddSoldCount(order, email);
        }

        [HttpPost("AddItem")]
        public void AddItem(string itemName, double itemCost, string itemType)
        {
            itemProcess.AddItem(itemName, itemCost, itemType);
        }

        [HttpDelete("DeleteItem")]
        public bool DeleteItem(string itemName)
        {
            return itemProcess.DeleteItem(itemName);
        }
    }
}
