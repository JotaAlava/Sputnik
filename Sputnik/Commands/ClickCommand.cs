using OpenQA.Selenium;
using Sputnik.Selenium;

namespace Sputnik.Commands
{
    public class ClickCommand
    {
        /// <summary>
        /// Will click an element by using the selenium web driver.
        /// </summary>
        /// <param name="idOfDomElement">Id of the DOM element to click</param>
        public void ById(string idOfDomElement)
        {
            var element = Driver.Instance.FindElement(By.Id(idOfDomElement));
            element.Click();
        }

        /// <summary>
        /// Will click an element by using the selenium web driver
        /// </summary>
        /// <param name="cssPathOfDomElement">Css path of the DOM element to click</param>
        public void ByCssPath(string cssPathOfDomElement)
        {
            var element = Driver.Instance.FindElement(By.CssSelector(cssPathOfDomElement));
            element.Click();
        }

        public void ByJquery(string jQuerySelector)
        {
            //TODO: Implement clicking by jQuery
        }
    }
}
