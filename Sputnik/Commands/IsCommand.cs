using OpenQA.Selenium;
using Sputnik.Selenium;
using NUnit.Framework;

namespace Sputnik.Core.Commands
{
    public class IsCommand
    {
        /// <summary>
        /// This command will return either a true or false value based on the comparison.
        /// Will compare elements "text" property agaisnt the passed string.
        /// </summary>
        /// <param name="chosenSelectorByCssPath">CssPath of the element we will grab from the page.</param>
        /// <param name="valueToCompareWith">Value to compare against the element's "text" property.</param>
        /// <returns></returns>
        public void ByCssPath(string chosenSelectorByCssPath, string valueToCompareWith)
        {
            var elementToCheck = Driver.Instance.FindElement(By.CssSelector(chosenSelectorByCssPath));
            Assert.True(elementToCheck.Text == valueToCompareWith, "Expected: " + valueToCompareWith + "\nActual: " + elementToCheck.Text);
        }

        /// <summary>
        /// This command will return either a true or false value based on the comparison.
        /// Will compare elements "text" property agaisnt the passed string.
        /// </summary>
        /// <param name="chosenSelectorById">Id attribute of the element we will grab from the page.</param>
        /// <param name="valueToCompareWith">Value to compare against the element's "text" property.</param>
        /// <returns></returns>
        public void ById(string chosenSelectorById, string valueToCompareWith)
        {
            var elementToCheck = Driver.Instance.FindElement(By.Id(chosenSelectorById));
            Assert.True(elementToCheck.Text == valueToCompareWith, "Expected: " + valueToCompareWith + "\nActual: " + elementToCheck.Text);
        }

        /// <summary>
        /// This command will return either a true or false based on the comparison
        /// Will compare elements "text" property agaisnt the passed string.
        /// </summary>
        /// <param name="chosenSelectorByJquery">jQuery selector for element</param>
        /// <param name="valueToCompareWith">Value to compare against the element's "text" property.</param>
        /// <returns></returns>
        public void ByJQuery(string chosenSelectorByJquery, string valueToCompareWith)
        {
            var jsExecutor = Driver.Instance as IJavaScriptExecutor;
            var elem = jsExecutor.ExecuteScript(chosenSelectorByJquery);

            Assert.True(elem.ToString() == valueToCompareWith, "Expected: " + valueToCompareWith + "\nActual: " + elem.ToString());
        }
    }
}
