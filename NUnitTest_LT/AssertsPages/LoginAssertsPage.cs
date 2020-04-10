using NUnitTest_LT.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

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

    }
}
