using System;
using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class CsvGeneratorTest : PublisherTestBase
    {
        [Fact]
        public void GenerateCSV()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Links.Click();
            _publisher.Pages.GetLinks.SearchInputBox.Set(String.Empty);

            _publisher.Pages.GetLinks.SearchButton.Click();
            _publisher.Pages.GetLinks.ExportToCsvButton().Click();
            _publisher.Pages.GetLinks.ExportConfirmButton().Click();

            //TODO: Fix Bug http://projects/issue/FlexFeeds-9 in order to be able to finish the implementation of this Fact - Will fail the Fact until then
            // Not sure what happens when the CSV feature actually does work, so for until the fix is in place I will check that the server error is NOT there
            _publisher.Pages.GetLinks.ServerErrorBanner.NotVisible();
        }
    }
}
