using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Allure.Core;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;

namespace NUnitTest_LT.Tests.ForPassengers
{
    [AllureNUnit]
    public class ForPassengersTests : BaseTest
    {
        private PassengersPage passengersPage;
        private PassengersAssertsPage passengersAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            passengersPage = new PassengersPage(driver);
            passengersAssertsPage = new PassengersAssertsPage(driver);
        }

        [Test]
        public void TopNavbarForPassengers()
        {
            passengersPage.ForPassengersNavbarClick();

            passengersAssertsPage.CheckForPassengersSubMenu();
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
