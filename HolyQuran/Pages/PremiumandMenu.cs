using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class PremiumandMenu
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelper adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public PremiumandMenu(AppiumDriver<AndroidElement> driver, ExtentTest test)
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
        public void PremiumandMenuMethod()
        {
            try
            {
                Pro.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Prayer Times", ex);
            }

            try
            {
                Menu.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Menu", ex);
            }

            try
            {
                PrivacyPolicy.Click();
                Thread.Sleep(7000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("PrivacyPolicy", ex);
            }

            try
            {
                Menu.Click();
                MoreApps.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("MoreApps", ex);
            }
            try
            {
                Menu.Click();
                RateUs.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("ExitApp", ex);
            }
            try
            {
                Menu.Click();
                ExitApp.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("ExitApp", ex);
            }
        }

        IWebElement Pro => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPurchaseBtn");
        IWebElement Menu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/menubtn");
        IWebElement PrivacyPolicy => driver.FindElementByXPath("//android.widget.TextView[@text=\"Privacy Policy\"]");
        IWebElement MoreApps => driver.FindElementByXPath("//android.widget.TextView[@text=\"More Apps\"]");
        IWebElement RateUs => driver.FindElementByXPath("//android.widget.TextView[@text=\"Rate Us!\"]");
        IWebElement ExitApp => driver.FindElementByXPath("//android.widget.TextView[@text=\"Exit\"]");
        IWebElement Yes => driver.FindElementByXPath("");
        IWebElement No => driver.FindElementByXPath("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/exit_no");

    }
}
