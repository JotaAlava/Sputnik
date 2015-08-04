using OpenQA.Selenium;
using Sputnik.Selenium;
using Xunit;

namespace Sputnik.Core.Commands
{
    public class IsNotCommand
    {
        /// <summary>
        /// This command will return either a true or false value based on the comparison.
        /// Will compare elements "text" property agaisnt the passed string.
        /// </summary>
        /// <param name="chosenSelectorByCssPath">CssPath of the element we will grab from the page.</param>
        /// <param name="valueToCompareWith">Value to compare against the element's "text" property.</param>
        /// <returns>True if there is no match. False if there is a match.</returns>
        public void ByCssPath(string chosenSelectorByCssPath, string valueToCompareWith)
        {
            var elementToCheck = Driver.Instance.FindElement(By.CssSelector(chosenSelectorByCssPath));
            Assert.True(elementToCheck.Text != valueToCompareWith, "Expected: " + valueToCompareWith + "\nActual: " + elementToCheck.Text);
        }

        /// <summary>
        /// This command will return either a true or false value based on the comparison.
        /// Will compare elements "text" property agaisnt the passed string.
        /// </summary>
        /// <param name="chosenSelectorById">Id attribute of the element we will grab from the page.</param>
        /// <param name="valueToCompareWith">Value to compare against the element's "text" property.</param>
        /// <returns>True if there is no match. False if there is a match.</returns>
        public void ById(string chosenSelectorById, string valueToCompareWith)
        {
            var elementToCheck = Driver.Instance.FindElement(By.Id(chosenSelectorById));
            Assert.True(elementToCheck.Text != valueToCompareWith, "Expected: " + valueToCompareWith + "\nActual: " + elementToCheck.Text);
        }

        /// <summary>
        /// This will return either true or false value based on the comparison.
        /// Will compare the elemenet returned by the Javascrip that was executed to the string that was passed as a second parameter
        /// </summary>
        /// <param name="jQuerySelector">jQuery script to run in order to select a page element</param>
        /// <param name="valueToCompareWith">Value we will use to execute the comparison. Will return true if there is NOT a match.</param>
        /// <returns>True if there is no match. False if there is a match.</returns>
        public void ByJQuery(string jQuerySelector, string valueToCompareWith)
        {
            var jsExecutor = Driver.Instance as IJavaScriptExecutor;
            var elem = jsExecutor.ExecuteScript(jQuerySelector);
            var elemText = elem.ToString();

            Assert.True(elemText != valueToCompareWith, "Expected: " + valueToCompareWith + "\nActual: " + elemText);
        }
    }
}
