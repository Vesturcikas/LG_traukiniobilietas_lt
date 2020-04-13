using NUnit.Framework;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Allure.Core;

namespace NUnitTest_LT.Tests.Bilietai
{
    [AllureNUnit]
    public class BilietaiTests : BaseTest
    {
        private BilietaiPage bilietaiPage;
        private BilietaiAssretsPage navAssretsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            navAssretsPage = new BilietaiAssretsPage(driver);
            bilietaiPage = new BilietaiPage(driver);
            //CloseCookiesMessage();
        }

        [Test]
        public void TopNavBilietai()
        {
            bilietaiPage.NavBilietaiClick();
            navAssretsPage.AssertBilietai();        
        }
        /*
        [Test]
        public void SingleRadio()
        {
            singleRadio.Click();
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(!arrivaleDate.Displayed);
            Assert.IsTrue(countFront.Displayed);
        }

        [Test]
        public void ReturnRadio()
        {
            returnRadio.Click();
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(arrivaleDate.Displayed);
            Assert.IsTrue(countFront.Displayed);
        }

        [Test]
        public void FixedRadio()
        {
            fixedRadio.Click();
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(!departureDate.Displayed);
            Assert.IsTrue(!arrivaleDate.Displayed);
            Assert.IsTrue(!countFront.Displayed);
        }

        [Test]
        public void BuisnessClientCheckbox()
        {
            buisnessClient.Click();
            singleRadio.Click();

            //Assert.IsTrue(fromFront.Displayed);
            //Assert.IsTrue(toFront.Displayed);
            //Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(!arrivaleDate.Displayed);
            Assert.IsTrue(!countFront.Displayed);

            returnRadio.Click();
            //Assert.IsTrue(fromFront.Displayed);
            //Assert.IsTrue(toFront.Displayed);
            //Assert.IsTrue(departureDate.Displayed);
            //Assert.IsTrue(arrivaleDate.Displayed);
            Assert.IsTrue(!countFront.Displayed);

            fixedRadio.Click();
            //Assert.IsTrue(fromFront.Displayed);
            //Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(!departureDate.Displayed);
            Assert.IsTrue(!arrivaleDate.Displayed);
            Assert.IsTrue(!countFront.Displayed);
        }
        */
        [TearDown]
        public void AfterTests()
        {

        }
    }
}
