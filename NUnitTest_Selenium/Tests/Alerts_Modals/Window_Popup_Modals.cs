using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages;
using NUnitTest_Selenium.Pages.Alerts_Modals_Pages;
using System.Collections.Generic;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Alerts_Modals
{
    public class Window_Popup_Modals : BaseTest
    {
        string testUrl;
        List<string> windowsUrlsList = new List<string>()
        {            
            "https://twitter.com/intent/follow?screen_name=seleniumeasy",
            "https://www.facebook.com/seleniumeasy",
            "https://plus.google.com/+Seleniumeasy"
        };
        private Window_Popup_Modals_Page windowPopupPage;
        private Window_Popup_Asserts_Page windowPopupAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            testUrl = baseUrl + "/window-popup-modal-demo.html";
            windowsUrlsList.Add(testUrl);
            driver.Navigate().GoToUrl(testUrl);
            windowPopupPage = new Window_Popup_Modals_Page(driver);
            windowPopupAssertsPage = new Window_Popup_Asserts_Page(driver);
        }

        /// <summary>
        /// Click blow button to open Twitter in a single window popup
        /// </summary>
        [Test]
        public void TwitterWindowPopupTest()
        {
            //Store the ID of the original window
            string originalWindowID = driver.CurrentWindowHandle;

            windowPopupPage.TwitterFollowButtonClick();

            windowPopupAssertsPage.IsMoreWindowsOpen(2);
            windowPopupAssertsPage.SecondWindowShow(originalWindowID, windowsUrlsList[0]);

            //Close the new window
            driver.Close();            

            //Switch back to the old window
            driver.SwitchTo().Window(originalWindowID);

            windowPopupAssertsPage.IsMoreWindowsOpen(1);
            windowPopupAssertsPage.IsWindowUrlOK(testUrl);
        }

        /// <summary>
        /// Click blow button to open Selenium Easy Facebook Page in a single window popup
        /// </summary>
        [Test]
        public void FacebookWindowPopupTest()
        {
            //Store the ID of the original window
            string originalWindowID = driver.CurrentWindowHandle;

            windowPopupPage.FacebookLikeButtonClick();

            windowPopupAssertsPage.IsMoreWindowsOpen(2);
            windowPopupAssertsPage.SecondWindowShow(originalWindowID, windowsUrlsList[1]);

            //Close the new window
            driver.Close();

            //Switch back to the old window
            driver.SwitchTo().Window(originalWindowID);

            windowPopupAssertsPage.IsMoreWindowsOpen(1);
            windowPopupAssertsPage.IsWindowUrlOK(testUrl);
        }

        /// <summary>
        /// Click Below button to open three window popups (Facebook, Twitter & Google Plus)
        /// </summary>
        [Test]
        public void MultipleWindowsTest()
        {
            List<string> windowsID = new List<string>();
            //Store the ID of the original window
            string originalWindowID = driver.CurrentWindowHandle;
            windowsID.Add(originalWindowID);

            windowPopupPage.FollowAllButtonClick();
            Thread.Sleep(1000);

            windowPopupAssertsPage.IsMoreWindowsOpen(4);

            windowPopupPage.SwitchToWindow(windowsUrlsList[0], originalWindowID);
            Thread.Sleep(1000);

            windowPopupAssertsPage.IsWindowUrlOK(windowsUrlsList[0]);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            driver.Close();

            driver.SwitchTo().Window(originalWindowID);
            Thread.Sleep(1000);
            windowPopupAssertsPage.IsMoreWindowsOpen(3);
            windowPopupAssertsPage.IsWindowUrlOK(testUrl);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
