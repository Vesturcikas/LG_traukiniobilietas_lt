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
        private BilietaiPage bilietaiPage;
        private LoginPage loginPage;
        private LoginAssertsPage loginAssertsPage;

        [SetUp]
        public void BeforeTest()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);            
            bilietaiPage = new BilietaiPage(driver);
            loginPage = new LoginPage(driver);
            loginAssertsPage = new LoginAssertsPage(driver);            
        }

        [Test]
        public void OpenCloseLoginPageTest()
        {
            bilietaiPage.SignInClick();
            loginAssertsPage.AssertIsOpenLoginPage();
            bilietaiPage.SignInClick();
            loginAssertsPage.AssertIsClosedLoginPage();
        }

        [Test]
        public void WrongPasswordLoginTest()
        {
            bilietaiPage.SignInClick();
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

        }
    }
}
