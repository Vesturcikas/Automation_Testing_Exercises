using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages
{
    public class Window_Popup_Asserts_Page:BasePage
    {

        public Window_Popup_Asserts_Page(IWebDriver driver) : base(driver) { }

        public void SecondWindowShow(string originalWindow, string newUrl)
        {
            //Loop through until we find a new window handle
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }

            Assert.AreEqual(newUrl, driver.Url);           
        }

        public void IsWindowUrlOK(string url)
        {
            Assert.AreEqual(url, driver.Url);
        }

        public void IsMoreWindowsOpen(int w)
        {
            Assert.AreEqual(w, driver.WindowHandles.Count);
        }
    }
}
