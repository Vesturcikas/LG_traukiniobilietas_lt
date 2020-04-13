using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest_LT.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Actions act;
        protected string baseUrl;

        [SetUp]
        public void BeforeEveryTest()
        {
            baseUrl = "https://www.traukiniobilietas.lt/portal";            
            driver = MyDriver.InitDriver(Browser.Chrome);

            //setting up the wait
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            //setting up the action
            act = new Actions(driver);

            //Closing the cookies message
            //IWebElement lgCookiesMessageClose =driver.FindElement(By.CssSelector(".cookies-message-close"));
            //lgCookiesMessageClose.Click();
        }

        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();            
        }

        //Closing the cookies message
        public void CloseCookiesMessage()
        {
            IWebElement lgCookiesMessageClose = wait
                .Until(dr => dr.FindElement(By.CssSelector(".cookies-message-close")));
            lgCookiesMessageClose.Click();
        }
    }
}
