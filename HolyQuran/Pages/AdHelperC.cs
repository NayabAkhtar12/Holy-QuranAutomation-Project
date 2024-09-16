using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    public class AdHelperC
    {
        private readonly AppiumDriver<AndroidElement> driver;
        private readonly WebDriverWait wait;
        TouchAction touchAction;

        public AdHelperC(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
            this.touchAction = new TouchAction(driver);

        }

        public void HandleAdCrossButton()
        {
            try
            {
                // Try to find the cross button
                // By crossButtonLocator = By.XPath("//android.widget.TextView[@content-desc='close' or @text='×']");
                By mergedLocator = By.XPath("//android.widget.Button");

                IWebElement crossButton = wait.Until(ExpectedConditions.ElementToBeClickable(mergedLocator));
                crossButton.Click();
                Console.WriteLine("Cross button ad handled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cross button not found.", ex);
            }
        }


        public void HandleAdCloseButton()
        {
            try
            {
                // Assume a 7-second timer and wait for it to finish
                //Thread.Sleep(20000); // Adjust as needed
                // Locator for the close button (after timer ends)
                By closeButtonLocator = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
                IWebElement closeButton = wait.Until(ExpectedConditions.ElementToBeClickable(closeButtonLocator));
                closeButton.Click();
                Console.WriteLine("Timer ad handled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Timer or close button not found.", ex);
            }
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

        public bool IsCloseButtonPresent()
        {
            try
            {
                // Check for any known ad element by their text or other attributes
                By adLocator = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
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
                By adLocator1 = By.XPath("//android.widget.TextView[(@content-desc='close' or @text='×')] | //android.widget.Button");
                By adLocator = By.XPath("//android.widget.Button");

                //  IWebElement adLocator1 = wait.Until(ExpectedConditions.ElementToBeClickable(adLocator));
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
                By CBannerLocator1 = By.XPath("//android.widget.ImageView[@content-desc='close' or @content-desc='collapse' or @content-desc='close_button' or @content-desc='minimize']");
                By CBannerLocator = By.XPath("//android.widget.ImageView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh']");
                //1:15 seconds autoclose C.Banner

                IWebElement CBannerHide = wait.Until(ExpectedConditions.ElementToBeClickable(CBannerLocator1));
                CBannerHide.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("CBanner not found.");
            }

        }

        public void CBanner()
        {
            //**************Code to close c banner ***********
            try
            {

                var x = 667;
                var y = 850;

                touchAction.Tap(x, y).Perform();
                Console.WriteLine("Tap performed successfully at coordinates: (" + x + ", " + y + ")");
            }
            catch (NoSuchElementException)
            {
            }
        }

    }
}
