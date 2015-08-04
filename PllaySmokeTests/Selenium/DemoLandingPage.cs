using NUnit.Framework;
using Sputnik.Models.ApplicationUnderTest;

namespace DemoSmokeTests.Selenium
{
    [TestFixture]
    public class DemoLandingPage : DemoTestBase
    {        
        [Test]
        public void DemoTest()
        {
            ApplicationUnderTest.Pages.Timer.Goto();
            ApplicationUnderTest.Pages.Timer.DownloadLink.Click();
            ApplicationUnderTest.Pages.Timer.SearchInput.Set("example search");

            ApplicationUnderTest.Pages.Timer.SubmitButton.Click();
            ApplicationUnderTest.Pages.SearchResults.AboutLabel.Like("About");
        }
    }
}
