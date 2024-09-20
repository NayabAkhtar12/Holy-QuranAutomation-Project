using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class HajjUmrahSection
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;


        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public HajjUmrahSection(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);
        }


        public void HajjGuide()
        {
            try
            {
                // Thread.Sleep(3000); // Assuming a delay after click for the view to load
                try
                {
                    ReusableMethods.ScrollToElementByText("Hajj and Umrah Section");
                    hajjUmrahMenu.Click();
                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Ad Failed", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Hajj and Umrah", ex);
            }

            try
            {
                try
                {
                    HajjGuideMenu.Click();
                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Hajj Guide Menu Ad Failed", ex);
                }
                HajjGuideDay1.Click();
                Thread.Sleep(1000);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("  BackButton Navigation ", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Hajj Day 1", ex);
            }

            try
            {
                HajjGuideDay2.Click();
                Thread.Sleep(1000); // Assuming a delay after click for the view to load
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Hajj Day 2", ex);
            }

            try
            {
                HajjGuideDay3.Click();
                Thread.Sleep(1000);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Hajj Day 3", ex);
            }

            try
            {
                HajjGuideDay4.Click();
                Thread.Sleep(1000); // Assuming a delay after click for the view to load
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Hajj Day 4", ex);
            }

            try
            {
                HajjGuideDay5.Click();
                Thread.Sleep(2000); // Assuming a delay after click for the view to load
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Hajj Day 5", ex);
            }

        }
        public void UmrahGuide()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                try
                {
                    UmrahGuideMenu.Click();
                    ReusableMethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Ad Failed umrah", ex);
                }
                wait.Until(ExpectedConditions.ElementToBeClickable(UmrahIhram)).Click();
                Thread.Sleep(1000);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Umrah Ihram", ex);
            }
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(UmrahTawaf)).Click();
                Thread.Sleep(2000);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Umrah Tawaf", ex);
            }
            try
            {
                UmrahSAEE.Click();
                Thread.Sleep(1000);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Umrah Sa'ee", ex);
            }
            try
            {
                UmrahShaving.Click();
                Thread.Sleep(1000);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Umrah Shaving", ex);
            }
        }

        public void FamousPlacesofMakkah()
        {
            try
            {
                FamousPlacesofMakkahMenu.Click();
                Thread.Sleep(3000);
                FamousPlacesofMakkahKaaba.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                FamousPlacesofMakkahMina.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }                //  driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Kaaba/Mina Location Makkah ", ex);
            }
        }
        public void FamousPlacesofMedina()
        {
            try
            {
                FamousPlacesofMedinahMenu.Click();
                Thread.Sleep(3000);

                FamousPlacesofMedinah_AlNabwi.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                FamousPlacesofMedinah_UhudMountain.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                Thread.Sleep(1500);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                HajhUmrahUQibla.Click();
                Thread.Sleep(1500);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Medina Places", ex);
            }
            try
            {
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Backbutton", ex);
            }

        }



        IWebElement hajjUmrahMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnameshusna");
        IWebElement HajjGuideMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivhajj");
        IWebElement HajjGuideDay1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"8th of Dhul Hijjah\"]");
        IWebElement HajjGuideDay2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"9th of Dhul Hijjah\"]");
        IWebElement HajjGuideDay3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"10th of Dhul Hijjah\"]");
        IWebElement HajjGuideDay4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"11th of Dhul Hijjah\"]");
        IWebElement HajjGuideDay5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"12th of Dhul Hijjah\"]");
        IWebElement HajjGuideDay6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc\" and @text=\"13th of Dhul Hijjah\"]");

        IWebElement UmrahGuideMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivumrah");
        IWebElement UmrahIhram => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"IHRAM\"]");
        IWebElement UmrahTawaf => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"TAWAAF\"]");
        IWebElement UmrahSAEE => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"SA’EE\"]");
        IWebElement UmrahShaving => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"SHAVING\"]");

        IWebElement FamousPlacesofMakkahMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmakkah");
        IWebElement FamousPlacesofMakkahKaaba => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Kaaba\"]");
        IWebElement FamousPlacesofMakkahMina => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Mina\"]");

        IWebElement FamousPlacesofMedinahMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmadina");
        IWebElement FamousPlacesofMedinah_AlNabwi => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Al Masjid an Nabawi\"]");
        IWebElement FamousPlacesofMedinah_UhudMountain => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay\" and @text=\"Uhud Mountain\"]");
        IWebElement HajhUmrahUQibla => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");

    }
}
