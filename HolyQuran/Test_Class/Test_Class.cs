using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        AlQuran AlQuranSec;
        AlQuran HajjUmrah;
        AlQuran Azkar;

        //  [TestMethod]
        public void HolyQuran()
        {
            ExtentTest test = Extent.CreateTest("Report");
            AlQuranSec = new AlQuran(driver, test);
            //     AlQuranSec.QuranLaunch();
            AlQuranSec.PerformQuranOperations();
            //   AlQuranSec.PerformSwipeOperations();
            AlQuranSec.QiblaFinder();
            // AlQuranSec.MasjidFinder();
            AlQuranSec.DigitalTasbeeh();
            AlQuranSec.PrayerTimes();
            AlQuranSec.HijriCalendar();

        }
        [TestMethod]
        public void HajjandUmrahSection()
        {
            ExtentTest test = Extent.CreateTest("Report");
            HajjUmrah = new AlQuran(driver, test);
            HajjUmrah.HajjGuide();
            HajjUmrah.UmrahGuide();
            HajjUmrah.FamousPlacesofMakkah();
            HajjUmrah.FamousPlacesofMedina();
        }

        [TestMethod]
        public void AzkarSection()
        {
            ExtentTest test = Extent.CreateTest("Report");
            Azkar = new AlQuran(driver, test);
            Azkar.Azkar();
        }
    }
}
