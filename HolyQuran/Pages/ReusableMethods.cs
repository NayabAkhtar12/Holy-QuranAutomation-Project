using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class ReusableMethods
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public ReusableMethods(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
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

        //public void HandleException1(string action, Exception ex)
        //{
        //    Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
        //    Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        //}


        public void HandleExceptione(string actionName, Exception ex)
        {
            // Log the error message
            Test.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");

            // Capture a screenshot
            Screenshot screenshot = driver.GetScreenshot();
            string filePath = @"D:\Reports\SS\screenshot.png";
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
            Console.WriteLine($"Screenshot saved to: {filePath}");
            Test.AddScreenCaptureFromPath(filePath);
        }

        public void HandleException(string actionName, Exception ex)
        {
            // Log the error message
            Test.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");

            try
            {
                // Capture the screenshot
                Screenshot screenshot = driver.GetScreenshot();
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = @$"D:\Reports\screenshot_{timestamp}.png";

                // Save screenshot as a PNG file
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
                Console.WriteLine($"Screenshot saved to: {filePath}");

                // Attach the screenshot to the report
                Test.AddScreenCaptureFromPath(filePath);
            }
            catch (Exception screenshotException)
            {
                // Log failure to capture/attach screenshot
                Test.Log(Status.Warning, "Failed to capture screenshot: " + screenshotException.Message);
            }


        }




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

        public void InterAdHandleBackup()
        {
            try
            {
                if (adHelper.IsCrossButtonPresent())
                {
                    adHelper.HandleAdCrossButton();
                }

                else if (adHelper.IsCloseButtonPresent())
                    adHelper.HandleAdCloseButton();
                else
                    Console.WriteLine("No Interstial  Ad found");
            }
            catch (Exception ex)
            {
                HandleException("99 names  inter Ad", ex);
            }
        }
        //New method for live ads
        public void InterAdHandle()
        {
            Thread.Sleep(20000);
            try
            {
                By handleAdButton = By.XPath(
            "//android.widget.Button | " +
            "//android.widget.ImageView[@content-desc='Ad closed'] | " +
            "//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ']" +
            "//android.view.View[@resource-id=\"mys-content\"]/android.view.View[2]/android.widget.TextView" +
            "//android.widget.TextView[@text=\"CLOSE\"]"
            );

                // By closeButton = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
                // By crossButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed']");
                //    By handleAdButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed'] | //android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");

                IWebElement adButton = null;

                // Check if any of the locators are present
                if (IsElementPresent(handleAdButton))
                {
                    adButton = driver.FindElement(handleAdButton);
                    if (adButton != null)
                    {
                        adButton.Click();
                    }
                    else
                    {
                        Console.WriteLine("No Interstitial Ad found");
                    }
                }
                else
                {
                    Console.WriteLine("No ad close button found");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No ad close button found");
            }
            catch (Exception ex)
            {
                HandleException("inter Ad", ex);
            }
        }

        private bool IsElementPresent(By locator)
        {
            try
            {
                return driver.FindElements(locator).Count > 0;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void LogTestFailure(Exception ex)
        {
            // Log the failure using Extent Reports
            Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            // Optionally log the stack trace for more details
            Test.Log(Status.Fail, $"Stack Trace: {ex.StackTrace}");

            // You can also add a screenshot or other debug info if needed
            // For example: AttachScreenshot();
        }


        IWebElement Continue => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
    }
}
