using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        AlQuran AlQuranSec;
        [TestMethod]
        public void HolyQuran()
        {
            ExtentTest test = Extent.CreateTest("Report");
            AlQuranSec = new AlQuran(driver, test);
            AlQuranSec.PerformQuranOperations();
            AlQuranSec.PerformSwipeOperations();
            AlQuranSec.QiblaFinder();
            // AlQuranSec.MasjidFinder();
            AlQuranSec.DigitalTasbeeh();
            AlQuranSec.PrayerTimes();
            AlQuranSec.HijriCalendar();

        }
        //[TestMethod]
        //public void QiblaFinder()
        //{
        //    ExtentTest test = Extent.CreateTest("Report");
        //    AlQuranSec = new AlQuran(driver, test);
        //    AlQuranSec.PerformQuranOperations();
        //    AlQuranSec.QiblaFinder();
        //}
    }
}
