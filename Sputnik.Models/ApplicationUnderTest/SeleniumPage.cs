using System.Configuration;
using Sputnik.Models.BaseModels;

namespace Sputnik.Models.ApplicationUnderTest
{
    public class SeleniumPage : Page
    {
        public SeleniumPage()
            : base(ConfigurationManager.AppSettings["DevEnvironment"])
        {
        }

        /// <summary>
        /// Navigates to the Url specified at construction time
        /// </summary>
        public void Goto()
        {
            GotoCommand.ByUrl(Url);
        }
    }
}
