﻿using NUnit.Framework;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Allure.Core;

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
        
        [TearDown]
        public void AfterTests()
        {

        }
    }
}
