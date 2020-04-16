﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnitTest_LT.Pages;
using NUnit.Framework;
using System.Drawing;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTest_LT.AssertsPages
{
    public class BilietaiAssretsPage : BasePage
    {
        //private IWebElement kalba => driver.FindElement(By.CssSelector(".top .nav .top-right .top-languages"));
        //private IWebElement kalbaSubMenu => kalba.FindElement(By.CssSelector(".submenu-wrap"));        
        private IWebElement frontForm => driver.FindElement(By.CssSelector(".front-form"));
        //private IWebElement frontTitle => driver.FindElement(By.CssSelector(".front-title > h1"));
        private IWebElement fromFront => frontForm.FindElement(By.CssSelector(".front-from"));
        private IWebElement toFront => frontForm.FindElement(By.CssSelector(".front-to"));
        private IWebElement departureDate => frontForm.FindElement(By.CssSelector(".departureDatePickerTrigger"));
        private IWebElement arrivalDate => frontForm.FindElement(By.CssSelector(".arrivalDatePickerTrigger"));
        private IWebElement countFront => frontForm.FindElement(By.CssSelector(".front-count"));
        private IWebElement valuePassengersCount => countFront.FindElement(By.CssSelector(".form-input input"));
        private IWebElement countList => countFront.FindElement(By.CssSelector(".count-list"));
        private IWebElement valueAdultsCount => countFront.FindElement(By.CssSelector(".count-list .count-row:first-child .count-value"));
        private IWebElement buisnessClientMessage => frontForm.FindElement(By.CssSelector(".front-dir-tail"));


        public BilietaiAssretsPage(IWebDriver driver) : base(driver) { }

        public void AssertBilietai()
        {
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/", driver.Url);
        }

        public void AssertKalbaSubMenu()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement kalbaSubMenu = wait.Until(drv => drv.FindElement(By.CssSelector(".top .nav .top-right .top-languages .submenu-wrap")));
            Assert.IsTrue(kalbaSubMenu.Displayed);
        }

        public void AssertKalbaLT()
        {
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/lt", driver.Url);

            IWebElement frontTitle = driver.FindElement(By.CssSelector(".front-title > h1"));

            Assert.AreEqual("Kur keliausite šiandien?", frontTitle.Text);
        }

        public void AssertKalbaEN()
        {
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/en", driver.Url);

            IWebElement frontTitle = driver.FindElement(By.CssSelector(".front-title > h1"));

            Assert.AreEqual("Where would you like to go today?", frontTitle.Text);
        }

        public void AssertKalbaRU()
        {          
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/ru", driver.Url);

            IWebElement frontTitle = driver.FindElement(By.CssSelector(".front-title > h1"));

            Assert.AreEqual("Куда отправитесь сегодня?", frontTitle.Text);
        }

        public void AssertOneWay(bool bchbox)
        {
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(!arrivalDate.Displayed);

            //Jei pažymėta "Verslo klientas"
            if (bchbox)
            {
                Assert.IsTrue(!countFront.Displayed);
            }
            else Assert.IsTrue(countFront.Displayed);            
        }

        public void AssertRoundTrip(bool bchbox)
        {
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(arrivalDate.Displayed);

            //Jei pažymėta "Verslo klientas"
            if (bchbox)
            {
                Assert.IsTrue(!countFront.Displayed);
            }
            else Assert.IsTrue(countFront.Displayed);
        }

        public void AssertFixedTerm()
        {
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(!departureDate.Displayed);
            Assert.IsTrue(!arrivalDate.Displayed);
            Assert.IsTrue(!countFront.Displayed);
        }

        public void AssertCountList()
        {
            Assert.IsTrue(countList.Displayed);
        }

        public void AssertAdultsValue(string adultsCount)
        {
            Assert.AreEqual(adultsCount, valueAdultsCount.Text);
        }

        public void AssertPassangersCount(string passengersCount)
        {
            Assert.AreEqual(passengersCount, valuePassengersCount.GetAttribute("value"));
        }

        public void AssertFromInputError()
        {
            //string errorColorCode = "#FFF0F0";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement fromFront = wait.Until(drv => drv.FindElement(By.CssSelector(".front-form .front-from")));

            string colorWebElement = fromFront.GetCssValue("background-color");

            Color spalva = new Color();
            spalva.ToString();

            Assert.AreEqual("#FFF0F0", colorWebElement);

            //color: #fff0f0;
            //color: rgba(255, 240, 240, 1);
        }

        public void AssertSearchResults()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        public void AssertBuissnesCheckbox()
        {
            
        }
    }
}
