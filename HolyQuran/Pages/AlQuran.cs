using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace Live_Earth_Map.Pages
{
    class AlQuran
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();

        //Constructor
        public AlQuran(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void AlQuranModule()
        {
            ExtentTest test = Extent.CreateTest("Al Quran Report 1");
            try
            {
                // ALQuranMenu.Click();
                AlFatiha.Click();
                Thread.Sleep(3000);
                SelectReciterDropDown.Click();
                Thread.Sleep(3000);
                SelectReciter.Click();
                Thread.Sleep(3000);
                PlaySurah.Click();
                Thread.Sleep(3000);
                NextAyah.Click();
                Thread.Sleep(3000);
                PrevAyah.Click();
                Thread.Sleep(3000);
                PlaySurah.Click();

                BookMarkPage.Click();
                Thread.Sleep(3000);
                GotoTranslationsection.Click();
                Thread.Sleep(3000);
                ViewTranslation.Click();
                Thread.Sleep(3000);
                TranslationNextPage.Click();
                Thread.Sleep(3000);
                TranslationPrevPage.Click();
                driver.Navigate().Back();
                Swipe();
                Swipe();
                Swipe();
                Swipe();
                Swipe();
                //Thread.Sleep(3000);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
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
        public void PerformQuranOperations()
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                //   ALQuranMenu.Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(ReadQuran)).Click();
                Thread.Sleep(3000);

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

        public void PerformSwipeOperations()
        {
            try
            {
                Surah2.Click();
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
                HandleException("Surah2 Swipe", ex);
            }
        }
        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }

        public void QiblaFinder()
        {
            try
            {
                qiblaMenu.Click();
                Thread.Sleep(1000);
                ThemesQibla.Click();
                Theme2.Click();
                Thread.Sleep(1500);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Qibla Finder", ex);
            }
        }

        public void MasjidFinder()
        {
            try
            {
                masjidFinderMenu.Click();
                Thread.Sleep(3000);
                //  ViewList.Click();
                driver.Navigate().Back();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Masjid Finder", ex);

            }
        }

        public void DigitalTasbeeh()
        {
            try
            {
                digitalTasbeehMenu.Click();
                Thread.Sleep(3000);
                EditZikrForCount.Click();
                SelectZikrForCount.Click();
                CountPlus.Click();
                CountPlus.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Digital Tasbeeh", ex);
            }
        }

        public void PrayerTimes()
        {
            try
            {
                prayerTimesMenu.Click();
                Thread.Sleep(3000);
                PrayerTimeNotification.Click();
                PrayerTimeNotification.Click();
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                HandleException("Prayer Times", ex);
            }
        }

        public void HijriCalendar()
        {
            try
            {
                hijriCalendarMenu.Click();
                Thread.Sleep(3000);
                NextMonth.Click();
                PrevMonth.Click();
                Date.Click();
                NextMonth.Click();
                Date.Click();
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Calender", ex);

            }
        }

        public void HajjGuide()
        {
            //try
            //{
            //    //    hajjUmrahMenu.Click();
            //    Thread.Sleep(3000); // Assuming a delay after click for the view to load
            //}
            //catch (Exception ex)
            //{
            //    HandleException("Hajj and Umrah", ex);
            //}

            try
            {
                HajjGuideMenu.Click();
                HajjGuideDay1.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 1", ex);
            }

            try
            {
                HajjGuideDay2.Click();
                Thread.Sleep(3000); // Assuming a delay after click for the view to load
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 2", ex);
            }

            try
            {
                HajjGuideDay3.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();


            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 3", ex);
            }

            try
            {
                HajjGuideDay4.Click();
                Thread.Sleep(3000); // Assuming a delay after click for the view to load
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Hajj Day 4", ex);
            }

            try
            {
                HajjGuideDay5.Click();
                Thread.Sleep(3000); // Assuming a delay after click for the view to load
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
                wait.Until(ExpectedConditions.ElementToBeClickable(UmrahIhram)).Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Umrah Ihram", ex);
            }
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(UmrahTawaf)).Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Umrah Tawaf", ex);
            }
            try
            {
                UmrahSAEE.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Umrah Sa'ee", ex);
            }
            try
            {
                UmrahShaving.Click();
                Thread.Sleep(3000);
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
                HandleException("Kaaba/Mina Location ", ex);
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
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Medina Places", ex);
            }
        }
        public void Azkar()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                azkarMenu.Click();
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
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(Azkar_DuaSelection2)).Click();
                Thread.Sleep(3000);
            }

            catch (Exception ex)
            {
                HandleException("Dua 2", ex);
            }
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(AddtoBookmark)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking AddtoBookmark", ex);
            }

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Navigating back after adding to bookmark", ex);
            }

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
            }
            catch (Exception ex)
            {
                HandleException("Clicking ViewBookmark", ex);
            }

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(AddtoBookmark)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking AddtoBookmark again", ex);
            }

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Navigating back after second AddtoBookmark click", ex);
            }

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Navigating back again", ex);
            }

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Navigating back final time", ex);
            }
        }

        public void NamesOfAllah()
        {
            try
            {
                Namesnine.Click();
                Thread.Sleep(3000); // Assuming a delay after click for the view to load
                                    // Perform other operations related to 99 Names of Allah here
            }
            catch (Exception ex)
            {
                HandleException("99 Names", ex);
            }
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
        IWebElement ALQuranMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        IWebElement AlFatiha => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement PlaySurah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play");
        IWebElement SelectReciterDropDown => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/selectReader");
        IWebElement RepeatVerse => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/repeat"); IWebElement ViewList => driver.FindElementById("");
        IWebElement Continue => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
        IWebElement LanguageSave => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btnCacncel");
        IWebElement OnboardSkip => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_skip");
        IWebElement OnboardFinish => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_next_step");
        IWebElement StoragePermissionAllow => driver.FindElementById("com.android.packageinstaller:id/permission_allow_button");
        IWebElement LocationPermissionAllow => driver.FindElementById("com.android.packageinstaller:id/permission_allow_button");

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
        IWebElement qiblaMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");
        IWebElement ThemesQibla => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement Theme2 => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla5");

        IWebElement masjidFinderMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid");
        IWebElement ViewList1 => driver.FindElementById("");

        IWebElement digitalTasbeehMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivtasbeeh");
        IWebElement EditZikrForCount => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");
        IWebElement SelectZikrForCount => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvZikar\" and @text=\"بِسْمِ اللهِ الرَّحْمٰنِ الرَّحِيْمِ\"]");
        IWebElement CountPlus => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtncount");
        IWebElement TasbeehReset => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtnreset");
        IWebElement TasbeehResetYes => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvYes");
        IWebElement TasbeehResetNo => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvno");


        IWebElement prayerTimesMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivprayers");
        IWebElement PrayerTimeNotification => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ib_notification\"])[3]");

        IWebElement hijriCalendarMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivcalendar");
        IWebElement PrevMonth => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month");
        IWebElement NextMonth => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month");
        IWebElement Date => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/gregorian_calendar_day\" and @text=\"14\"]");


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

        IWebElement azkarMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivazkar");
        IWebElement Azkar_DuaSelection1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Upon waking up\"]");
        IWebElement Azkar_DuaSelection2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName\" and @text=\"Before Undressing\"]");
        IWebElement AddtoBookmark => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/button_star");
        IWebElement ViewBookmark => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/txtDuaName");
        IWebElement BooksMarkAddedSec => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/action_bookmarks");

        IWebElement Namesnine => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        IWebElement ReadQuran => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/button");
        IWebElement SurahBack => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/back");

        IWebElement Surah2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Aal-E-Imran\"]");
        IWebElement CloseAd => driver.FindElementByXPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView");


    }
}
