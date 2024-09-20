using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class MasjidFinder
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public MasjidFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);
        }




        public void MasjidFinderMethod()
        {
            try
            {
                Thread.Sleep(3000);
                //  ViewList.Click();
                try
                {
                    ReusableMethods.ScrollToElementByText("Masjid Finder");
                    masjidFinderMenu.Click();
                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Ad Issue", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Masjid Finder", ex);

            }
        }





        IWebElement masjidFinderMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid");
    }
}
