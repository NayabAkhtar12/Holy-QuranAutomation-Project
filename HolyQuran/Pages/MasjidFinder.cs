using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace HolyQuran.Pages
{
    class MasjidFinder
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelper adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public MasjidFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelper(driver); // Initialize AdHelper with the correct driver type
        }


        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        public void MasjidFinderMethod()
        {
            try
            {
                masjidFinderMenu.Click();
                Thread.Sleep(3000);
                //  ViewList.Click();
                try
                {
                    if (adHelper.IsAdPresent())
                    {
                        adHelper.HandleAd();
                    }

                }
                catch (Exception ex)
                {
                    HandleException("Ad Issue", ex);
                }
                driver.Navigate().Back();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Masjid Finder", ex);

            }
        }


        public void Swipe()
        {
            TouchAction act = new TouchAction(driver);
            act.LongPress(200, 180).Wait(5000).MoveTo(900, 180).Release().Perform();
        }

        public IWebElement ScrollToElementByText(string text)
        {
            return driver.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"{text}\"))"));
        }


        IWebElement masjidFinderMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid");
    }
}
