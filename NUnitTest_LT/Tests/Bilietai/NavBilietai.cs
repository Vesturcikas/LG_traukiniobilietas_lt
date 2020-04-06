using NUnit.Framework;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;

namespace NUnitTest_LT.Tests.NavTests
{
    class NavBilietai : BaseTest
    {
        private BilietaiPage navPage;
        private BilietaiAssretsPage navAssretsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            navAssretsPage = new BilietaiAssretsPage(driver);
            navPage = new BilietaiPage(driver);
            //CloseCookiesMessage();
        }

        [Test]
        public void TopNavBilietai()
        {
            navPage.BilietaiClick();
            navAssretsPage.AssertBilietai();        
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
