using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace NUnitTest_LT.Tests
{
    public static class MyDriver
    {
        public static IWebDriver InitDriver(Browser browser)
        {
            IWebDriver driver = null;
            switch (browser)
            {
                case Browser.Chrome: driver = new ChromeDriver(GetChromeOptions()); break;
                case Browser.Edge: driver = new EdgeDriver(); break;
                default: Assert.Fail("Tokio browserío nepalaikau!"); break;
            }

            //Setting up the Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            //options.AddArgument("incognito");
            //chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            return chromeOptions;
        }

    }

    public enum Browser
    {
        Chrome,
        Edge
    }
}
