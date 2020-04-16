using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTest_LT.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Actions act;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            act = new Actions(driver);
        }
    }
}
