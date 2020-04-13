using OpenQA.Selenium;
using NUnit.Allure.Core;
using Allure.Commons;

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

        

        public LoginPage InputEmail(string useremail)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                inputEmail.Clear();
                inputEmail.SendKeys(useremail);
            }, 
            $"Enter user email {useremail}");
            return this;
        }

        public LoginPage InputPasword(string userpassword)
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                inputPassword.Clear();
                inputPassword.SendKeys(userpassword);
            },
            "Enter user password: **********");

            return this;
        }

        public LoginPage SignInButtonClick()
        {
            AllureLifecycle.Instance.WrapInStep(() => 
            {
                buttonSignIn.Click();
            },
            "Click 'Sign in' button.");
            return this;
        }

        public LoginPage PasswordRemainderClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                linkPasswordReminder.Click();
            },
            "Click 'Password reminder' link.");
            return this;
        }

        public LoginPage RegisterButtonClick()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                buttonRegister.Click();
            },
            "Click 'REGISTER' button");
            return this;
        }
    }
}
