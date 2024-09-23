using AventStack.ExtentReports;
using HolyQuran.Core;
using HolyQuran.Pages;

namespace HolyQuran.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        QuranFirstSession QuranFirstSession;
        AlQuran2ndSession AlQuran2ndSession;
        Qibla_Finder QFinder;
        DigitalTasbeeh DTasbeeh;
        MasjidFinder MFinder;
        PrayerTimes PTimes;
        HijriCalender HijCal;

        HajjUmrahSection HajjUmrah;
        Azkar Azkar;
        Names99 Names;

        PremiumandMenu Premiumand;

        //     [TestMethod]
        public void HolyQuranStartUp()
        {
            ExtentTest test = Extent.CreateTest("HolyQuranStartUp Report");
            QuranFirstSession = new QuranFirstSession(driver, test);
            QuranFirstSession.QuranLaunch();
            QuranFirstSession.AlQuranDownload();
        }


        //    [TestMethod, Description("abc"), Order(2), TestCategory("Order")]
        [TestMethod, TestCategory("Order(1)")]
        //   [TestMethod, Owner(TC.Bobo), TestOrder(5)]
        public async Task GetUserByIdAsync()

        //   public void TC01()
        //   public void TC01_HolyQuran2ndSession()

        {
            System.Diagnostics.Trace.WriteLine("Test1");
            ExtentTest test = Extent.CreateTest("TC01_HolyQuran2ndSession Report");
            AlQuran2ndSession = new AlQuran2ndSession(driver, test);
            AlQuran2ndSession.PerformQuranOperations();
            AlQuran2ndSession.PerformSwipeOperations();
        }


        [TestMethod, TestCategory("Order")]
        //public void TC02_QiblaFinderTest()

        public void TC02()
        {
            ExtentTest test = Extent.CreateTest("QiblaFinderTest Report");
            QFinder = new Qibla_Finder(driver, test);
            QFinder.QiblaFinder();
        }

        [TestMethod, TestCategory("Order")]
        //public void TC03_DigitalTasbeehTest()
        public void TC03()
        {
            ExtentTest test = Extent.CreateTest("DigitalTasbeehTest Report");
            DTasbeeh = new DigitalTasbeeh(driver, test);
            DTasbeeh.DigitalTasbeehMethod();
        }


        [TestMethod, TestCategory("Order")]
        public void TC04_MasjidFinderTest()
        {
            ExtentTest test = Extent.CreateTest("MasjidFinderTest Report");
            MFinder = new MasjidFinder(driver, test);
            MFinder.MasjidFinderMethod();
        }


        [TestMethod, TestCategory("Order")]
        public void TC05_PrayerTimesTest()
        {
            ExtentTest test = Extent.CreateTest("PrayerTimesTest Report");
            PTimes = new PrayerTimes(driver, test);
            PTimes.PrayerTimesMethod();
        }

        [TestMethod, TestCategory("Order")]
        public void TC06_HijriCalenderTest()
        {
            ExtentTest test = Extent.CreateTest("HijriCalenderTest Report");
            HijCal = new HijriCalender(driver, test);
            HijCal.HijriCalendar();
        }



        [TestMethod, TestCategory("Order")]
        public void TC07_HajjandUmrahSection()
        {
            ExtentTest test = Extent.CreateTest("HajjandUmrahSection Report");
            HajjUmrah = new HajjUmrahSection(driver, test);
            HajjUmrah.HajjGuide();
            HajjUmrah.UmrahGuide();
        }

        [TestMethod, TestCategory("Order")]
        public void TC08_AzkarSection()
        {
            ExtentTest test = Extent.CreateTest("AzkarSection Report");
            Azkar = new Azkar(driver, test);
            Azkar.AzkarMethod();
        }

        [TestMethod, TestCategory("Order")]
        public void TC09_NamesTest()
        {
            ExtentTest test = Extent.CreateTest("99 Names Report");
            Names = new Names99(driver, test);
            Names.NamesOfAllah();
        }

        [TestMethod, TestCategory("Order")]
        public void TC10_PremiumandMenu()
        {
            ExtentTest test = Extent.CreateTest("PremiumandMenu Report");
            Premiumand = new PremiumandMenu(driver, test);
            Premiumand.PremiumandMenuMethod();
        }

    }
}
