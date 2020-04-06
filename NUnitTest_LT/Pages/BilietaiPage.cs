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

        public BilietaiPage(IWebDriver driver) : base(driver) { }

        public BilietaiPage BilietaiClick()
        {
            return this;
        }

        public BilietaiPage TvarkaraciaiClick()
        {
            return this;
        }

        public BilietaiPage KeleiviamsClick()
        {
            return this;
        }

        public BilietaiPage PaslaugosClick()
        {
            return this;
        }
    }
}
