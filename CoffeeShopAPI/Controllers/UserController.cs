using CoffeeShopCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace CoffeeShopAPI.Controllers
{
    [Route("CoffeeShopAPI/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        CoffeeShopSystem_BusinessLogic.UserProcess userProcess;

        public UserController(CoffeeShopSystem_BusinessLogic.UserProcess userProcess)
        {
            this.userProcess = userProcess;
        }
        
        [HttpPost("validate-password")]
        public bool ValidatePassword(string password, string password2)
        {
            return userProcess.ValidatePassword(password, password2);
        }

        [HttpPost("validate-admin")]
        public bool ValidateAdmin(string email, string password)
        {
            return userProcess.ValidateAdmin(email, password);
        }

        [HttpPost("validate-user")]
        public bool ValidateUser(string email, string password)
        {
            return userProcess.ValidateUser(email, password);
        }

        [HttpGet("id/{email}")]
        public int GetUserID(string email)
        {
            return userProcess.GetUserID(email);
        }


        [HttpPost("register")]
        public void RegisterUser(string email, string password)
        {
            userProcess.RegisterUser(email, password);
        }
    }
}
