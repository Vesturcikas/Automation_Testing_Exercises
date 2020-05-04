using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.Pages.Alerts_Modals_Pages
{
    public class Javascript_Alerts_Page : BasePage
    {
        IWebElement jsAlertBoxButton => driver.FindElement(By.CssSelector("button[onclick='myAlertFunction()']"));
        IWebElement jsConfirmBoxButton => driver.FindElement(By.CssSelector("button[onclick='myConfirmFunction()']"));
        IWebElement jsPromptBoxButton => driver.FindElement(By.CssSelector("button[onclick='myPromptFunction()']"));

        public Javascript_Alerts_Page(IWebDriver driver) : base(driver) { }

        public Javascript_Alerts_Page AlertBoxButtonClick()
        {
            jsAlertBoxButton.Click();
            return this;
        }

        public Javascript_Alerts_Page ConfirmBoxButtonClick()
        {
            jsConfirmBoxButton.Click();
            return this;
        }        

        public Javascript_Alerts_Page PromptBoxButtonClick()
        {
            jsPromptBoxButton.Click();
            return this;
        }
       
    }
}
