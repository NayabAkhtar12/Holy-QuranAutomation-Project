using AventStack.ExtentReports;
using HolyQuran.Core;
using HolyQuran.Pages;

namespace HolyQuran.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        AlQuran AlQuranSec;
        Qibla_Finder QFinder;
        DigitalTasbeeh DTasbeeh;
        MasjidFinder MFinder;
        PrayerTimes PTimes;
        HijriCalender HijCal;

        HajjUmrahSection HajjUmrah;
        Azkar Azkar;
        Names99 Names;

        //  [TestMethod]
        //public void HolyQuranIn()
        //{
        //    ExtentTest test = Extent.CreateTest("Report");
        //    AlQuranSec = new AlQuran(driver, test);
        //    AlQuranSec.DigitalTasbeeh();
        //    AlQuranSec.PrayerTimes();
        //    AlQuranSec.QiblaFinder();
        //}

        //  [TestMethod]
        public void HolyQuran()
        {
            ExtentTest test = Extent.CreateTest("Report");
            AlQuranSec = new AlQuran(driver, test);
            AlQuranSec.QuranLaunch();
            AlQuranSec.AlQuranDownload();
            AlQuranSec.PerformQuranOperations();
            AlQuranSec.PerformSwipeOperations();
        }


        [TestMethod]
        public void QiblaFinderTest()
        {
            ExtentTest test = Extent.CreateTest("Report");
            QFinder = new Qibla_Finder(driver, test);
            QFinder.QiblaFinder();
        }

        [TestMethod]
        public void DigitalTasbeehTest()
        {
            ExtentTest test = Extent.CreateTest("Report");
            DTasbeeh = new DigitalTasbeeh(driver, test);
            DTasbeeh.DigitalTasbeehMethod();
        }


        [TestMethod]
        public void MasjidFinderTest()
        {
            ExtentTest test = Extent.CreateTest("Report");
            MFinder = new MasjidFinder(driver, test);
            MFinder.MasjidFinderMethod();
        }


        [TestMethod]
        public void PrayerTimesTest()
        {
            ExtentTest test = Extent.CreateTest("Report");
            PTimes = new PrayerTimes(driver, test);
            PTimes.PrayerTimesMethod();
        }

        [TestMethod]
        public void HijriCalenderTest()
        {
            ExtentTest test = Extent.CreateTest("Report");
            HijCal = new HijriCalender(driver, test);
            HijCal.HijriCalendar();
        }



        [TestMethod]
        public void HajjandUmrahSection()
        {
            ExtentTest test = Extent.CreateTest("Report");
            HajjUmrah = new HajjUmrahSection(driver, test);
            HajjUmrah.HajjGuide();
            HajjUmrah.UmrahGuide();
        }

        [TestMethod]
        public void AzkarSection()
        {
            ExtentTest test = Extent.CreateTest("Report");
            Azkar = new Azkar(driver, test);
            Azkar.AzkarMethod();
        }

        [TestMethod]
        public void NamesTest()
        {
            ExtentTest test = Extent.CreateTest("Report");
            Names = new Names99(driver, test);
            Names.NamesOfAllah();
        }


    }
}
