using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;

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

        public void PerformQuranOperations()
        {

            try
            {
                ALQuranMenu.Click();
                //   ReadQuran.Click();
                Thread.Sleep(3000);

                AlFatiha.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                SelectReciterDropDown.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                SelectReciter.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                PlaySurah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                NextAyah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                PrevAyah.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                PlaySurah.Click(); // Assuming PlaySurah needs to be clicked again after NextAyah and PrevAyah
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                BookMarkPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                GotoTranslationsection.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                DownloadTranslation.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                DownloadedSection.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                ViewTranslation.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                TranslationNextPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                TranslationPrevPage.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }

            try
            {
                driver.Navigate().Back();
                driver.Navigate().Back();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
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
                HandleException("Surah2", ex);
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
                ViewList.Click();
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
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
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
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
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

        public void HajjAndUmrah()
        {
            try
            {
                hajjUmrahMenu.Click();
                Thread.Sleep(3000); // Assuming a delay after click for the view to load
                                    // Perform other operations related to Hajj and Umrah Section here
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }


        public void Azkar()
        {
            try
            {
                azkarMenu.Click();
                Thread.Sleep(3000); // Assuming a delay after click for the view to load
                                    // Perform other operations related to Azkar here
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
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
                Console.WriteLine("Exception occurred: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
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
        public void Swipe1()
        {
            try
            {
                // Get the screen dimensions
                int screenWidth = driver.Manage().Window.Size.Width;
                int screenHeight = driver.Manage().Window.Size.Height;

                // Calculate start and end coordinates for swipe
                int startX = (int)(screenWidth * 0.8); // 80% from left
                int startY = (int)(screenHeight * 0.5); // Middle of the screen
                int endX = (int)(screenWidth * 0.2); // 20% from left
                int endY = startY; // Same Y coordinate to maintain horizontal swipe

                // Perform swipe action
                TouchAction act = new TouchAction(driver);
                act.LongPress(startX, startY)
                   .Wait(5000)
                   .MoveTo(endX, endY)
                   .Release()
                   .Perform();
            }
            catch (Exception ex)
            {
                HandleException("Swipe", ex);
            }
        }
        IWebElement ALQuranMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran");
        IWebElement AlFatiha => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Al-Fatiha\"]");
        IWebElement PlaySurah => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play");
        IWebElement SelectReciterDropDown => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/selectReader");
        IWebElement RepeatVerse => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/repeat");

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
        IWebElement ViewList => driver.FindElementById("");

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
        IWebElement HajjGuide => driver.FindElementById("");
        IWebElement HajjGuideDay1 => driver.FindElementById("");
        IWebElement HajjGuideDay => driver.FindElementById("");
        IWebElement UmrahGuide => driver.FindElementById("");
        IWebElement UmrahIhram => driver.FindElementById("");
        IWebElement UmrahSAEE => driver.FindElementById("");
        IWebElement FamousPlacesofMakkah => driver.FindElementById("");
        IWebElement FamousPlacesofMakkahKaaba => driver.FindElementById("");
        IWebElement FamousPlacesofMakkahMina => driver.FindElementById("");

        IWebElement FamousPlacesofMedinah => driver.FindElementById("");
        IWebElement FamousPlacesofMedinah_AlNabwi => driver.FindElementById("");
        IWebElement FamousPlacesofMedinah_UhudMountain => driver.FindElementById("");
        IWebElement HandUQibla => driver.FindElementById("");

        IWebElement azkarMenu => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivazkar");

        IWebElement Namesnine => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi");
        IWebElement ReadQuran => driver.FindElementById("");
        IWebElement SurahBack => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/back");

        IWebElement Surah2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5\" and @text=\"Surat Aal-E-Imran\"]");
        IWebElement CloseAd => driver.FindElementByXPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView");


    }
}
