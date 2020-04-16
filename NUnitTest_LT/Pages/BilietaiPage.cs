using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_LT.Pages
{
    public class BilietaiPage : BasePage
    {
        //Top Navigation Elements
        private IWebElement leftTopNav => driver.FindElement(By.CssSelector(".top .nav .top-left"));
        private IWebElement rightTopNav => driver.FindElement(By.CssSelector(".top .nav .top-right "));

        //Front Form Elements
        private IWebElement frontForm => driver.FindElement(By.CssSelector(".front-form"));        
        private IWebElement departureDate => frontForm.FindElement(By.CssSelector(".departureDatePickerTrigger"));
        private IWebElement arrivaleDate => frontForm.FindElement(By.CssSelector(".arrivalDatePickerTrigger"));
        private IWebElement countFront => frontForm.FindElement(By.CssSelector(".front-count"));

        public BilietaiPage(IWebDriver driver) : base(driver) { }

        public BilietaiPage NavBilietaiClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement bilietaiNav = leftTopNav.FindElement(By.CssSelector("a[href='/portal/']"));
                bilietaiNav.Click();
            },
            "Paspausti 'Bilietai'.");
            
            return this;
        }

        public BilietaiPage NavKalbaClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement kalba = rightTopNav.FindElement(By.CssSelector(".top-languages"));
                kalba.Click();
            },
            "Paspausti kalbos pasirinkimą.");

            return this;
        }

        public BilietaiPage KalbaLTClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement kalbaLT = driver.FindElement(By.CssSelector("a[href='/portal/lt']"));
                kalbaLT.Click();
            },
            "Pasirinkti LT kalbą.");
            
            return this;
        }

        public BilietaiPage KalbaENClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement kalbaEN = driver.FindElement(By.CssSelector("a[href='/portal/en']"));
                kalbaEN.Click();
            },
            "Pasirinkti EN kalbą.");

            return this;
        }

        public BilietaiPage KalbaRUClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement kalbaRU = driver.FindElement(By.CssSelector("a[href='/portal/ru']"));
                kalbaRU.Click();                
            },
            "Pasirinkti RU kalbą.");

            return this;
        }

        public BilietaiPage OneWayClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement singleRadio = frontForm.FindElement(By.CssSelector(".front-single"));
                singleRadio.Click();
            },
            "Pžymėti 'Į vieną pusę'.");

            return this;
        }

        public BilietaiPage RoundTripClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement returnRadio = frontForm.FindElement(By.CssSelector(".front-return"));
                returnRadio.Click();
            },
            "Pžymėti 'Į abi puses'.");
            return this;
        }

        public BilietaiPage FixedTermClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement fixedRadio = frontForm.FindElement(By.CssSelector(".front-fixed"));
                fixedRadio.Click();
            },
            "Pžymėti 'Terminuotas'.");
            return this;
        }

        public BilietaiPage BuisnessCustomerClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement buisnessClientCheckbox = frontForm.FindElement(By.CssSelector(".form-checker"));
                buisnessClientCheckbox.Click();
            },
               "Pžymėti 'Verslo klientas'.");
            return this;
        }

        public BilietaiPage SelectFrom(string from)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {                
                IWebElement fromInput = frontForm.FindElement(By.CssSelector(".front-from input"));
                fromInput.Clear();
                fromInput.SendKeys(from);
            },
            "Įvesti 'Iš'.");
            return this;
        }

        public BilietaiPage SelectTo(string to)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {                
                IWebElement toInput = frontForm.FindElement(By.CssSelector(".front-to input"));
                toInput.SendKeys(to);
            },
            "Įvesti 'Į'.");
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
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                countFront.Click();
            },
            "Paspausti: keleivių kiekis.");

            return this;
        }

        public BilietaiPage PassangerAdultsAdd()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement buttonAdultsAdd = countFront.FindElement(By.CssSelector(".count-list .count-row:first-child .count-plus"));
                buttonAdultsAdd.Click();
            },
            "Pridėti suaugusį keleivį.");

            return this;
        }
        public BilietaiPage PassangerAdultsRemove()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement buttonAdultsRemove = countFront.FindElement(By.CssSelector(".count-list .count-row:first-child .count-minus"));
                buttonAdultsRemove.Click();
            },
            "Sumažinti suaugusių keleivių skaičių.");
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
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                IWebElement searchButt = wait.Until(dr => dr.FindElement(By.CssSelector(".front-form .front-search button")));
                searchButt.Click();
            },
            "Paspausti 'Ieškoti'.");
            return this;
        }

        public BilietaiPage SignInClick()
        {
            AllureLifecycle.Instance.WrapInStep(() => 
            {
                IWebElement login = rightTopNav.FindElement(By.CssSelector(".logged-out"));
                login.Click();                
            },
            "Paspausti 'Prisijungti' mygtuką.");
            return this;
        }

    }
}
