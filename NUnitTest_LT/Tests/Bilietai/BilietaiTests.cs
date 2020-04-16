﻿using NUnit.Framework;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Allure.Core;
using System;
using System.Threading;

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
            Thread.Sleep(1000);
            bilietaiAssertsPage.AssertRoundTrip(false);            
        }       

        [Test]
        public void FixedRadio()
        {
            bilietaiPage.FixedTermClick();
            Thread.Sleep(1000);
            bilietaiAssertsPage.AssertFixedTerm();           
        }
        
        [Test]
        public void BuisnessClientCheckbox()
        {
            bilietaiPage
                .BuisnessCustomerClick()
                .OneWayClick();
            Thread.Sleep(1000);
            bilietaiAssertsPage.AssertOneWay(true);

            bilietaiPage.RoundTripClick();
            Thread.Sleep(1000);
            bilietaiAssertsPage.AssertRoundTrip(true);

            bilietaiPage.FixedTermClick();
            Thread.Sleep(1000);
            bilietaiAssertsPage.AssertFixedTerm();        
        }

        [Test]
        public void SearchButton()
        {
            bilietaiPage.SerchButtonClick();
            Thread.Sleep(1000);
            bilietaiAssertsPage.AssertFromInputError();
            bilietaiAssertsPage.AssertToInputError();
            Thread.Sleep(3000);
        }

        [Test]
        public void ChangingLanguage()
        {
            bilietaiPage.NavKalbaClick();            
            bilietaiAssertsPage.AssertKalbaSubMenu();            
            
            bilietaiPage.KalbaRUClick();
            
            bilietaiAssertsPage.AssertKalbaRU();

            bilietaiPage.NavKalbaClick();            
            bilietaiPage.KalbaENClick();
            
            bilietaiAssertsPage.AssertKalbaEN();

            bilietaiPage.NavKalbaClick();            
            bilietaiPage.KalbaLTClick();
            
            bilietaiAssertsPage.AssertKalbaLT();            
        }

        [Test]
        public void SearchTicketsOneWayOneAdultsPerson()
        {
            string adultsCount = "1";
            string passengersCount = "1";
            string travelFrom = "Kaunas";
            string travelTo = "Vilnius";

            bilietaiPage
                .OneWayClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo)
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

            bilietaiPage.SerchButtonClick();

            Thread.Sleep(5000);

        }

        [Test]
        public void WrongFromInputField()
        {
            string travelFrom = "Kuanas";
            string travelTo = "Vilnius";

            bilietaiPage
                .OneWayClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo);

            bilietaiPage.SerchButtonClick();
            Thread.Sleep(1000);

            bilietaiAssertsPage.AssertFromInputError();            
        }

        [Test]
        public void WrongToInputField()
        {
            string travelFrom = "Kaunas";
            string travelTo = "Vilnus";

            bilietaiPage
                .OneWayClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo);

            bilietaiPage.SerchButtonClick();
            Thread.Sleep(1000);

            bilietaiAssertsPage.AssertToInputError();
        }


        [TearDown]
        public void AfterTests()
        {

        }
    }
}
