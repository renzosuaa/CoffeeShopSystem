using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop_DataLayer;
using CoffeeShopCommon;

namespace CoffeeShopSystem_BusinessLogic
{
    public class UserProcess
    {
        UserDataService_InMemory userDataService = new UserDataService_InMemory();

        MailProcess MailProcess;

        public UserProcess(MailProcess mailProcess)
        {
            MailProcess = mailProcess;
        }

        public bool ValidatePassword(string password, string password2)
        {
            return userDataService.ValidatePassword(password, password2);
        }

        public bool ValidateAdmin(string email, string password)
        {
            return userDataService.ValidateAdmin(email, password);
        }

        public void RegisterUser(string email, string password)
        {
            userDataService.RegisterUser(email, password);
            MailRequest request = new MailRequest(email, "account_creation");
            MailProcess.SendEmail(request);
        }

        public bool ValidateUser(string email,string password)
        {
            return userDataService.ValidateUser(email, password);
        }

        public int GetUserID(string email)
        {
            return userDataService.GetUserID(email);
        }

    }
}
