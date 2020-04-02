using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_LT.Tests.NavTests
{
    class NavBilietai : BaseTest
    {
        private IWebElement topNav => driver.FindElement(By.CssSelector(".nav"));
        private IWebElement bilietaiNav => topNav.FindElement(By.LinkText("Bilietai"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
        }

        [Test]
        public void LgTopNavBilietai()
        {

            bilietaiNav.Click();
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/", driver.Url);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
