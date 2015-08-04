using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class ReportsTests : PublisherTestBase
    {
        [Fact]
        public void CanNavigateToReports()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Reports.Click();
            _publisher.Pages.Reports.NoTop5AdvertiserChartAvailableLabel.Exist();

            _publisher.Pages.Reports.NoChartAvailableLabel.Exist();
            _publisher.Pages.Reports.DataRangeDropdown.SetPostBackDropdown("This Year");
            _publisher.Pages.Reports.NoChartAvailableLabel.NotExist();

            _publisher.Pages.Reports.NoTop5AdvertiserChartAvailableLabel.NotExist();
        }
    }
}
