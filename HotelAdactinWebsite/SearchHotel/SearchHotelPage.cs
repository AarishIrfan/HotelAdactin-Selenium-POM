using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdactinWebsite
{
    public class SearchHotelPage : BasePage
    {
        //LOCATORS//
        #region
        By location = By.Id("location");
        By Hotels = By.Id("hotels");
        By RoomType = By.Id("room_type");
        By NoofRooms = By.Id("room_nos");
        By CheckInDate = By.Id("datepick_in");
        By CheckOutDate = By.Id("datepick_out");
        By AdultsRoom = By.Id("adult_room");
        By ChildRoom = By.Id("child_room");
        By SearchBtn = By.Id("Submit");

        #endregion

        public void SearchHotel(string DropDownLocation,string DropDownHotel,string ChooseRoom, string SelectRooms,string EnterCheckInDate ,String EnterCheckOutDate ,String SelectAdultRoom,string SelectChildRoom)
        {
           
            Write(location, DropDownLocation);
            Write(Hotels, DropDownHotel);
            Write(RoomType, ChooseRoom);
            Write(NoofRooms, SelectRooms);
            Write(CheckInDate, EnterCheckInDate);
            Write(CheckOutDate, EnterCheckOutDate);
            Write(AdultsRoom, SelectAdultRoom);
            Write(ChildRoom, SelectChildRoom);
            Click(SearchBtn);
        }
    }
}
