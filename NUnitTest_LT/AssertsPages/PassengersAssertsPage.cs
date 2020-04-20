using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnitTest_LT.Pages;
using OpenQA.Selenium;

namespace NUnitTest_LT.AssertsPages
{
    public class PassengersAssertsPage : BasePage
    {
        private IWebElement topNavbar => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement passengersNavbar => topNavbar.FindElement(By.CssSelector(".top-passenger"));
        private IWebElement passengersNavbarSubMenu => passengersNavbar.FindElement(By.CssSelector(".submenu-wrap"));

        public PassengersAssertsPage(IWebDriver driver) : base(driver) { }

        public void CheckForPassengersSubMenu()
        {
            Assert.IsTrue(passengersNavbarSubMenu.Enabled);
        }

    }
}
