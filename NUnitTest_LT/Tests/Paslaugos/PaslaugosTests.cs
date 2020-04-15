using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Core;

namespace NUnitTest_LT.Tests.Paslaugos
{
    [AllureNUnit]
    public class PaslaugosTests : BaseTest
    {
        private IWebElement topNav => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement paslaugosNav => topNav.FindElement(By.CssSelector(".top-business"));
        private IWebElement paslaugosSubMenu => paslaugosNav.FindElement(By.CssSelector(".submenu-wrap"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);           
        }

        [Test]
        public void TopNavPaslaugos()
        {
            paslaugosNav.Click();
            Assert.IsTrue(paslaugosSubMenu.Enabled);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
