using Sputnik.Models.BaseModels;

namespace Sputnik.Models.ApplicationUnderTest.PageObjects
{
    public class SearchResults : SeleniumPage
    {
        /// <summary>
        /// Constructor for the login page, it populates the Url that is used when Goto() is executed
        /// </summary>
        public SearchResults()
        {
            this.Url = "/";
        }

        /// <summary>
        /// Returns the selector for the about label
        /// </summary>
        public PageElement AboutLabel
        {
            get
            {
                return
                    new PageElement("resInfo-0");
            }
        }
    }
}
