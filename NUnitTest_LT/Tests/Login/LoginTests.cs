using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Framework;

namespace NUnitTest_LT.Tests.Login
{
    public class LoginTests : BaseTest
    {
        private HomePage homePage;
        private LoginPage loginPage;
        private LoginAssertsPage loginAssertsPage;

        [SetUp]
        public void BeforeTest()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);            
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            loginAssertsPage = new LoginAssertsPage(driver);
            CloseCookiesMessage();
        }

        [Test]
        public void ValidUserLoginTest()
        {
            homePage.SignInClick();
            loginAssertsPage.AssertIsOpenLoginPage();
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
