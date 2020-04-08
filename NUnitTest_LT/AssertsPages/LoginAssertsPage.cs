using NUnitTest_LT.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_LT.AssertsPages
{
    public class LoginAssertsPage : BasePage
    {
        private IWebElement loginBox => driver.FindElement(By.CssSelector(".login-box"));

        public LoginAssertsPage(IWebDriver driver) : base(driver) { }

        public void AssertIsOpenLoginPage()
        {
            Assert.That(loginBox.Displayed, "The login page is not displayed!!!");
        }
        
    }
}
