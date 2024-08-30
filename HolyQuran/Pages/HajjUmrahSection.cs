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
        private AdHelper adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public HajjUmrahSection(AppiumDriver<AndroidElement> driver, ExtentTest test)
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


        public void HajjGuide()
        {
            try
            {
                hajjUmrahMenu.Click();
                // Thread.Sleep(3000); // Assuming a delay after click for the view to load
                try
                {
                    if (adHelper.IsAdPresent())
                    {
                        adHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Ad Failed", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Hajj and Umrah", ex);
            }

            try
            {
                HajjGuideMenu.Click();
                try
                {
                    if (adHelper.IsAdPresent())
                    {
                        adHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Hajj Guide Menu Ad Failed", ex);
                }
                HajjGuideDay1.Click();
                Thread.Sleep(1000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 1", ex);
            }

            try
            {
                HajjGuideDay2.Click();
                Thread.Sleep(1000); // Assuming a delay after click for the view to load
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 2", ex);
            }

            try
            {
                HajjGuideDay3.Click();
                Thread.Sleep(1000);
                driver.Navigate().Back();


            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 3", ex);
            }

            try
            {
                HajjGuideDay4.Click();
                Thread.Sleep(1000); // Assuming a delay after click for the view to load
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 4", ex);
            }

            try
            {
                HajjGuideDay5.Click();
                Thread.Sleep(2000); // Assuming a delay after click for the view to load
                driver.Navigate().Back();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 5", ex);
            }

        }
        public void UmrahGuide()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                UmrahGuideMenu.Click();
                try
                {
                    if (adHelper.IsAdPresent())
                    {
                        adHelper.HandleAd();
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Ad Failed umrah", ex);
                }
                wait.Until(ExpectedConditions.ElementToBeClickable(UmrahIhram)).Click();
                Thread.Sleep(1000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Umrah Ihram", ex);
            }
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(UmrahTawaf)).Click();
                Thread.Sleep(2000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Umrah Tawaf", ex);
            }
            try
            {
                UmrahSAEE.Click();
                Thread.Sleep(1000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Umrah Sa'ee", ex);
            }
            try
            {
                UmrahShaving.Click();
                Thread.Sleep(1000);
                driver.Navigate().Back();
                driver.Navigate().Back();
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                HandleException("Umrah Shaving", ex);
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

                driver.Navigate().Back();
                driver.Navigate().Back();

                FamousPlacesofMakkahMina.Click();
                Thread.Sleep(3000);

                driver.Navigate().Back();
                driver.Navigate().Back();
                //  driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Kaaba/Mina Location Makkah ", ex);
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

                driver.Navigate().Back();
                driver.Navigate().Back();
                FamousPlacesofMedinah_UhudMountain.Click();
                Thread.Sleep(3000);

                driver.Navigate().Back();
                driver.Navigate().Back();
                Thread.Sleep(1500);
                driver.Navigate().Back();
                HajhUmrahUQibla.Click();
                Thread.Sleep(1500);
                driver.Navigate().Back();
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                HandleException("Medina Places", ex);
            }
            driver.Navigate().Back();


        }


        public IWebElement ScrollToElementByText(string text)
        {
            return driver.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"{text}\"))"));
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
