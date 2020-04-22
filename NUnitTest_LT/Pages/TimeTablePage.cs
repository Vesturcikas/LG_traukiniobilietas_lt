using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_LT.Pages
{
    public class TimeTablePage : BasePage
    {

        public TimeTablePage(IWebDriver drive) : base(drive) { }

        public TimeTablePage ClickTimetable()
        {
            return this;
        }

        public TimeTablePage ClickSchedules()
        {
            return this;
        }

        public TimeTablePage SelectFrom()
        {
            return this;
        }

        public TimeTablePage SelectTo()
        {
            return this;
        }

        public TimeTablePage ClickSearch()
        {
            return this;
        }
    }
}
