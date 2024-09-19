using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class AlQuran2ndSession
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ReusableMethods ReusableMethods;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public AlQuran2ndSession(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);

        }

        public void PerformQuranOperations()
        {

            //  Thread.Sleep(2000);
            //Main screen
            //  HandleCBanner("ALQuran Operations");
            try
            {
                // ReusableMethods.SplashHandling2ndsessiont();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("SplashHandling2ndsession", ex);
            }


            try
            {
                // ReusableMethods.ScrollToElementByText("AL-Quran");
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                ALQuranMenu.Click();
                ReusableMethods.InterAdHandle();
                Thread.Sleep(5000);
                //      HandleCBanner("Holy Quran Main screen C.Banner");
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking AlQuran and Ad", ex);
            }
            try
            {
                AlFatiha.Click();
                ReusableMethods.InterAdHandle();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking AlFatiha", ex);
            }
            try
            {
                SelectReciterDropDown.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking RecitersDropdown", ex);
            }

            try
            {
                SelectReciter.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking SelectReciter", ex);
            }

            try
            {
                PlaySurah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking PlaySurah", ex);
            }

            try
            {
                NextAyah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking NextAyah", ex);
            }

            try
            {
                PrevAyah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking PrevAyah", ex);
            }

            try
            {
                //PlaySurah.Click(); // Assuming PlaySurah needs to be clicked again after NextAyah and PrevAyah
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking PlaySurah again", ex);
            }

            try
            {
                BookMarkPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking BookMarkPage", ex);
            }

            try
            {
                GotoTranslationsection.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking GotoTranslationsection", ex);
            }

            //try
            //{
            //    DownloadTranslation.Click();
            //    Thread.Sleep(3000);
            //}
            //catch (Exception ex)
            //{
            //    ReusableMethods.HandleException("Clicking DownloadTranslation", ex);
            //}
            try
            {
                DownloadedSection.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking DownloadedSection", ex);
            }
            try
            {
                ViewTranslation.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking ViewTranslation", ex);
            }

            try
            {
                TranslationNextPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking TranslationNextPage", ex);
            }

            try
            {
                TranslationPrevPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking TranslationPrevPage", ex);
            }

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Navigating back", ex);
            }
            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Navigating back to main screen", ex);
            }

        }

        public void Bookmarks()
        {
            try
            {
                AlFatiha.Click();
                ReusableMethods.InterAdHandle();

                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking AlFatiha", ex);
            }


            try
            {
                IWebElement AddressItem = driver.FindElement(MobileBy.AndroidUIAutomator(
                "new UiScrollable(new UiSelector().scrollable(true))" +
                ".scrollIntoView(new UiSelector().text(\"Address*\"))"));
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Scroll Issue occured", ex);
            }


        }
        public void PerformSwipeOperations()
        {
            try
            {
                Thread.Sleep(2000);
                // HandleCBanner("Holy Quran Surah Aal e Imran");
                try
                {
                    Surah2.Click();
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Surah Aal E Imran", ex);
                }

                ReusableMethods.InterAdHandle();

                ReusableMethods.Swipe();
                Thread.Sleep(3000);

                ReusableMethods.Swipe();
                Thread.Sleep(3000);

                ReusableMethods.Swipe();
                try
                {
                    SurahBack.Click();
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Surah An Nisa to Home screen navigation", ex);
                }
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Surah Aal e Imran Swipe", ex);
            }

            try
            {
                SurahAnNisa.Click();
                ReusableMethods.InterAdHandle();

                ReusableMethods.Swipe();
                Thread.Sleep(3000);

                ReusableMethods.Swipe();
                Thread.Sleep(3000);

                ReusableMethods.Swipe();

                SurahBack.Click();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Surah An Nisa Swipe", ex);
            }
            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Surah An Nisa to Home screen navigation", ex);
            }
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
