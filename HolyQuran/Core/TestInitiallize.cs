using AventStack.ExtentReports;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Live_Earth_Map.Core
{
    public class TestInitiallize
    {
        public AndroidDriver<AndroidElement> driver;
        public ExtentReports Extent;


        public TestInitiallize()
        {
            //    var ExtentSparkReports = new ExtentSparkReporter("D:\\");
            Extent = new ExtentReports();
            // Extent.AttachReporter(ExtentSparkReports);
        }

        [TestInitialize]
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Vivo Y03");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
                driver = new AndroidDriver<AndroidElement>(new Uri("http://192.168.100.14:4723/"), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            try
            {
                if (driver != null)
                {
                    driver.CloseApp();
                    driver.Quit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
            Extent.Flush();

        }
    }
}
