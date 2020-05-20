using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.Pages.Alerts_Modals_Pages
{
    public class File_Download_Page : BasePage
    {
        private IWebElement textBox => driver.FindElement(By.Id("textbox"));
        private IWebElement creatButton => driver.FindElement(By.Id("create"));

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

        public File_Download_Page(IWebDriver driver):base(driver) { }
        
        public File_Download_Page TextInput(string inputText)
        {
            textBox.SendKeys(inputText);
            return this;
        }

        public File_Download_Page CreatButtonClick()
        {
            creatButton.Click();
            return this;
        }

        public File_Download_Page DownloadClick()
        {
            linkToDonwload.Click();
            return this;
        }

        public void SwitchToWindow(string originWindow)
        {
            foreach (var item in driver.WindowHandles)
            {
                if (item != originWindow)
                {
                    driver.SwitchTo().Window(item);
                    break;
                    
                }
            }
        }
    }
}
