using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class ErrorPageTests : PublisherTestBase
    {
        [Fact]
        public void CanCreateTicketFromErrorPage()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.Pages.ErrorIn.Goto();
            _publisher.Pages.ErrorIn.CommentBox.Set("This is a comment for a ticket created with Sputnik!");

            _publisher.Pages.ErrorIn.SubmitButton.Click();
            _publisher.Pages.ErrorIn.UserFeedbackLabel.Like("has been created. Thank you for reporting this issue!");
        }
    }
}
