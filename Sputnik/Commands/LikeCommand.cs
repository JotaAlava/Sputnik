using System;
using OpenQA.Selenium;
using Sputnik.Selenium;

namespace Sputnik.Commands
{
    public class LikeCommand
    {
        /// <summary>
        /// Will check if the specified CssPath returns an element that contains the query string
        /// </summary>
        /// <param name="cssPath">The csspath of the element we want to check for</param>
        /// <param name="queryString">The string to search for somewhere inside the page element</param>
        /// <returns>True if the element contains the query string</returns>
        public bool ByCssPath(string chosenSelectorByCssPath, string valueToCompareWith)
        {
            var element = Driver.Instance.FindElement(By.CssSelector(chosenSelectorByCssPath));
            return element.Text.Contains(valueToCompareWith);
        }

        public bool ById(string chosenSelectorById, string valueToCompareWith)
        {
            var element = Driver.Instance.FindElement(By.Id(chosenSelectorById));
            return element.Text.Contains(valueToCompareWith);
        }

        public bool ByJQuery(string chosenSelectorByJquery, string valueToCompareWith)
        {
            throw new NotImplementedException();
        }
    }
}
