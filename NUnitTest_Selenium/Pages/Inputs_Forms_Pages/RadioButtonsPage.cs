using System;
using System.Collections.Generic;
using System.Text;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;


namespace NUnitTest_Selenium.Pages
{
    public class RadioButtonsPage :BasePage
    {
        private IWebElement topMaleRadioButton => driver.FindElement(By.CssSelector("input[value='Male']"));
        private IWebElement topFemaleRadioButton => driver.FindElement(By.CssSelector("input[value='Female']"));
        private IWebElement buttonGetValue => driver.FindElement(By.Id("buttoncheck"));

        public RadioButtonsPage(IWebDriver driver) : base(driver) { }

        public RadioButtonsPage TopMaleButtonClick()
        {

            return this;
        }
    }
}
