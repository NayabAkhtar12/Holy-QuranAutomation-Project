﻿using AventStack.ExtentReports;
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
        TouchAction touchAction;
        ReusableMethods ReusableMethods;

        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public Names99(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.touchAction = new TouchAction(driver);
            ReusableMethods = new ReusableMethods(driver, test);
        }


        public void NamesOfAllah()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            ReusableMethods.SplashHandling2ndsessiont();
            //    Thread.Sleep(8000);

            //Main screen
            //   HandleCBanner(" Main Screen");

            //  Thread.Sleep(2000);

            //Names
            try
            {
                Namesnine.Click();
                ReusableMethods.InterAdHandle();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names", ex);
            }
            // Thread.Sleep(2000);

            //  HandleCBanner(" 99 Names");
            // 99 Names Read
            try
            {
                Thread.Sleep(3000);
                ReadNamesAllah.Click();
                ReusableMethods.InterAdHandle();
                Thread.Sleep(2000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names Allah Read Issue", ex);
            }

            // 99 Names Listen
            try
            {
                ListenNamesAllah.Click();
                ReusableMethods.InterAdHandle();
                //C Banner close on Listen Names
                // Thread.Sleep(2000);
                //  HandleCBanner("Names Allah  Listen");


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
                    ReusableMethods.HandleException(" Issue 99 Names Allah Listen ", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names  Allah listen Issue", ex);
            }

            //99 Names Nabi section

            try
            {
                ReadNamesHusna.Click();
                ReusableMethods.InterAdHandle();
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names Read Nabi Issue", ex);
            }

            // 99 Names Nabi  Listen
            try
            {
                ListenNamesNabi.Click();
                ReusableMethods.InterAdHandle();
                //    Thread.Sleep(2000);
                // HandleCBanner("Names Nabi  Listen");


                try
                {
                    Nameplay.Click();
                    Thread.Sleep(6000);
                    Nameplay.Click();
                    driver.Navigate().Back();
                }

                catch (Exception ex)
                {
                    ReusableMethods.HandleException("NamesplayIssue", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names  Issue", ex);
            }

            driver.Navigate().Back();
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
