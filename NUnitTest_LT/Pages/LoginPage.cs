using OpenQA.Selenium;
using NUnit.Allure.Core;
using Allure.Commons;

namespace NUnitTest_LT.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement loginBox => driver.FindElement(By.CssSelector(".login-box"));
        private IWebElement inputEmail => loginBox.FindElement(By.CssSelector(".login-mail input"));
        private IWebElement inputPassword => loginBox.FindElement(By.CssSelector(".login-pass input"));
        private IWebElement buttonSignIn => loginBox.FindElement(By.CssSelector("#loginButton"));
        private IWebElement linkPasswordReminder => loginBox.FindElement(By.CssSelector(".remindtrigger"));
        private IWebElement buttonRegister => loginBox.FindElement(By.CssSelector(".regtrigger"));

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

        public LoginPage ClearInputsFeald()
        {
            inputEmail.Clear();
            inputPassword.Clear();
            return this;
        }
    }
}
