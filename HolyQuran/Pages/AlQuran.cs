using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class AlQuran
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public AlQuran(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
        }


        public void QuranLaunch()
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

            //try
            //{
            //    adHelper.HandleAd();
            //}
            catch (Exception ex)
            {
                HandleException("Hanling Splash Ad", ex);
            }



            try
            {
                LanguageSave.Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking LanguageSave", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(OnboardSkip)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking OnboardSkip", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(OnboardFinish)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking OnboardFinish", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(StoragePermissionAllow)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking StoragePermissionAllow", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(LocationPermissionAllow)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking LocationPermissionAllow", ex);
            }


        }

        public void AlQuranDownload()
        {
            try
            {
                ALQuranMenu.Click();
                Thread.Sleep(60000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking Quran Menu", ex);
            }


            //try
            //{

            //WebDriverWait waitReadQuran = new WebDriverWait(driver, TimeSpan.FromSeconds(120));

            //waitReadQuran.Until(ExpectedConditions.ElementToBeClickable(ReadQuran));

            //}
            //catch (Exception ex)
            //{
            //    HandleException("Clicking Read Quran", ex);
            //}

            //   adHelper.HandleAd();

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Clicking Back button Quran", ex);
            }

        }
        public void PerformQuranOperations()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                ALQuranMenu.Click();
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
                    HandleException("Ad Issue", ex);
                }
                Thread.Sleep(3000);

            }
            catch (Exception ex)
            {
                HandleException("Clicking AlQuran and Ad", ex);
            }
            try
            {
                AlFatiha.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking AlFatiha", ex);
            }
            try
            {
                SelectReciterDropDown.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking RecitersDropdown", ex);
            }

            try
            {
                SelectReciter.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking SelectReciter", ex);
            }

            try
            {
                PlaySurah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking PlaySurah", ex);
            }

            try
            {
                NextAyah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking NextAyah", ex);
            }

            try
            {
                PrevAyah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking PrevAyah", ex);
            }

            try
            {
                PlaySurah.Click(); // Assuming PlaySurah needs to be clicked again after NextAyah and PrevAyah
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking PlaySurah again", ex);
            }

            try
            {
                BookMarkPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking BookMarkPage", ex);
            }

            try
            {
                GotoTranslationsection.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking GotoTranslationsection", ex);
            }

            try
            {
                DownloadTranslation.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking DownloadTranslation", ex);
            }
            try
            {
                DownloadedSection.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking DownloadedSection", ex);
            }
            try
            {
                ViewTranslation.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking ViewTranslation", ex);
            }

            try
            {
                TranslationNextPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking TranslationNextPage", ex);
            }

            try
            {
                TranslationPrevPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking TranslationPrevPage", ex);
            }

            try
            {
                driver.Navigate().Back();
                driver.Navigate().Back();


            }
            catch (Exception ex)
            {
                HandleException("Navigating back", ex);
            }

        }

        public void Bookmarks()
        {
            try
            {
                AlFatiha.Click();
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
                    HandleException("Clicking Ad on AlFatiha", ex);
                }

                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Clicking AlFatiha", ex);
            }


            try
            {
                IWebElement AddressItem = driver.FindElement(MobileBy.AndroidUIAutomator(
                "new UiScrollable(new UiSelector().scrollable(true))" +
                ".scrollIntoView(new UiSelector().text(\"Address*\"))"));
            }
            catch (Exception ex)
            {
                HandleException("Scroll Issue occured", ex);
            }


        }
        public void PerformSwipeOperations()
        {
            try
            {

                Surah2.Click();
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
                    HandleException("Clicking Ad on AlFatiha", ex);
                }

                Swipe();
                Thread.Sleep(3000);

                Swipe();
                Thread.Sleep(3000);

                Swipe();

                SurahBack.Click();
            }
            catch (Exception ex)
            {
                HandleException("Surah Aal e Imran Swipe", ex);
            }

            try
            {
                SurahAnNisa.Click();
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
                    HandleException("Clicking Ad on AlFatiha", ex);
                }
                Swipe();
                Thread.Sleep(3000);

                Swipe();
                Thread.Sleep(3000);

                Swipe();

                SurahBack.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Surah An Nisa Swipe", ex);
            }
        }
        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
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
        IWebElement ALQuranMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        IWebElement AlFatiha => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement PlaySurah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play");
        IWebElement SelectReciterDropDown => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/selectReader");
        IWebElement RepeatVerse => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/repeat"); IWebElement ViewList => driver.FindElementById("");
        IWebElement Continue => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
        IWebElement LanguageSave => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btnCacncel");
        IWebElement OnboardSkip => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_skip");
        IWebElement OnboardFinish => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_next_step");
        IWebElement StoragePermissionAllow => driver.FindElementById("com.android.permissioncontroller:id/permission_allow_button");
        IWebElement LocationPermissionAllow => driver.FindElementById("com.android.permissioncontroller:id/permission_allow_foreground_only_button");

        IWebElement SelectReciter => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/spinnerText\" and @text=\"Abdullah Basfar\"]");
        IWebElement NextAyah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/forward");
        IWebElement PrevAyah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/before");
        IWebElement BookMarkPage => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/bookmark");
        IWebElement GotoTranslationsection => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tafser");
        IWebElement AvailableforDownload => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/transtabTv");
        IWebElement DownloadTranslation => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivHeaderDownStatus\"])[2]");
        IWebElement DownloadedSection => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tfseerTabTv");

        IWebElement ViewTranslation => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Azerbaijani\"]");
        IWebElement TranslationPrevPage => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPrevious");
        IWebElement TranslationNextPage => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivNext");

        IWebElement SurahBack => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/back");

        IWebElement Surah2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Aal-E-Imran\"]");
        IWebElement SurahAnNisa => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat An-Nisa\"]");
    }
}
