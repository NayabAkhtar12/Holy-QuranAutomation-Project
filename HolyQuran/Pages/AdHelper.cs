using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    public class AdHelper
    {
        private readonly AppiumDriver<AndroidElement> driver;
        private readonly WebDriverWait wait;

        public AdHelper(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
        }

        public void HandleAd()
        {
            bool isCrossButtonAd = false;

            try
            {
                // Try to find the cross button
                // By crossButtonLocator = By.XPath("//android.widget.TextView[@content-desc='close' or @text='×']");
                By mergedLocator = By.XPath("//android.widget.TextView[(@content-desc='close' or @text='×')] | //android.widget.Button");

                IWebElement crossButton = wait.Until(ExpectedConditions.ElementToBeClickable(mergedLocator));
                crossButton.Click();
                isCrossButtonAd = true;
                Console.WriteLine("Cross button ad handled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cross button not found.", ex);
                isCrossButtonAd = false;
            }

            // Handle timer ad if it's not a cross button ad
            if (!isCrossButtonAd)
            {
                try
                {
                    // Assume a 7-second timer and wait for it to finish
                    Thread.Sleep(20000); // Adjust as needed
                                         // Locator for the close button (after timer ends)
                    By closeButtonLocator = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
                    IWebElement closeButton = wait.Until(ExpectedConditions.ElementToBeClickable(closeButtonLocator));
                    closeButton.Click();
                    Console.WriteLine("Timer ad handled.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Timer or close button not found.");
                }
            }

            // Optionally, add a short sleep to ensure the ad is fully closed
            System.Threading.Thread.Sleep(2000); // Adjust as needed

            // Continue with the rest of your operations after ad handling
        }

        public bool IsAdPresent()
        {
            try
            {
                // Check for any known ad element by their text or other attributes
                By adLocator = By.XPath("//android.widget.TextView[@text=\"Test Ad\"]");
                driver.FindElement(adLocator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool IsCrossButtonPresent()
        {
            try
            {
                // Check for any known ad element by their text or other attributes
                By adLocator = By.XPath("//android.widget.TextView[(@content-desc='close' or @text='×')] | //android.widget.Button");
                driver.FindElement(adLocator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void HandleCollapsibleBanner()
        {
            try
            {
                By CBannerLocator = By.XPath("");
                IWebElement CBannerHide = wait.Until(ExpectedConditions.ElementToBeClickable(CBannerLocator));
                CBannerHide.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("CBanner not found.");
            }

        }
    }
}
