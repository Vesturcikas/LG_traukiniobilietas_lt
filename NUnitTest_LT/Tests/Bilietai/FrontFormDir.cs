using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_LT.Tests.FrontFormTests
{
    public class FrontFormDir : BaseTest
    {
        private IWebElement frontForm => driver.FindElement(By.CssSelector(".front-form"));
        private IWebElement singleRadio => frontForm.FindElement(By.CssSelector(".front-single"));
        private IWebElement returnRadio => frontForm.FindElement(By.CssSelector(".front-return"));
        private IWebElement fixedRadio => frontForm.FindElement(By.CssSelector(".front-fixed"));
        private IWebElement buisnessClient => frontForm.FindElement(By.CssSelector(".front-dir-tail"));
        private IWebElement fromFront => frontForm.FindElement(By.CssSelector(".front-from"));
        private IWebElement toFront => frontForm.FindElement(By.CssSelector(".front-to"));
        private IWebElement departureDate => frontForm.FindElement(By.CssSelector(".departureDatePickerTrigger"));
        private IWebElement arrivaleDate => frontForm.FindElement(By.CssSelector(".arrivalDatePickerTrigger"));
        private IWebElement countFront => frontForm.FindElement(By.CssSelector(".front-count"));
        private IWebElement searchButt => frontForm.FindElement(By.CssSelector("button"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl;
            driver.Navigate().GoToUrl(testUrl);
            //CloseCookiesMessage();
        }

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

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
