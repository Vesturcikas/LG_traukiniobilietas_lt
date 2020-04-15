using NUnit.Framework;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Allure.Core;
using System;

namespace NUnitTest_LT.Tests.Bilietai
{
    [AllureNUnit]
    public class BilietaiTests : BaseTest
    {
        private BilietaiPage bilietaiPage;
        private BilietaiAssretsPage bilietaiAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            bilietaiAssertsPage = new BilietaiAssretsPage(driver);
            bilietaiPage = new BilietaiPage(driver);
            //CloseCookiesMessage();
        }

        [Test]
        public void TopNavBilietai()
        {
            bilietaiPage.NavBilietaiClick();
            bilietaiAssertsPage.AssertBilietai();        
        }
        
        [Test]
        public void SingleRadio()
        {
            bilietaiPage.OneWayClick();
            bilietaiAssertsPage.AssertOneWay(false);            
        }

        
        [Test]
        public void ReturnRadio()
        {
            bilietaiPage.RoundTripClick();
            bilietaiAssertsPage.AssertRoundTrip(false);            
        }       

        [Test]
        public void FixedRadio()
        {
            bilietaiPage.FixedTermClick();
            bilietaiAssertsPage.AssertFixedTerm();           
        }
        
        [Test]
        public void BuisnessClientCheckbox()
        {
            bilietaiPage
                .BuisnessCustomerClick()
                .OneWayClick();

            bilietaiAssertsPage.AssertOneWay(true);

            bilietaiPage.RoundTripClick();            

            bilietaiAssertsPage.AssertRoundTrip(true);

            bilietaiPage.FixedTermClick();

            bilietaiAssertsPage.AssertFixedTerm();        
        }

        [Test]
        public void ChangingLanguage()
        {
            bilietaiPage.NavKalbaClick();

            bilietaiAssertsPage.AssertKalbaSubMenu();            
            
            bilietaiPage.KalbaRUClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            bilietaiAssertsPage.AssertKalbaRU();
            
            bilietaiPage.KalbaENClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            bilietaiAssertsPage.AssertKalbaEN();

            bilietaiPage.KalbaLTClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            bilietaiAssertsPage.AssertKalbaLT();

        }

        [Test]
        public void SearchTicketsOneWayOneAdultsPerson()
        {
            string adultsCount = "1";
            string passengersCount = "1";
            bilietaiPage
                .OneWayClick()
                .PassengerCountClick()
                .PassangerAdultsAdd();
            adultsCount = "2";
            passengersCount = "2";

            bilietaiAssertsPage.AssertCountList();
            bilietaiAssertsPage.AssertAdultsValue(adultsCount);
            bilietaiAssertsPage.AssertPassangersCount(passengersCount);

            bilietaiPage.PassangerAdultsRemove();
            adultsCount = "1";
            passengersCount = "1";

            bilietaiAssertsPage.AssertAdultsValue(adultsCount);
            bilietaiAssertsPage.AssertPassangersCount(passengersCount);
        }
        
        [TearDown]
        public void AfterTests()
        {

        }
    }
}
