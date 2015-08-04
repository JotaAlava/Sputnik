using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class SupportTests : PublisherTestBase
    {
        [Fact]
        public void CanNavigateToSupport()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Support.Click();
            _publisher.Pages.View.Header.Is("View Tickets ( View Description )");
        }
    }
}
