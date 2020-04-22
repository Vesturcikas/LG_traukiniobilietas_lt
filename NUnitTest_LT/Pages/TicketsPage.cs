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
    public class TicketsPage : BasePage
    {
        //Top Navigation Elements
        private IWebElement leftTopNav => driver.FindElement(By.CssSelector(".top .nav .top-left"));
        private IWebElement rightTopNav => driver.FindElement(By.CssSelector(".top .nav .top-right "));

        //Front Form Elements
        private IWebElement frontForm => driver.FindElement(By.CssSelector(".front-form"));      
        private IWebElement countFront => frontForm.FindElement(By.CssSelector(".front-count"));

        public TicketsPage(IWebDriver driver) : base(driver) { }

        public TicketsPage NavbarTicketsClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement tickets = leftTopNav.FindElement(By.CssSelector("a[href='/portal/']"));
                tickets.Click();
            },
            "Paspausti 'Bilietai'.");
            
            return this;
        }

        public TicketsPage NavbarLanguageClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement language = rightTopNav.FindElement(By.CssSelector(".top-languages"));
                language.Click();
            },
            "Paspausti kalbos pasirinkimą.");

            return this;
        }

        public TicketsPage LanguageLTClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement languageLT = driver.FindElement(By.CssSelector("a[href='/portal/lt']"));
                languageLT.Click();
            },
            "Pasirinkti LT kalbą.");
            
            return this;
        }

        public TicketsPage LanguageENClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement languageEN = driver.FindElement(By.CssSelector("a[href='/portal/en']"));
                languageEN.Click();
            },
            "Pasirinkti EN kalbą.");

            return this;
        }

        public TicketsPage LanguageRUClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement languageRU = driver.FindElement(By.CssSelector("a[href='/portal/ru']"));
                languageRU.Click();                
            },
            "Pasirinkti RU kalbą.");

            return this;
        }

        public TicketsPage OneWayClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement singleRadio = frontForm.FindElement(By.CssSelector(".front-single"));
                singleRadio.Click();
            },
            "Pžymėti 'Į vieną pusę'.");

            return this;
        }

        public TicketsPage RoundTripClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement returnRadio = frontForm.FindElement(By.CssSelector(".front-return"));
                returnRadio.Click();
            },
            "Pžymėti 'Į abi puses'.");
            return this;
        }

        public TicketsPage FixedTermClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement fixedRadio = frontForm.FindElement(By.CssSelector(".front-fixed"));
                fixedRadio.Click();
            },
            "Pžymėti 'Terminuotas'.");
            return this;
        }

        public TicketsPage BuisnessCustomerClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement buisnessClientCheckbox = frontForm.FindElement(By.CssSelector(".form-checker"));
                buisnessClientCheckbox.Click();
            },
               "Pžymėti 'Verslo klientas'.");
            return this;
        }

        public TicketsPage SelectFrom(string from)
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

        public TicketsPage SelectTo(string to)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {                
                IWebElement toInput = frontForm.FindElement(By.CssSelector(".front-to input"));
                toInput.SendKeys(to);
            },
            "Įvesti 'Į'.");
            return this;
        }

        public TicketsPage SelectDepartureDate(string selectorString)
        {           
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement departureDate = frontForm.FindElement(By.CssSelector(".departureDatePickerTrigger"));
                departureDate.Click();

                IWebElement departureDatePicker = wait
                    .Until(drv => drv.FindElement(By.CssSelector(".departureDatePickerContainer")));

                IWebElement dateTable = departureDatePicker.FindElement(By.CssSelector("tbody"));

                IWebElement depDay = dateTable.FindElement(By.CssSelector(selectorString));
                
                Actions act = new Actions(driver);
                act.MoveToElement(depDay).Build().Perform();
                depDay.Click();
            },
            "Pasirinkti išvykimo dieną");     

            return this;
        }

        public TicketsPage SelectArrivalDate(string selectorString2)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement arrivalDate = frontForm.FindElement(By.CssSelector(".arrivalDatePickerTrigger"));
                arrivalDate.Click();                

                IWebElement arrivalDatePicker = wait
                    .Until(drv => drv.FindElement(By.CssSelector(".arrivalDatePickerContainer")));                

                IWebElement dateTable = arrivalDatePicker.FindElement(By.CssSelector("tbody"));

                IWebElement arrivDay = dateTable.FindElement(By.CssSelector(selectorString2));
                
                Actions act = new Actions(driver);
                act.MoveToElement(arrivDay).Build().Perform();
                arrivDay.Click();
            },
            "Pasirinkti atvykimo dieną");

            return this;
        }

        public TicketsPage PassengerCountClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                countFront.Click();
            },
            "Paspausti: keleivių kiekis.");

            return this;
        }

        public TicketsPage PassangerAdultsAdd()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement buttonAdultsAdd = countFront.FindElement(By.CssSelector(".count-list .count-row:first-child .count-plus"));
                buttonAdultsAdd.Click();
            },
            "Pridėti suaugusį keleivį.");

            return this;
        }
        public TicketsPage PassangerAdultsRemove()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                IWebElement buttonAdultsRemove = countFront.FindElement(By.CssSelector(".count-list .count-row:first-child .count-minus"));
                buttonAdultsRemove.Click();
            },
            "Sumažinti suaugusių keleivių skaičių.");
            return this;
        }

        public TicketsPage PassangerChildrenAdd()
        {
            return this;
        }
        public TicketsPage PassangerChildrenRemove()
        {
            return this;
        }

        public TicketsPage PassangerAnimalsAdd()
        {
            return this;
        }
        public TicketsPage PassangerAnimalsRemove()
        {
            return this;
        }

        public TicketsPage SerchButtonClick()
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

        public TicketsPage SignInClick()
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
