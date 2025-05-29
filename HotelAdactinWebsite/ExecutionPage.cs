using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace HotelAdactinWebsite
{
    [TestClass]
    public class ExecutionPage
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestInitialize]
        public void TestInit()
        {
            BasePage.SeleniumInit("Chrome");
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.SeleniumClose();
        }

        [TestMethod]
        [TestCategory("Login")]
        public void LoginTC001()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
        }
        [TestMethod]
        [TestCategory("SearchHotel")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "SearchHotelTC001", DataAccessMethod.Sequential)]
        public void SearchHotelTC001()
        {

            string DropDownLocation = TestContext.DataRow["DropDownLocation"].ToString();
            string DropDownHotel = TestContext.DataRow["DropDownHotel"].ToString();
            string ChooseRoom = TestContext.DataRow["ChooseRoom"].ToString();
            string SelectRooms = TestContext.DataRow["SelectRooms"].ToString(); 
            string EnterCheckInDate = TestContext.DataRow["EnterCheckInDate"].ToString();
            string EnterCheckOutDate = TestContext.DataRow["EnterCheckOutDate"].ToString();
            string SelectAdultRoom = TestContext.DataRow["SelectAdultRoom"].ToString();
            string SelectChildRoom = TestContext.DataRow["SelectChildRoom"].ToString();

            //Initialization
            #region
            LoginPage loginPage = new LoginPage();
            SearchHotelPage searchPage = new SearchHotelPage();
            #endregion

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.SearchHotel(DropDownLocation,DropDownHotel,ChooseRoom,SelectRooms,EnterCheckInDate,EnterCheckOutDate,SelectAdultRoom,SelectChildRoom);
        }
        [TestMethod]
        [TestCategory("SelectHotel")]
        public void SelectHotelTC001()
        {
            // Initialization
            #region
            LoginPage loginPage = new LoginPage();
            SearchHotelPage searchPage = new SearchHotelPage();
            SelectHotelPage selectHotelPage = new SelectHotelPage();
            #endregion

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.SearchHotel("Melbourne", "Hotel Hervey", "Deluxe", "3 - Three", "12/04/2023", "13/04/2023", "4 - Four", "4 - Four");
            selectHotelPage.SelectHotel();
        }
        [TestMethod]
        [TestCategory("BookHotel")]
        public void BookHotelTC001()
        {
            // Initialization
            #region
            LoginPage loginPage = new LoginPage();
            SearchHotelPage searchPage = new SearchHotelPage();
            SelectHotelPage selectHotelPage = new SelectHotelPage();
            BookHotelPage bookHotelPage = new BookHotelPage();
            #endregion

            loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            searchPage.SearchHotel("Melbourne", "Hotel Hervey", "Deluxe", "3 - Three", "12/04/2023", "13/04/2023", "4 - Four", "4 - Four");
            selectHotelPage.SelectHotel();
            bookHotelPage.BookHotel("Aarish","Irfan","Los Angeles","02033484838383737732231231","VISA","January","2022","123");
        }

    }
}
