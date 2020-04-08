using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_LT.Pages
{
    public class HomePage : BasePage
    {        
        private IWebElement bilietaiNav => driver.FindElement(By.CssSelector(".top .nav .top-left a[href='/portal/']"));
        private IWebElement tvarkaraciaiNav => driver.FindElement(By.CssSelector(".top .nav .top-left a[href='/portal/routes-schedules']"));
        private IWebElement keleiviamsNav => driver.FindElement(By.CssSelector(".top .nav .top-passenger"));
        private IWebElement keleiviamsSubMenu => keleiviamsNav.FindElement(By.CssSelector(".submenu-wrap"));
        private IWebElement paslaugosNav => driver.FindElement(By.CssSelector(".top .nav .top-business"));
        private IWebElement paslaugosSubMenu => paslaugosNav.FindElement(By.CssSelector(".submenu-wrap"));
        private IWebElement login => driver.FindElement(By.CssSelector(".top .nav .top-right .logged-out"));

        //
        private IWebElement frontForm => driver.FindElement(By.CssSelector(".front-form"));
        private IWebElement singleRadio => frontForm.FindElement(By.CssSelector(".front-single"));
        private IWebElement returnRadio => frontForm.FindElement(By.CssSelector(".front-return"));
        private IWebElement fixedRadio => frontForm.FindElement(By.CssSelector(".front-fixed"));
        private IWebElement buisnessClient => frontForm.FindElement(By.CssSelector(".front-dir-tail"));
        private IWebElement fromFront => frontForm.FindElement(By.CssSelector(".front-from"));
        private IWebElement toFront => frontForm.FindElement(By.CssSelector(".front-to"));
        private IWebElement departureDate => frontForm.FindElement(By.CssSelector(".departureDatePickerTrigger"));
        private IWebElement arrivaleDate => frontForm.FindElement(By.CssSelector(".arrivalDatePickerTrigger"));
        private IWebElement countFront => frontForm.FindElement(By.CssSelector(".front-count"));
        private IWebElement searchButt => frontForm.FindElement(By.CssSelector("button"));

        public HomePage(IWebDriver driver) : base(driver) { }

        public HomePage NavBilietaiClick()
        {
            bilietaiNav.Click();
            return this;
        }
        
        public HomePage OneWayClick()
        {
            return this;
        }

        public HomePage RoundTripClick()
        {
            return this;
        }

        public HomePage FixedTermClick()
        {
            return this;
        }

        public HomePage BuisnessCustomerClick()
        {
            return this;
        }

        public HomePage SelectFrom()
        {
            return this;
        }

        public HomePage SelectTo()
        {
            return this;
        }

        public HomePage SelectDepartureDate()
        {
            return this;
        }

        public HomePage SelectArrivalDate()
        {
            return this;
        }

        public HomePage PassengerCountClick()
        {
            return this;
        }

        public HomePage PassangerAdultsAdd()
        {
            return this;
        }
        public HomePage PassangerAdultsRemove()
        {
            return this;
        }

        public HomePage PassangerChildrenAdd()
        {
            return this;
        }
        public HomePage PassangerChildrenRemove()
        {
            return this;
        }

        public HomePage PassangerAnimalsAdd()
        {
            return this;
        }
        public HomePage PassangerAnimalsRemove()
        {
            return this;
        }

        public HomePage SerchButtonClick()
        {
            return this;
        }

        public HomePage SignInClick()
        {
            login.Click();
            return this;
        }

    }
}
