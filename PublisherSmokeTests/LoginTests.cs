using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class LoginTests : PublisherTestBase
    {        
        [Fact]
        public void Admin_User_Can_Login()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);

            _publisher.Pages.Landing.AnnouncementLabel.Visible();
        }
    }
}
