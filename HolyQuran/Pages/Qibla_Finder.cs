using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class Qibla_Finder
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        ReusableMethods ReusableMethods;

        //Constructor
        public Qibla_Finder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void QiblaFinder()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                qiblaMenu.Click();
                ReusableMethods.InterAdHandle();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Qibla Finder Menu", ex);
            }
            //     Thread.Sleep(2000);
            //     ThemesQibla.Click();
            try
            {
                ThemesQibla.Click();

                //   wait.Until(ExpectedConditions.ElementToBeClickable(ThemesQibla)).Click();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Qibla Finder Menu", ex);
            }

            try
            {
                Theme2.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Qibla Finder Menu", ex);
            }
        }


        IWebElement qiblaMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");
        IWebElement ThemesQibla => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement Theme2 => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla2");







    }
}
