using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class DigitalTasbeeh
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public DigitalTasbeeh(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);
        }



        public void DigitalTasbeehMethod()
        {
            try
            {
                Thread.Sleep(3000);
                try
                {
                    ReusableMethods.ScrollToElementByText("Digital Tasbeeh");
                    digitalTasbeehMenu.Click();
                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Qibla Finder Menu", ex);
                }

                try
                {
                    EditZikrForCount.Click();
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("EditZikrForCount_Click", ex);
                }

                try
                {
                    SelectZikrForCount.Click();
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("SelectZikrForCount_Click", ex);
                }

                try
                {
                    CountPlus.Click();
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("CountPlus_Click_1", ex);
                }

                try
                {
                    CountPlus.Click();  // Second click on CountPlus
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("CountPlus_Click_2", ex);
                }

                try
                {
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("driver_Navigate_Back", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Digital Tasbeeh", ex);
            }
        }


        IWebElement digitalTasbeehMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivtasbeeh");
        IWebElement EditZikrForCount => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement SelectZikrForCount => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvZikar\" and @text=\"بِسْمِ اللهِ الرَّحْمٰنِ الرَّحِيْمِ\"]");
        IWebElement CountPlus => driver.FindElementById("com.hlyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtncount");

    }
}
