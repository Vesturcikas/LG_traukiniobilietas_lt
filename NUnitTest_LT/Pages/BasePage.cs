using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest_LT.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected Actions act;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
