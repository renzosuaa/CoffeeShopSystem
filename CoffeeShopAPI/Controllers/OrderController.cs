using CoffeeShopCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopAPI.Controllers
{
    [Route("CoffeeShopAPI/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        CoffeeShopSystem_BusinessLogic.OrderProcess orderProcess = new CoffeeShopSystem_BusinessLogic.OrderProcess(0);

        [HttpGet]
        public List<Item> GetAllOrderItems ()
        {
            return orderProcess.GetAllOrderItems();
        }

        [HttpGet("item-types")]
        List<string> GetOrderItemTypes()
        {
            HashSet<string> types = new HashSet<string>();
            foreach (Item item in GetAllOrderItems())
            {
                types.Add(item.type);
            }
            return types.ToList();
        }

        [HttpGet("total-per-type/{itemType}")]
        public double GetTotalPerType(string itemType)
        {
            double total = 0;
            foreach (Item order in GetAllOrderItems())
            {
                if (order.type == itemType)
                {
                    total += order.cost * order.soldCount;
                }
            }
            return total;
        }


        [HttpDelete]
        public void ClearOrder()
        {
           orderProcess.ClearOrder();
        }

        [HttpPost("items")]
        public void AddOrder(Item item)
        {
            orderProcess.AddOrder(item);
        }


        [HttpPost]
        public void SaveCurrentOrder()
        {
            orderProcess.SaveCurrentOrder();
        }


        [HttpGet("user/orders")]
        public void GetUserOrders()
        {
            orderProcess.GetUserOrders();
        }



    }
}
