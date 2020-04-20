using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_LT.Pages
{
    public class PassengersPage : BasePage
    {
        //Top Navigation Elements
        private IWebElement topNavbar => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement passengersNavbar => topNavbar.FindElement(By.CssSelector(".top-passenger"));

        public PassengersPage(IWebDriver driver) : base(driver) { }

        public PassengersPage ForPassengersNavbarClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                passengersNavbar.Click();
            },
            "Click 'Keleiviams'.");
            return this;
        }
        
    }
}
