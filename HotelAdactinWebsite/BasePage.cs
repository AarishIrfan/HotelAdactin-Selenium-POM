using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdactinWebsite
{
   public class BasePage
    {
        public static IWebDriver driver;
        public static void SeleniumInit(string browser)
        {
            driver = new ChromeDriver();
        }
        public static void SeleniumClose()
        {
            driver.Close();
        }
        public void Write(By by, String Text)
        {
            driver.FindElement(by).SendKeys(Text);
        }
        public void Click(By by)
        {
            driver.FindElement(by).Click();
        }
        public void Clear(By by)
        {
            driver.FindElement(by).Clear(); 
        }
    }
}
