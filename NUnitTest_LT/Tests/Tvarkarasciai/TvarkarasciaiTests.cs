using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Core;

namespace NUnitTest_LT.Tests.Tvarkarasciai
{
    [AllureNUnit]
    public class TvarkarasciaiTests : BaseTest
    {
        private IWebElement topNav => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement tvarkaraciaiNav => topNav.FindElement(By.LinkText("Tvarkaraščiai"));

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
            tvarkaraciaiNav.Click();
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/routes-schedules", driver.Url);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
