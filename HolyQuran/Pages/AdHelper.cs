using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
namespace Live_Earth_Map.Pages
{
    public class AdHelper
    {
        private readonly AppiumDriver<AndroidElement> driver;
        private readonly WebDriverWait wait;

        public AdHelper(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void HandleAd()
        {
            try
            {
                // Wait for the ad element to be present
                By adLocator = By.XPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView");
                wait.Until(ExpectedConditions.ElementIsVisible(adLocator));

                // Interact with the ad - click on the close button, assuming it has one
                By closeAdLocator = By.XPath("//android.widget.RelativeLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.TextView");
                IWebElement closeButton = wait.Until(ExpectedConditions.ElementToBeClickable(closeAdLocator));
                closeButton.Click();


                // Optionally, wait for the ad to close completely
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(adLocator));

                // Optionally, add a short sleep to ensure the ad is fully closed
                System.Threading.Thread.Sleep(2000); // Adjust as needed

                // Continue with the rest of your operations after ad handling
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Ad element not found or ad already closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error handling ad: {ex.Message}");
            }
        }
    }

}
