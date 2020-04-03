using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_LT.Tests.NavTests
{
    public class NavTvarkarasciai : BaseTest
    {
        private IWebElement topNav => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement tvarkaraciaiNav => topNav.FindElement(By.LinkText("Tvarkaraščiai"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/routes-schedules";
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
