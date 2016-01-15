using System;
using OpenQA.Selenium;
using Sputnik.Selenium;
using NUnit.Framework;

namespace Sputnik.Core.Commands
{
    public class ExistCommand
    {
        /// <summary>
        /// Will check if the specified CssPath returns an element that currently exists on the page
        /// </summary>
        /// <param name="cssPath">The csspath of the element we want to check for</param>
        public void ByCssPath(string cssPath)
        {
            var element = Driver.Instance.FindElements(By.CssSelector(cssPath));
            Assert.True(element != null, "The element does not exist!");
        }

        /// <summary>
        /// Will check if the specified Id returns an element that currently exists on the page
        /// </summary>
        /// <param name="chosenSelectorById">The Id of the element whose existance we want to check for</param>
        public void ById(string chosenSelectorById)
        {
            var element = Driver.Instance.FindElements(By.Id(chosenSelectorById));
            Assert.True(element != null, "The element does not exist!");
        }

        /// <summary>
        /// Will check if the specified JQuery selector returns an element that currently exists on the page
        /// </summary>
        /// <param name="chosenSelectorByJquery"></param>
        public void ByJQuery(string chosenSelectorByJquery)
        {
            throw new NotImplementedException();
        }
    }
}
