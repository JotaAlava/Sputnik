using OpenQA.Selenium;
using Sputnik.Selenium;

namespace Sputnik.Commands
{
    public class SubmitCommand
    {
        public void ById(string idOfDomElement)
        {
            var element = Driver.Instance.FindElement(By.Id(idOfDomElement));
            element.Submit();
        }
    }
}
