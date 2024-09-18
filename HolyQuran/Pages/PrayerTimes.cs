using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class PrayerTimes
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public PrayerTimes(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);

        }


        public void PrayerTimesMethod()
        {
            try
            {
                //Thread.Sleep(3000);

                try
                {
                    ReusableMethods.ScrollToElementByText("Prayer Times");
                    prayerTimesMenu.Click();

                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Qibla Finder Menu", ex);
                }
                PrayerTimeNotification.Click();
                PrayerTimeNotification.Click();
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Prayer Times", ex);
            }
        }

        IWebElement PrayerTimeNotification => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ib_notification\"])[3]");

        IWebElement prayerTimesMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivprayers");



    }
}
