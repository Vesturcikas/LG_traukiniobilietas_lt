using NUnitTest_LT.Pages;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTest_LT.AssertsPages
{
    public class LoginAssertsPage : BasePage
    {
        private IWebElement loginBox => driver.FindElement(By.CssSelector(".login-box"));
        private IWebElement loginSpan => driver.FindElement(By.CssSelector("span.login-span"));
        private IWebElement closeSpan => driver.FindElement(By.CssSelector("span.close-span"));

        public LoginAssertsPage(IWebDriver driver) : base(driver) { }

        public void AssertIsOpenLoginPage()
        {
            Assert.That(loginBox.Displayed, "The login page is not open!!!");
            Assert.That(closeSpan.Displayed);
        }

        public void AssertIsClosedLoginPage()
        {
            Assert.That(!loginBox.Displayed, "The login page is not close!!!");
            Assert.That(loginSpan.Displayed);
        }

        public void AssertWrongEmailOrPassword()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

            IWebElement loginError = wait.Until(drv => drv.FindElement(By.XPath("//span[contains(.,'Neteisingas prisijungimo vardas arba slaptažodis')]")));
            Assert.That(loginError.Displayed);
            Assert.AreEqual("Neteisingas prisijungimo vardas arba slaptažodis", loginError.Text);
        }
    }
}
