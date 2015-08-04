using Sputnik.Models.BaseModels;

namespace Sputnik.Models.ApplicationUnderTest.PageObjects
{
    public class Landing : SeleniumPage
    {
        /// <summary>
        /// Constructor for the landing page, it populates the Url that is used when Goto() is executed
        /// </summary>
        public Landing()
        {
            this.Url = "/";
        }

        /// <summary>
        /// Returns the selector for the submit button on the page
        /// </summary>
        public PageElement SubmitButton
        {
            get
            {
                return
                    new PageElement("submit");
            }
        }

        /// <summary>
        /// Returns the selector for the link to the tomato page
        /// </summary>
        public PageElement SearchInput
        {
            get
            {
                return
                    new PageElement("q");
            }
        }

        /// <summary>
        /// Returns the selector for the submit button on the page
        /// </summary>
        public PageElement DownloadLink
        {
            get
            {
                return
                    new PageElement("menu_download");
            }
        }
    }
}
