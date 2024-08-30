using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class Qibla_Finder
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelper adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public Qibla_Finder(AppiumDriver<AndroidElement> driver, ExtentTest test)
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

        public void QiblaFinder()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(qiblaMenu)).Click();
                if (adHelper.IsAdPresent())
                {
                    adHelper.HandleAd();
                }
            }
            catch (Exception ex)
            {
                HandleException("Qibla Finder Menu", ex);
            }
            //     Thread.Sleep(2000);
            //     ThemesQibla.Click();
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(ThemesQibla)).Click();

            }
            catch (Exception ex)
            {
                HandleException("Qibla Finder Themes", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(Theme2)).Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Qibla Finder Theme 2", ex);
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
        IWebElement qiblaMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");
        IWebElement ThemesQibla => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement Theme2 => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla2");







    }
}
