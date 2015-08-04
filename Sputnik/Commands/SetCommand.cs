using OpenQA.Selenium;
using Sputnik.Selenium;

namespace Sputnik.Core.Commands
{
    public class SetCommand
    {
        /// <summary>
        /// This will set a value on a specific page
        /// </summary>
        /// <param name="idOfDomElement">Selector to use to interact with page</param>
        /// <param name="valueToSet">Value to set the page element to</param>
        public void ById(string idOfDomElement, string valueToSet)
        {
            var loginInput = Driver.Instance.FindElement(By.Id(idOfDomElement));
            loginInput.SendKeys(valueToSet);
        }
    }
}
