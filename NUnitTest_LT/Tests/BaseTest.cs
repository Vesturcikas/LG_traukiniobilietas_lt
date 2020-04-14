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
        protected string baseUrl;

        [SetUp]
        public void BeforeEveryTest()
        {
            baseUrl = "https://www.traukiniobilietas.lt/portal";           
            driver = MyDriver.InitDriver(Browser.Chrome);
        }

        [TearDown]
        public void AfterEveryTest()
        {
            driver.Quit();            
        }        
    }
}
