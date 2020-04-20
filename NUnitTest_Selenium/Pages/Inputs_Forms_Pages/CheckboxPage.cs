using OpenQA.Selenium;
using System.Collections.Generic;


namespace NUnitTest_Selenium.Pages
{
    public class CheckboxPage : BasePage
    {
        private IWebElement checkboxSingle => driver.FindElement(By.Id("isAgeSelected"));
        private IList<IWebElement> checkboxElementList => driver.FindElements(By.CssSelector("input.cb1-element"));        
        private IWebElement buttonCheck => driver.FindElement(By.Id("check1"));

        public CheckboxPage (IWebDriver driver) : base(driver) { }

        public CheckboxPage SingleCheckboxCheck()
        {
            checkboxSingle.Click();
            return this;
        }

        public CheckboxPage CheckAll()
        {
            buttonCheck.Click();
            return this;
        }

        public CheckboxPage CheckOneCheckbox(int i)
        {
            checkboxElementList[i].Click();
            return this;
        }
    }
}
