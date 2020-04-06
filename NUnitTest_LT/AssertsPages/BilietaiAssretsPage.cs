using OpenQA.Selenium;
using NUnitTest_LT.Pages;
using NUnit.Framework;

namespace NUnitTest_LT.AssertsPages
{
    public class BilietaiAssretsPage : BasePage
    {
        private IWebElement keleiviamsSubMenu => driver.FindElement(By.CssSelector("...."));

        public BilietaiAssretsPage(IWebDriver driver) : base(driver) { }

        public void AssertBilietai()
        {
            Assert.AreEqual("https://www.traukiniobilietas.lt/portal/", driver.Url);
        }
    }
}
