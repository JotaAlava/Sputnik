using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class AccountTests : PublisherTestBase
    {
        [Fact]
        public void CanNavigateToAccountSection()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Account.Click();
            Assert.True(_publisher.Pages.EmailSettings.Header.Like("Manage E-Mail Alerts and Notifications ( View Description )"), "Could not navigate to the accounts section");
        }
    }
}
