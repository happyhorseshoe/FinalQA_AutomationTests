using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomatedTesting.PageObjectModels
{
    internal class CalendarMonth
    {

        internal string CalendarUrl = "http://seleniumpractise.blogspot.com/2016/08/how-to-handle-calendar-in-selenium.html";

        string calendarField = "//*[text()='Date: ']/input";
        internal By CalendarField { get => By.XPath(calendarField); }

        private string getAllDates = "//table[@class='ui-datepicker-calendar']//td";
        internal By GetAllDates { get => By.XPath(getAllDates); }


        //internal string MonthMayUrl = "https://www.timeanddate.com/calendar/monthly.html?year=2023&month=5&country=1";

        //string monthDropDownMenu = "month";
        //internal By MonthDropDownMenu => By.Id(monthDropDownMenu);




    }

}
