using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdactinWebsite
{
   public class BookHotelPage : BasePage
    {
        //LOCATORS

        #region
        By FirstName = By.Id("first_name");
        By lastname = By.Id("last_name");
        By Address = By.Id("address");
        By CreditCardNum = By.Id("cc_num");
        By CreditCardType = By.Id("cc_type");
        By CardExpiryMonth = By.Id("cc_exp_month");
        By CardExpiryYear = By.Id("cc_exp_year");
        By EnterCVV = By.Id("cc_cvv");
        By SubmitBtn = By.Id("book_now");
        
        #endregion

        public void BookHotel(string FName,string LName, string BillingAddress, string CreditCardNumber , string TypeofCardCard ,string ExpiryMonth , string ExpiryYear , string CreditCardCVV )
        {
            Write(FirstName, FName);
            Write(lastname, LName);
            Write(Address, BillingAddress);
            Write(CreditCardNum, CreditCardNumber);
            Write(CreditCardType, TypeofCardCard);
            Write(CardExpiryMonth, ExpiryMonth);
            Write(CardExpiryYear, ExpiryYear);
            Write(EnterCVV, CreditCardCVV);
            Click(SubmitBtn);
            
        }
    }
}
