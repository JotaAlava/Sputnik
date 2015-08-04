using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class Advertisers : PublisherTestBase
    {
        [Fact]
        public void CanNavigateToAdversiters()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Advertisers.Click();
            _publisher.Pages.Categories.Header.Is("Categories");
        }
    }
}
