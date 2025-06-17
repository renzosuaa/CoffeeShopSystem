using CoffeeShopCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace CoffeeShopAPI.Controllers
{
    [Route("CoffeeShopAPI/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        CoffeeShopSystem_BusinessLogic.UserProcess userProcess = new CoffeeShopSystem_BusinessLogic.UserProcess();

        [HttpGet("ValidatePassword")]
        public bool ValidatePassword(string password, string password2)
        {
            return userProcess.ValidatePassword(password, password2);
        }

        [HttpGet("ValidateAdmin")]
        public bool ValidateAdmin(string email, string password)
        {
            return userProcess.ValidateAdmin(email, password);
        }

        [HttpGet("ValidateUser")]
        public bool ValidateUser(string email, string password)
        {
            return userProcess.ValidateUser(email, password);
        }

        [HttpPost("RegisterUser")]
        public void RegisterUser(string email, string password)
        {
            userProcess.RegisterUser(email, password);
        }
    }
}
