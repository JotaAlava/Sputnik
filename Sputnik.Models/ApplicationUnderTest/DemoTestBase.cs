using System;

namespace Sputnik.Models.ApplicationUnderTest
{
    public class DemoTestBase : IDisposable
    {
        public ApplicationUnderTest ApplicationUnderTest;

        public DemoTestBase()
        {
            ApplicationUnderTest = new ApplicationUnderTest();
            ApplicationUnderTest.LaunchInFirefox();
        }

        public void Dispose()
        {
            ApplicationUnderTest.Destroy();
        }
    }
}
