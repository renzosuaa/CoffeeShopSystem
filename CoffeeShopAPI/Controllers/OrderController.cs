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

        [HttpGet("GetOrderItemTypes")]
        List<string> GetOrderItemTypes()
        {
            HashSet<string> types = new HashSet<string>();
            foreach (Item item in GetAllOrderItems())
            {
                types.Add(item.type);
            }
            return types.ToList();
        }

        [HttpGet("GetTotalPerType")]
        double GetTotalPerType(string itemType)
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

        [HttpDelete("ClearOrder")]
        public void ClearOrder()
        {
           orderProcess.ClearOrder();
        }

        [HttpPost("AddToOrder")]
        public void AddOrder(Item item)
        {
            orderProcess.AddOrder(item);
        }


        [HttpPost("SaveCurrentOrder")]
        public void SaveCurrentOrder()
        {
            orderProcess.SaveCurrentOrder();
        }


        [HttpGet("GetUserOrders")]
        public void GEtUserOrders(Item item)
        {
            orderProcess.GetUserOrders();
        }



    }
}
