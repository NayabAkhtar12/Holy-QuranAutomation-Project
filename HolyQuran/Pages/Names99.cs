using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;


namespace HolyQuran.Pages
{
    class Names99
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        TouchAction touchAction;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public Names99(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
            this.touchAction = new TouchAction(driver);
        }



        //public void CBanner()
        //{
        //    //**************Code to close c banner ***********
        //    try
        //    {

        //        var x = 667;
        //        var y = 850;

        //        touchAction.Tap(x, y).Perform();

        //        // new TouchAction(driver)
        //        //.Tap(PointOption.Point(x, y))
        //        //.Perform();
        //        Console.WriteLine("Tap performed successfully at coordinates: (" + x + ", " + y + ")");
        //    }
        //    catch (Exception ex)
        //    {
        //        HandleException("C Banner nt closeable", ex);
        //    }
        //}

        public void NamesOfAllah()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            SplashHandling2ndsession();
            Thread.Sleep(8000);

            //Main screen
            HandleCBanner(" Main Screen");

            Thread.Sleep(2000);

            //Names
            try
            {
                Namesnine.Click();
                InterAdHandle();

            }
            catch (Exception ex)
            {
                HandleException("99 Names", ex);
            }
            Thread.Sleep(2000);

            HandleCBanner(" 99 Names");
            // 99 Names Read
            try
            {
                Thread.Sleep(3000);
                ReadNamesAllah.Click();
                InterAdHandle();
                Thread.Sleep(2000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("99 Names Allah Read Issue", ex);
            }

            // 99 Names Listen
            try
            {
                ListenNamesAllah.Click();
                InterAdHandle();

                //C Banner close on Listen Names
                Thread.Sleep(2000);
                HandleCBanner("Names Allah  Listen");


                //Rest of action to perform on Names Listen screen
                try
                {
                    Nameplay.Click();
                    Thread.Sleep(6000);
                    Nameplay.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException(" Issue 99 Names Allah Listen ", ex);
                }

            }
            catch (Exception ex)
            {
                HandleException("99 Names  Allah listen Issue", ex);
            }

            //99 Names Nabi section

            try
            {
                ReadNamesHusna.Click();
                InterAdHandle();

                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                HandleException("99 Names Read Nabi Issue", ex);
            }

            // 99 Names Nabi  Listen
            try
            {
                ListenNamesNabi.Click();
                InterAdHandle();
                Thread.Sleep(2000);
                HandleCBanner("Names Nabi  Listen");


                try
                {
                    Nameplay.Click();
                    Thread.Sleep(6000);
                    Nameplay.Click();
                    driver.Navigate().Back();
                }

                catch (Exception ex)
                {
                    HandleException("NamesplayIssue", ex);
                }

            }
            catch (Exception ex)
            {
                HandleException("99 Names  Issue", ex);
            }

            driver.Navigate().Back();
        }


        void InterAdHandle1()
        {
            try
            {
                if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                {
                    adHelper.HandleAdCrossButton();
                }

                else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())
                    adHelper.HandleAdCloseButton();
                else
                    Console.WriteLine("No Interstial  Ad found");
            }
            catch (Exception ex)
            {
                HandleException("99 names  inter Ad", ex);
            }
        }

        void InterAdHandle()
        {
            try
            {
                if (adHelper.IsCrossButtonPresent())
                {
                    adHelper.HandleAdCrossButton();
                }

                else if (adHelper.IsCloseButtonPresent())
                    adHelper.HandleAdCloseButton();
                else
                    Console.WriteLine("No Interstial  Ad found");
            }
            catch (Exception ex)
            {
                HandleException("99 names  inter Ad", ex);
            }
        }

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }
        void Swipe()
        {
            TouchAction act = new TouchAction(driver);
            act.LongPress(200, 180).Wait(5000).MoveTo(900, 180).Release().Perform();
        }

        IWebElement ScrollToElementByText(string text)
        {
            return driver.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"{text}\"))"));
        }
        void SplashHandling2ndsession()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(Continue)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking Continue", ex);
            }

            InterAdHandle();

        }

        private void HandleCBanner(string context)
        {
            try
            {
                Thread.Sleep(2000); // Optional: Adjust or remove as needed
                adHelper.CBanner();
                // Thread.Sleep(2000); // Optional: Adjust or remove as needed
            }
            catch (Exception ex)
            {
                HandleException($"C Banner not Found on {context}", ex);
            }
        }
        IWebElement Namesnine => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        IWebElement ReadNamesHusna => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names");
        IWebElement ListenNamesNabi => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names");
        IWebElement ReadNamesAllah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma");
        IWebElement ListenNamesAllah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma");
        IWebElement Nameplay => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP");
        IWebElement Continue => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");


    }
}
