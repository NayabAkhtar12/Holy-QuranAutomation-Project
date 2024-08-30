using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;


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


        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }


        public void NamesOfAllah()
        {
            /////////////////// c banner
            //  client.ClickCoordinate(100, 100, 1);



            try
            {
                Namesnine.Click();

                try
                {
                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }

                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())

                    {
                        adHelper.HandleAdCloseButton();

                    }

                    else
                    {
                        Console.WriteLine("No Ad found");
                    }
                }
                catch (Exception ex)
                {
                    HandleException("99 names Menu and Ad", ex);
                }

                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("99 Names", ex);
            }



            // 99 Names Read
            try
            {
                ReadNamesAllah.Click();

                try
                {
                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }

                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())

                    {
                        adHelper.HandleAdCloseButton();

                    }

                    else
                    {
                        Console.WriteLine("No Ad found");
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Ad Handling Issue 99 Names Read", ex);
                }

                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("99 Names Read Issue", ex);
            }

            // 99 Names Listen
            try
            {
                ListenNamesAllah.Click();
                try
                {
                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }

                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())

                    {
                        adHelper.HandleAdCloseButton();

                    }

                    else
                    {
                        Console.WriteLine("No Ad found");
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Ad Handling Issue 99 Names Allah Listen ", ex);
                }
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

                try
                {
                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }

                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())

                    {
                        adHelper.HandleAdCloseButton();

                    }

                    else
                    {
                        Console.WriteLine("No Ad found");
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Ad Handling Issue 99 Names Nabi  Read", ex);
                }


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

                try
                {
                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }

                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())

                    {
                        adHelper.HandleAdCloseButton();

                    }

                    else
                    {
                        Console.WriteLine("No Ad found");
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Ad Handling Issue 99 Names Nabi  Listening Issue", ex);
                }

                Nameplay.Click();
                Thread.Sleep(6000);
                Nameplay.Click();
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                HandleException("99 Names  Issue", ex);
            }


            driver.Navigate().Back();
        }

        //public void NamesOfMuhammad()
        //{
        //    try
        //    {
        //        namesOfMuhammadMenu.Click();
        //        Thread.Sleep(3000); // Assuming a delay after click for the view to load
        //                            // Perform other operations related to 99 Names of Muhammad here
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception occurred: " + ex.Message);
        //        Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
        //    }
        //}

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

        IWebElement Namesnine => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        IWebElement ReadNamesHusna => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names");
        IWebElement ListenNamesNabi => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names");
        IWebElement ReadNamesAllah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma");
        IWebElement ListenNamesAllah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma");
        IWebElement Nameplay => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP");


    }
}
