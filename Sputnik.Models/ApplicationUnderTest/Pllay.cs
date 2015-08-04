using Sputnik.Models.ApplicationUnderTest.PageObjects;
using Sputnik.Selenium;

namespace Sputnik.Models.ApplicationUnderTest
{
    /// <summary>
    /// This is class is a model for SeleniumPage
    /// </summary>
    public class ApplicationUnderTest
    {
        /// <summary>
        /// All the pages can be found within this property
        /// </summary>
        public Pages Pages { get { return new Pages(); } }

        /// <summary>
        /// The model holds the drivers with which it will be navigated.
        /// This method launches the Firefox Landing driver.
        /// </summary>
        public void LaunchInFirefox()
        {
            Driver.InitializeFirefox();
        }

        /// <summary>
        /// The model holds the drivers with which it will be navigated.
        /// This method destroys the Firefox Landing driver.
        /// </summary>
        public void Destroy()
        {
            Driver.Close();
        }

        /// <summary>
        /// This allows Sputnik to switch between windows.
        /// </summary>
        public void SwitchWindowByUrl()
        {
            Driver.SwitchToPopUp();
        }
    }
}
