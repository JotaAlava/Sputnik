using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Sputnik.Selenium
{
    public class Driver
    {
        internal static IWebDriver Instance { get; set; }

        public static void InitializeFirefox()
        {
            Instance = new FirefoxDriver();
            // This makes selenium wait at least 5 seconds before saying that the element in the page cannot be found
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            foreach (var window in Instance.WindowHandles)
            {
                Instance.SwitchTo().Window(window);
                Instance.Close();
            }
        }

        public static void Wait(TimeSpan durationOfWait)
        {
            Thread.Sleep((int) (durationOfWait.TotalSeconds*1000));
        }

        public static void SwitchToPopUp()
        {
            Instance.SwitchTo().Window(Instance.WindowHandles[1]);
        }
    }
}
