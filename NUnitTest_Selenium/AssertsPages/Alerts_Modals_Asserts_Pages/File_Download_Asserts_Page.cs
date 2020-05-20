using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnitTest_Selenium.Pages;
using NUnit.Framework;

namespace NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages
{
    public class File_Download_Asserts_Page:BasePage
    {
        private IWebElement textAriaFeedback => driver.FindElement(By.Id("textarea_feedback"));
        private IWebElement linkToDonwload
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#link-to-download[style='display: block;']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public File_Download_Asserts_Page(IWebDriver driver):base(driver)
        {

        }

        public void CountSimbols(string text)
        {
            int charNumb = 500 - text.Length;
            string expectedString =$"{charNumb} characters remaining";

            Assert.AreEqual(expectedString, textAriaFeedback.Text);
        }

        public void CheckLinkToDownload()
        {
            Assert.IsNotNull(linkToDonwload);
        }

        public void IsMoreWindowsOpen(int w)
        {
            Assert.AreEqual(w, driver.WindowHandles.Count);
        }

        public void IsWindowUrlOK(string url)
        {
            Assert.AreEqual(url, driver.Url);
        }
    }
}
