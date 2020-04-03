using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_LT.Tests.NavTests
{
    public class NavKeleiviams : BaseTest
    {
        private IWebElement topNav => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement keleiviamsNav => topNav.FindElement(By.CssSelector(".top-passenger"));
        private IWebElement keleiviamsSubMenu => keleiviamsNav.FindElement(By.CssSelector(".submenu-wrap"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            //CloseCookiesMessage();
        }

        [Test]
        public void TopNavTvarkarasciai()
        {
            keleiviamsNav.Click();
            Assert.IsTrue(keleiviamsSubMenu.Enabled);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
