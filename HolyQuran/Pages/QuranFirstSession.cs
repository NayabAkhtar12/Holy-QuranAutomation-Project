using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class QuranFirstSession
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        ReusableMethods ReusableMethods;

        //Constructor
        public QuranFirstSession(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);

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
                ReusableMethods.HandleException("Clicking Continue", ex);
            }

            try
            {
                ReusableMethods.InterAdHandle();
                //2nd splash
                Thread.Sleep(3000);

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("LanguageSave Inter Ad", ex);
            }
            Thread.Sleep(3000);

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(LanguageSave)).Click();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking LanguageSave", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(OnboardSkip)).Click();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking OnboardSkip", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(OnboardFinish)).Click();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking OnboardFinish", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(StoragePermissionAllow)).Click();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking StoragePermissionAllow", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(LocationPermissionAllow)).Click();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking LocationPermissionAllow", ex);
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
                ReusableMethods.HandleException("Clicking Quran Menu", ex);
            }




            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking Back button Quran", ex);
            }

        }
        public void PerformQuranOperations()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                ALQuranMenu.Click();
                ReusableMethods.InterAdHandle();
                Thread.Sleep(3000);

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking AlQuran and Ad", ex);
            }
            try
            {
                AlFatiha.Click();
                Thread.Sleep(3000);
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
                PlaySurah.Click(); // Assuming PlaySurah needs to be clicked again after NextAyah and PrevAyah
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

            try
            {
                DownloadTranslation.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Clicking DownloadTranslation", ex);
            }
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
                ReusableMethods.HandleException("Navigating back", ex);
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

                Surah2.Click();
                ReusableMethods.InterAdHandle();

                ReusableMethods.Swipe();
                Thread.Sleep(3000);

                ReusableMethods.Swipe();
                Thread.Sleep(3000);

                ReusableMethods.Swipe();

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
                ReusableMethods.HandleException("Surah An Nisa Swipe", ex);
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
