using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Selenium.Pages.Inputs_Forms_Pages
{
    public class SelectDropDownPage : BasePage
    {
        private IWebElement selectList => driver.FindElement(By.Id("select-demo"));
        private IWebElement multiSelectList => driver.FindElement(By.Id("multi-select"));
        private IWebElement buttonFirst => driver.FindElement(By.Id("printMe"));
        private IWebElement buttonAll => driver.FindElement(By.Id("printAll"));


        public SelectDropDownPage(IWebDriver driver) : base(driver) { }
        
        public SelectDropDownPage SelectListCklick()
        {
            selectList.Click();
            return this;
        }

        public SelectDropDownPage SelectListSelectElement(string selectText)
        {
            new SelectElement(selectList).SelectByText(selectText);
            return this;
        }

        public SelectDropDownPage MultiSelectListSelectElement(string selectText)
        {
            new SelectElement(multiSelectList).SelectByText(selectText);
            return this;
        }

        public SelectDropDownPage ButtonFirstClick()
        {
            buttonFirst.Click();
            return this;
        }

        public SelectDropDownPage ButtonAllClick()
        {
            buttonAll.Click();
            return this;
        }

        public SelectDropDownPage MultiSelect()
        {
            Actions act = new Actions(driver);
            act.KeyDown(Keys.Control);
            act.MoveToElement(multiSelectList.FindElement(By.CssSelector("[value='Florida']"))).Click();
            act.MoveToElement(multiSelectList.FindElement(By.CssSelector("[value='New York']"))).Click();
            act.KeyUp(Keys.Control);
            act.Build().Perform();           

            return this;
        }
    }
}
