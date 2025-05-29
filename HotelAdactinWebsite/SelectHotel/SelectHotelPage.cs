using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdactinWebsite
{
    public class SelectHotelPage : BasePage
    {
        //LOCATORS


        By RadioBtn = By.Id("radiobutton_0");
        By ContinueBtn = By.Id("continue");
       

        public void SelectHotel()
        {
            Click(RadioBtn);
            Click(ContinueBtn);
        }
    }
}
