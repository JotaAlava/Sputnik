using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class MessagesTests : PublisherTestBase
    {
        [Fact]
        public void CanNavigateToMessagesSection()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Messages.Click();
            _publisher.Pages.MailDefault.InboxLabel.Is("Inbox");
        }
    }
}
