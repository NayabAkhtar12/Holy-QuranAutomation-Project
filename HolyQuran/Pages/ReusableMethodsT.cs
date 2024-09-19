using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class ReusableMethodsT
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public ReusableMethodsT(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
        }
        private string CaptureScreenshot(string fileName)
        {
            try
            {
                Screenshot screenshot = driver.GetScreenshot();
                string filePath = Path.Combine("Screenshots", $"{fileName}.png");
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
                return filePath;
            }
            catch (Exception ex)
            {
                // Log the exception if screenshot capture fails
                Test.Log(Status.Warning, $"Screenshot capture failed: {ex.Message}");
                return null;
            }
        }
        public void HandleException(string actionName, Exception ex)
        {
            // Log the error message
            Test.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");

            // Capture the screenshot
            string screenshotPath = CaptureScreenshot(actionName.Replace(" ", "_"));

            if (screenshotPath != null)
            {
                // Log that a screenshot was taken and add it to the Extent Report
                Test.Log(Status.Info, "Screenshot captured for the failed step.");
                Test.AddScreenCaptureFromPath(screenshotPath, "Failure Screenshot");
            }
            else
            {
                // Log if the screenshot was not captured due to an error
                Test.Log(Status.Warning, "Screenshot could not be captured.");
            }

            // Optionally, re-throw the exception to fail the test
            throw ex;
        }

        public void HandleExceptiontt(string actionName, Exception ex)
        {
            // Log the error message
            Test.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");

            // Capture the screenshot
            string screenshotPath = CaptureScreenshot(actionName.Replace(" ", "_"));

            if (screenshotPath != null)
            {
                // Log that a screenshot was taken and add it to the Extent Report
                Test.Log(Status.Info, "Screenshot captured for the failed step.");
                Test.AddScreenCaptureFromPath(screenshotPath, "Failure Screenshot");
            }
            else
            {
                // Log if the screenshot was not captured due to an error
                Test.Log(Status.Warning, "Screenshot could not be captured.");
            }

            // Optionally, re-throw the exception to fail the test
            throw ex;
        }
        public void SplashHandling2ndsessiont()
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

            InterAdHandle();

        }

        //public void HandleException(string action, Exception ex)
        //{
        //    Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
        //    Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
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

        public void HandleCBanner(string context)
        {
            try
            {
                Thread.Sleep(2000); // Optional: Adjust or remove as needed
                adHelper.CBanner();
                // Thread.Sleep(2000); // Optional: Adjust or remove as needed
            }
            catch (Exception ex)
            {
                HandleException($"C Banner not Found on {context}", ex);
            }
        }

        public void InterAdHandle()
        {
            WebDriverWait shortWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            try
            {
                // Check for cross button first, if not present, check for close button
                if (IsCrossButtonPresent(shortWait))
                {
                    HandleAdCrossButton(shortWait);
                }
                else if (IsCloseButtonPresent(shortWait))
                {
                    HandleAdCloseButton(shortWait);
                }
                else
                {
                    Console.WriteLine("No Interstitial Ad found.");
                }
            }
            catch (Exception ex)
            {
                HandleException("Interstitial Ad Handling", ex);
            }
        }


        public bool IsCloseButtonPresent(WebDriverWait wait)
        {
            try
            {
                By adLocator = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ']");
                wait.Until(ExpectedConditions.ElementToBeClickable(adLocator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool IsCrossButtonPresent(WebDriverWait wait)
        {
            try
            {
                By adLocator = By.XPath("//android.widget.TextView[@content-desc='close' or @text='×'] | //android.widget.Button");
                wait.Until(ExpectedConditions.ElementToBeClickable(adLocator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }


        public void HandleAdCloseButton(WebDriverWait wait)
        {
            try
            {
                By closeButtonLocator = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ']");
                IWebElement closeButton = wait.Until(ExpectedConditions.ElementToBeClickable(closeButtonLocator));
                closeButton.Click();
                Console.WriteLine("Close button ad handled.");
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Close button not found.");
            }
        }

        public void HandleAdCrossButton(WebDriverWait wait)
        {
            try
            {
                By crossButtonLocator = By.XPath("//android.widget.Button");
                IWebElement crossButton = wait.Until(ExpectedConditions.ElementToBeClickable(crossButtonLocator));
                crossButton.Click();
                Console.WriteLine("Cross button ad handled.");
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Cross button not found.");
            }
        }

        //test
        public void HandleInterstitialAd()
        {
            WebDriverWait shortWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            try
            {
                // Attempt to find and click either a cross button or close button
                if (TryHandleAdButton(shortWait))
                {
                    Console.WriteLine("Interstitial ad handled.");
                }
                else
                {
                    Console.WriteLine("No Interstitial Ad found.");
                }
            }
            catch (Exception ex)
            {
                HandleException("Interstitial Ad Handling", ex);
            }
        }

        public bool TryHandleAdButton(WebDriverWait wait)
        {
            // Define XPath for 'close' button, handling different languages and cases
            By closeButtonLocator = By.XPath(
                "//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ']"
            );

            // Define XPath for 'cross' button, handling variations
            By crossButtonLocator = By.XPath(
                "//android.widget.Button[@content-desc='close'] | //android.widget.ImageButton[@content-desc='close'] | //android.widget.TextView[@text='×']"
            );

            try
            {
                // First try to find the 'close' button
                IWebElement closeButton = wait.Until(ExpectedConditions.ElementToBeClickable(closeButtonLocator));
                closeButton.Click();
                Console.WriteLine("Close button ad handled.");
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                // If 'close' button not found, try to find the 'cross' button
                try
                {
                    IWebElement crossButton = wait.Until(ExpectedConditions.ElementToBeClickable(crossButtonLocator));
                    crossButton.Click();
                    Console.WriteLine("Cross button ad handled.");
                    return true;
                }
                catch (WebDriverTimeoutException)
                {
                    // If neither is found, return false
                    return false;
                }
            }
        }
        /// <summary>
        /// //////
        /// </summary>
        IWebElement Continue => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
    }
}
