using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdactinWebsite
{
    public class LoginPage : BasePage
    {
        #region LOCATORS

        By usernameTXT = By.Id("username");
        By passwordTXT = By.Name("password");
        By LoginBTN = By.Id("login");

        #endregion
        
        public void Login(string url,string user,string pass)
        {
            driver.Url = url;
            Write(usernameTXT, user);
            Write(passwordTXT, pass);
            Click(LoginBTN);
        }
    }
}
