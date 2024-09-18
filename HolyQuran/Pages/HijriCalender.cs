using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class HijriCalender
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public HijriCalender(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);

        }



        public void HijriCalendar()
        {
            try
            {
                Thread.Sleep(3000);
                try
                {
                    ReusableMethods.ScrollToElementByText("Hijri Calender");
                    hijriCalendarMenu.Click();

                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Ad Issue", ex);
                }

                NextMonth.Click();
                PrevMonth.Click();
                Date.Click();
                NextMonth.Click();
                Date.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Calender", ex);
            }
        }

        IWebElement hijriCalendarMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivcalendar");
        IWebElement PrevMonth => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month");
        IWebElement NextMonth => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month");
        IWebElement Date => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/gregorian_calendar_day\" and @text=\"14\"]");




    }
}
