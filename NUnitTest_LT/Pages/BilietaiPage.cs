using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_LT.Pages
{
    public class BilietaiPage : BasePage
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

        public BilietaiPage(IWebDriver driver) : base(driver) { }

        public BilietaiPage NavBilietaiClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                bilietaiNav.Click();
            },
            "Paspausti 'Bilietai'.");            
            return this;
        }
        
        public BilietaiPage OneWayClick()
        {
            return this;
        }

        public BilietaiPage RoundTripClick()
        {
            return this;
        }

        public BilietaiPage FixedTermClick()
        {
            return this;
        }

        public BilietaiPage BuisnessCustomerClick()
        {
            return this;
        }

        public BilietaiPage SelectFrom()
        {
            return this;
        }

        public BilietaiPage SelectTo()
        {
            return this;
        }

        public BilietaiPage SelectDepartureDate()
        {
            return this;
        }

        public BilietaiPage SelectArrivalDate()
        {
            return this;
        }

        public BilietaiPage PassengerCountClick()
        {
            return this;
        }

        public BilietaiPage PassangerAdultsAdd()
        {
            return this;
        }
        public BilietaiPage PassangerAdultsRemove()
        {
            return this;
        }

        public BilietaiPage PassangerChildrenAdd()
        {
            return this;
        }
        public BilietaiPage PassangerChildrenRemove()
        {
            return this;
        }

        public BilietaiPage PassangerAnimalsAdd()
        {
            return this;
        }
        public BilietaiPage PassangerAnimalsRemove()
        {
            return this;
        }

        public BilietaiPage SerchButtonClick()
        {
            return this;
        }

        public BilietaiPage SignInClick()
        {
            AllureLifecycle.Instance.WrapInStep(() => 
            {
                login.Click();                
            },
            "Paspausti 'Prisijungti' mygtuką.");
            return this;
        }

    }
}
