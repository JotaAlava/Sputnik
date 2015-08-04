using OpenQA.Selenium;
using Sputnik.Selenium;

namespace Sputnik.Core.Commands
{
    //TODO: Re-write this to math the pattern of the new page objects. - This was the first, and therefore experiemental command. 
    // - DO NOT USE THIS AS REFERENCE -
    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("ctl00_ContentPlaceHolder1_EmailTextBox"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("ctl00_ContentPlaceHolder1_PasswordTextBox"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("ctl00_ContentPlaceHolder1_LoginButton"));
            loginButton.Click();
        }
    }
}
