using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Framework;
using NUnit.Allure.Core;
using System.Threading;

namespace NUnitTest_LT.Tests.Login
{
    [AllureNUnit]
    public class LoginTests : BaseTest
    {
        private TicketsPage ticketsPage;
        private LoginPage loginPage;
        private LoginAssertsPage loginAssertsPage;

        [SetUp]
        public void BeforeTest()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);            
            ticketsPage = new TicketsPage(driver);
            loginPage = new LoginPage(driver);
            loginAssertsPage = new LoginAssertsPage(driver);            
        }

        [Test]
        public void OpenCloseLoginPageTest()
        {
            ticketsPage.SignInClick();
            loginAssertsPage.AssertIsOpenLoginPage();
            ticketsPage.SignInClick();
            loginAssertsPage.AssertIsClosedLoginPage();
        }

        [Test]
        public void ValueIsRequired()
        {
            ticketsPage.SignInClick();
            loginPage
                .ClearInputsFeald()
                .SignInButtonClick();
            Thread.Sleep(3000);
            loginAssertsPage.AssertEmailIsRequired();
            loginAssertsPage.AssertPasswordIsRequired();
        }

        [Test]
        public void WrongPasswordLoginTest()
        {
            ticketsPage.SignInClick();
            loginAssertsPage.AssertIsOpenLoginPage();

            loginPage
                .InputEmail(User.DefaultUser.Useremail)
                .InputPasword(User.DefaultUser.Password)
                .SignInButtonClick();

            Thread.Sleep(3000);
            
            loginAssertsPage.AssertWrongEmailOrPassword();
        }

        [TearDown]
        public void AfterTests()
        {
            //loginPage.ClearInputsFeald();
        }
    }
}
