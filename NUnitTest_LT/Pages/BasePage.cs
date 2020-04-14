using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTest_LT.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        
        protected Actions act;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            
            act = new Actions(driver);
        }
    }
}
