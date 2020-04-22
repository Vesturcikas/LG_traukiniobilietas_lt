using NUnit.Framework;
using NUnitTest_LT.Pages;
using NUnitTest_LT.AssertsPages;
using NUnit.Allure.Core;
using System;
using System.Threading;

namespace NUnitTest_LT.Tests.Tickets
{
    [AllureNUnit]
    public class TicketsTests : BaseTest
    {
        private TicketsPage ticketsPage;
        private TicketsAssretsPage ticketsAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            ticketsAssertsPage = new TicketsAssretsPage(driver);
            ticketsPage = new TicketsPage(driver);            
        }

        [Test]
        public void TopNavbarTickets()
        {
            ticketsPage.NavbarTicketsClick();
            ticketsAssertsPage.AssertTickets();        
        }
        
        [Test]
        public void SingleRadio()
        {
            ticketsPage.OneWayClick();
            ticketsAssertsPage.AssertOneWay(false);            
        }

        
        [Test]
        public void ReturnRadio()
        {
            ticketsPage.RoundTripClick();
            Thread.Sleep(1000);
            ticketsAssertsPage.AssertRoundTrip(false);            
        }       

        [Test]
        public void FixedRadio()
        {
            ticketsPage.FixedTermClick();
            Thread.Sleep(1000);
            ticketsAssertsPage.AssertFixedTerm();           
        }
        
        [Test]
        public void BuisnessClientCheckbox()
        {
            ticketsPage
                .BuisnessCustomerClick()
                .OneWayClick();
            Thread.Sleep(1000);
            ticketsAssertsPage.AssertOneWay(true);

            ticketsPage.RoundTripClick();
            Thread.Sleep(1000);
            ticketsAssertsPage.AssertRoundTrip(true);

            ticketsPage.FixedTermClick();
            Thread.Sleep(1000);
            ticketsAssertsPage.AssertFixedTerm();        
        }

        [Test]
        public void SearchButton()
        {
            ticketsPage.SerchButtonClick();
            Thread.Sleep(1000);
            ticketsAssertsPage.AssertFromInputError();
            ticketsAssertsPage.AssertToInputError();
            Thread.Sleep(3000);
        }

        [Test]
        public void ChangingLanguage()
        {
            ticketsPage.NavbarLanguageClick();            
            ticketsAssertsPage.AssertLanguageSubMenu();

            ticketsPage.LanguageRUClick();
            
            ticketsAssertsPage.AssertLanguageRU();

            ticketsPage.NavbarLanguageClick();
            ticketsPage.LanguageENClick();
            
            ticketsAssertsPage.AssertLanguageEN();

            ticketsPage.NavbarLanguageClick();
            ticketsPage.LanguageLTClick();
            
            ticketsAssertsPage.AssertLanguageLT();            
        }

        [Test]
        public void SearchTicketsOneWayOneAdultsPerson()
        {
            string adultsCount = "1";
            string passengersCount = "1";
            string travelFrom = "Kaunas";
            string travelTo = "Vilnius";

            ticketsPage
                .OneWayClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo)
                .PassengerCountClick()
                .PassangerAdultsAdd();
            adultsCount = "2";
            passengersCount = "2";

            ticketsAssertsPage.AssertCountList();
            ticketsAssertsPage.AssertAdultsValue(adultsCount);
            ticketsAssertsPage.AssertPassangersCount(passengersCount);

            ticketsPage.PassangerAdultsRemove();
            adultsCount = "1";
            passengersCount = "1";

            ticketsAssertsPage.AssertAdultsValue(adultsCount);
            ticketsAssertsPage.AssertPassangersCount(passengersCount);

            ticketsPage.SerchButtonClick();

            Thread.Sleep(5000);
        }

        [Test]
        public void DepartureDate()
        {
            int diena = 7;
            string travelFrom = "Kaunas";
            string travelTo = "Vilnius";

            //var year = DateTime.Today.Year;
            //var month = DateTime.Today.Month;
            var day = DateTime.Today.Day;            

            string dayDep = (day + diena).ToString();
            string selectorString = "[data-pika-day='" + dayDep + "']";            
            string dateDeparture = DateTime.Today.AddDays(diena).ToString("yyyy-MM-dd");

            ticketsPage
                .SelectFrom(travelFrom)
                .SelectTo(travelTo)
                .SelectDepartureDate(selectorString);                

            Thread.Sleep(1000);

            ticketsAssertsPage.AssertDepartureDate(dateDeparture);
        }

        [Test]
        public void ArrivalDate()
        {
            int diena = 2;
            string travelFrom = "Kaunas";
            string travelTo = "Vilnius";

            //var yearToday = DateTime.Today.Year;
            //var monthToday = DateTime.Today.Month;
            var dayToday = DateTime.Today.Day;

            int dayDepInt = dayToday + diena;
            string dayDep = dayDepInt.ToString();
            string selectorStringDep = "[data-pika-day='" + dayDep + "']";
            
            string dayArriv = (dayDepInt + diena).ToString();
            string selectorStringArriv = "[data-pika-day='" + dayArriv + "']";

            string dateArrival = DateTime.Today.AddDays(diena*2).ToString("yyyy-MM-dd");

            ticketsPage
                .RoundTripClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo)
                .SelectDepartureDate(selectorStringDep)
                .SelectArrivalDate(selectorStringArriv);

            Thread.Sleep(1000);

            ticketsAssertsPage.AssertArrivalDate(dateArrival);
        }

        [Test]
        public void WrongFromInputField()
        {
            string travelFrom = "Kuanas";
            string travelTo = "Vilnius";

            ticketsPage
                .OneWayClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo);

            ticketsPage.SerchButtonClick();
            Thread.Sleep(3000);

            ticketsAssertsPage.AssertFromInputError();            
        }

        [Test]
        public void WrongToInputField()
        {
            string travelFrom = "Kaunas";
            string travelTo = "Vilnus";

            ticketsPage
                .OneWayClick()
                .SelectFrom(travelFrom)
                .SelectTo(travelTo);

            ticketsPage.SerchButtonClick();
            Thread.Sleep(3000);

            ticketsAssertsPage.AssertToInputError();
        }


        [TearDown]
        public void AfterTests()
        {

        }
    }
}
