using OpenQA.Selenium;
using NUnitTest_LT.Pages;
using NUnit.Framework;

namespace NUnitTest_LT.AssertsPages
{
    public class BilietaiAssretsPage : BasePage
    {
        //private IWebElement keleiviamsSubMenu => driver.FindElement(By.CssSelector("...."));
        private IWebElement frontForm => driver.FindElement(By.CssSelector(".front-form"));
        private IWebElement fromFront => frontForm.FindElement(By.CssSelector(".front-from"));
        private IWebElement toFront => frontForm.FindElement(By.CssSelector(".front-to"));
        private IWebElement departureDate => frontForm.FindElement(By.CssSelector(".departureDatePickerTrigger"));
        private IWebElement arrivalDate => frontForm.FindElement(By.CssSelector(".arrivalDatePickerTrigger"));
        private IWebElement countFront => frontForm.FindElement(By.CssSelector(".front-count"));
        private IWebElement buisnessClientMessage => frontForm.FindElement(By.CssSelector(".front-dir-tail"));


        public BilietaiAssretsPage(IWebDriver driver) : base(driver) { }

        public void AssertBilietai()
        {
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/", driver.Url);
        }

        public void AssertOneWay(bool bchbox)
        {
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(!arrivalDate.Displayed);

            //Jei pažymėta "Verslo klientas"
            if (bchbox)
            {
                Assert.IsTrue(!countFront.Displayed);
            }
            else Assert.IsTrue(countFront.Displayed);            
        }

        public void AssertRoundTrip(bool bchbox)
        {
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(departureDate.Displayed);
            Assert.IsTrue(arrivalDate.Displayed);

            //Jei pažymėta "Verslo klientas"
            if (bchbox)
            {
                Assert.IsTrue(!countFront.Displayed);
            }
            else Assert.IsTrue(countFront.Displayed);
        }

        public void AssertFixedTerm()
        {
            Assert.IsTrue(fromFront.Displayed);
            Assert.IsTrue(toFront.Displayed);
            Assert.IsTrue(!departureDate.Displayed);
            Assert.IsTrue(!arrivalDate.Displayed);
            Assert.IsTrue(!countFront.Displayed);
        }

        public void AssertBuissnesCheckbox()
        {
            
        }
    }
}
