using OpenQA.Selenium;

namespace NUnitTest_LT.Pages
{
    public class LoginPage : BasePage
    {
        
        private IWebElement inputEmail => driver.FindElement(By.CssSelector(".login-box .login-mail input"));
        private IWebElement inputPassword => driver.FindElement(By.CssSelector(".login-box .login-pass input"));
        private IWebElement buttonSignIn => driver.FindElement(By.CssSelector(".login-box #loginButton"));
        private IWebElement linkPasswordReminder => driver.FindElement(By.CssSelector(".login-box .remindtrigger"));
        private IWebElement buttonRegister => driver.FindElement(By.CssSelector(".login-box .regtrigger"));

        public LoginPage(IWebDriver driver) : base(driver) { }

        

        public LoginPage InputEmail()
        {
            return this;
        }

        public LoginPage InputPasword()
        {
            return this;
        }

        public LoginPage SignInButtonClick()
        {
            return this;
        }

        public LoginPage PasswordRemainderClick()
        {
            return this;
        }

        public LoginPage RegisterButtonClick()
        {
            return this;
        }
    }
}
