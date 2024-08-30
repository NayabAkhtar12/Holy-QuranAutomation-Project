using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class Azkar
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelper adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public Azkar(AppiumDriver<AndroidElement> driver, ExtentTest test)
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


        public void AzkarMethod()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                azkarMenu.Click();

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
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Azkar Menu", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(Azkar_DuaSelection1)).Click();
                Thread.Sleep(3000);
            }

            catch (Exception ex)
            {
                HandleException("Dua 1", ex);
            }
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(AddtoBookmark)).Click();

            }

            catch (Exception ex)
            {
                HandleException("Add to Bookmark", ex);
            }

            try
            {
                IWebElement ScrolltoLastDua = ScrollToElementByText("Praise is to Allah Who gave strength to my body, He returned my soul to me and permitted me to remember Him.");
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }

            catch (Exception ex)
            {
                HandleException("Dua 1 scrolling", ex);
                Thread.Sleep(20);
            }
            //Dua 2
            //try
            //{
            //    wait.Until(ExpectedConditions.ElementToBeClickable(Azkar_DuaSelection2)).Click();
            //    Thread.Sleep(3000);
            //}

            //catch (Exception ex)
            //{
            //    HandleException("Dua 2", ex);
            //}
            //try
            //{
            //    wait.Until(ExpectedConditions.ElementToBeClickable(AddtoBookmark)).Click();
            //}
            //catch (Exception ex)
            //{
            //    HandleException("Clicking AddtoBookmark", ex);
            //}

            //try
            //{
            //    driver.Navigate().Back();
            //}
            //catch (Exception ex)
            //{
            //    HandleException("Navigating back after adding to bookmark", ex);
            //}

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(BooksMarkAddedSec)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking BooksMarkAddedSec", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(ViewBookmark)).Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Clicking ViewBookmark", ex);
            }

            //try
            //{
            //    wait.Until(ExpectedConditions.ElementToBeClickable(AddtoBookmark)).Click();
            //}
            //catch (Exception ex)
            //{
            //    HandleException("Clicking AddtoBookmark again", ex);
            //}

            //try
            //{
            //    driver.Navigate().Back();
            //}
            //catch (Exception ex)
            //{
            //    HandleException("Navigating back after second AddtoBookmark click", ex);
            //}



            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Navigating back final time", ex);
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

        IWebElement azkarMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivazkar");
        IWebElement Azkar_DuaSelection1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Upon waking up\"]");
        IWebElement Azkar_DuaSelection2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Before Undressing\"]");
        IWebElement AddtoBookmark => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/button_star");
        IWebElement ViewBookmark => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName");
        IWebElement BooksMarkAddedSec => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/action_bookmarks");

    }
}
