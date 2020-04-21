using System;
using System.Collections.Generic;
using System.Text;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;


namespace NUnitTest_Selenium.Pages
{
    public class RadioButtonsPage : BasePage
    {
        //Radio Button Demo Elements
        private IWebElement topMaleRadioButton => driver.FindElement(By.CssSelector("input[value='Male']"));
        private IWebElement topFemaleRadioButton => driver.FindElement(By.CssSelector("input[value='Female']"));
        private IWebElement buttonGetCheckedValue => driver.FindElement(By.Id("buttoncheck"));

        //Group Radio Buttons Demo Elements
        private IWebElement downMaleRadioButton => driver.FindElement(By.CssSelector(".radio-inline > input[value='Male']"));
        private IWebElement downFemaleRadioButton => driver.FindElement(By.CssSelector(".radio-inline > input[value='Female']"));
        private IWebElement downFiveRadioButton => driver.FindElement(By.CssSelector(".radio-inline > input[value='0 - 5']"));
        private IWebElement downFiveteenRadioButton => driver.FindElement(By.CssSelector(".radio-inline > input[value='5 - 15']"));
        private IWebElement downFiftyRadioButton => driver.FindElement(By.CssSelector(".radio-inline > input[value='15 - 50']"));
        private IWebElement getGroupValuesButton => driver.FindElement(By.CssSelector("button[onclick='getValues();']"));

        public RadioButtonsPage(IWebDriver driver) : base(driver) { }

        public RadioButtonsPage TopMaleButtonClick()
        {
            topMaleRadioButton.Click();
            return this;
        }

        public RadioButtonsPage TopFemaleButtonClick()
        {
            topFemaleRadioButton.Click();
            return this;
        }

        public RadioButtonsPage GetCheckedValueClick()
        {
            buttonGetCheckedValue.Click();
            return this;
        }

        public RadioButtonsPage DownMaleButtonClick()
        {
            downMaleRadioButton.Click();
            return this;
        }

        public RadioButtonsPage DownFemaleButtonClick()
        {
            downFemaleRadioButton.Click();
            return this;
        }

        public RadioButtonsPage DownFiveButtonClick()
        {
            downFiveRadioButton.Click();
            return this;
        }

        public RadioButtonsPage DownFiveteenButtonClick()
        {
            downFiveteenRadioButton.Click();
            return this;
        }

        public RadioButtonsPage DownFiftyButtonClick()
        {
            downFiftyRadioButton.Click();
            return this;
        }

        public RadioButtonsPage GetGroupValues()
        {
            getGroupValuesButton.Click();
            return this;
        }
    }
}
