using System;
using OpenQA.Selenium;
using Sputnik.Selenium;
using Xunit;

namespace Sputnik.Commands
{
    public class NotExistCommand
    {
        /// <summary>
        /// Will check if the specified CssPath returns an element that currently does not exist on the page
        /// </summary>
        /// <param name="cssPath">The csspath of the element we want to check for</param>
        /// <returns>False if the element was found, true if the element was not found</returns>
        public void ByCssPath(string cssPath)
        {
            var element = Driver.Instance.FindElements(By.CssSelector(cssPath));
            Assert.True(element.Count == 0, "Element exists!");
        }

        /// <summary>
        /// Will check if the specified Id returns an element that currently does not exist on the page
        /// </summary>
        /// <param name="chosenSelectorById"></param>
        /// <param name="valueToCompareWith"></param>
        public void ById(string chosenSelectorById)
        {
            var element = Driver.Instance.FindElements(By.Id(chosenSelectorById));
            Assert.True(element.Count == 0, "Element exists!");
        }

        /// <summary>
        /// Will check if the specified jQuery selector returns an element that currently does not exist on the page
        /// </summary>
        /// <param name="chosenSelectorByJquery"></param>
        /// <returns></returns>
        public bool ByJQuery(string chosenSelectorByJquery)
        {
            var jsExecutor = Driver.Instance as IJavaScriptExecutor;
            var elem = jsExecutor.ExecuteScript(chosenSelectorByJquery);

            return elem.ToString() != string.Empty;
        }
    }
}
