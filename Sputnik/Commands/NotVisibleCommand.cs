using System;
using OpenQA.Selenium;
using Sputnik.Selenium;
using Xunit;

namespace Sputnik.Commands
{
    public class NotVisibleCommand
    {
        public void ByCssPath(string CssPath)
        {
            var elementToCheck = Driver.Instance.FindElement(By.CssSelector(CssPath));
            Assert.True(!elementToCheck.Displayed, "Element is visible!");
        }

        public void ById(string chosenSelectorById)
        {
            var elementToCheck = Driver.Instance.FindElement(By.Id(chosenSelectorById));
            Assert.True(!elementToCheck.Displayed, "Element is visible!");
        }

        public void ByJQuery(string chosenSelectorByJquery)
        {
            throw new NotImplementedException();
        }
    }
}
