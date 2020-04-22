using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Core;

namespace NUnitTest_LT.Tests.TimeTable
{
    [AllureNUnit]
    public class TimeTableTests : BaseTest
    {
        private IWebElement topNavbar => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement timeTableNavbar => topNavbar.FindElement(By.LinkText("Tvarkaraščiai"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);            
        }

        [Test]
        public void NavigationTimeTable()
        {
            timeTableNavbar.Click();
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/routes-schedules", driver.Url);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
