using System;
using OpenQA.Selenium;
using Sputnik.Selenium;
using NUnit.Framework;

namespace Sputnik.Core.Commands
{
    public class VisibleCommand
    {
        public void ByCssPath(string CssPath)
        {
            var elementToCheck = Driver.Instance.FindElement(By.CssSelector(CssPath));
            Assert.True(elementToCheck.Displayed, "Element is not visible!");
        }

        public void ById(string chosenSelectorById)
        {
            throw new NotImplementedException();
        }

        public void ByJQuery(string chosenSelectorByJquery)
        {
            throw new NotImplementedException();
        }
    }
}
