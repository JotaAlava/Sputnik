using System;
using Sputnik.Models.Publisher;
using Sputnik.Models.Publisher.Settings;
using Xunit;

namespace PublisherSmokeTests
{
    public class LinksTests : PublisherTestBase
    {
        [Fact]
        public void Search_Blank_MoreThan0PagesOfResultsExist()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Links.Click();
            _publisher.Pages.GetLinks.SearchInputBox.Set(String.Empty);

            _publisher.Pages.GetLinks.SearchButton.Click();
            _publisher.Pages.GetLinks.SearchResultPageCount().IsNot("0"); // Check that there + pages than 0
        }

        //TODO: Finish the implementation for this Fact. 1. Model Out The Table. Create a mechanism to switch frames
        [Fact]
        public void CanGetLinkFromAdvertiser_InSearchResults()
        {
            _publisher.Pages.LoginPage.LoginAs(PublisherRoles.Admin);
            _publisher.NavigationMenu.Links.Click();
            _publisher.Pages.GetLinks.SearchInputBox.Set(String.Empty);

            _publisher.Pages.GetLinks.SearchButton.Click();
            _publisher.Pages.GetLinks.FirstSearchResultViewLinkButton.Click();
            _publisher.SwitchWindowByUrl();

            _publisher.Pages.LinkDetails.LinkTextArea.Like("<a target=");
        }
    }
}
