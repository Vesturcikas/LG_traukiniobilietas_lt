using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Core;

namespace NUnitTest_LT.Tests.Services
{
    [AllureNUnit]
    public class ServicesTests : BaseTest
    {
        private IWebElement topNavbar => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement servicesNavbar => topNavbar.FindElement(By.CssSelector(".top-business"));
        private IWebElement servicesSubMenu => servicesNavbar.FindElement(By.CssSelector(".submenu-wrap"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);           
        }

        [Test]
        public void TopNavPaslaugos()
        {
            servicesNavbar.Click();
            Assert.IsTrue(servicesSubMenu.Enabled);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
