using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;


namespace NUnitTest_Selenium.Pages.Inputs_Forms_Pages
{
    public class JQuery_Select_Page :BasePage
    {
        private IWebElement singleDropDownSearchBox => driver
            .FindElement(By.CssSelector("span[aria-labelledby='select2-country-container']"));
        private IWebElement singleDropDownList
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".select2-dropdown--below"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement countryList
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#select2-country-results[aria-hidden='false']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        private IWebElement multipleSelectBox => driver
            .FindElement(By.CssSelector(".select2-selection--multiple"));
        private IWebElement disabledValuesDropDownBox => driver
            .FindElement(By.CssSelector("span[aria-labelledby='select2-1rrx-container']"));

        public JQuery_Select_Page(IWebDriver driver) : base(driver) { }

        public JQuery_Select_Page CountrySelectClick()
        {
            singleDropDownSearchBox.Click();
            return this;
        }

        public JQuery_Select_Page SelectCountry(string countryName)
        {            
            ReadOnlyCollection<IWebElement> list = countryList.FindElements(By.CssSelector("li"));
            foreach (var item in list)
            {
                if (item.Text == countryName)
                {
                    item.Click();
                    break;
                }
            }
            return this;
        }

        public JQuery_Select_Page CountrySearchInput(string searchText)
        {
            IWebElement searchInput = singleDropDownList.FindElement(By.CssSelector("input[type='search']"));
            searchInput.Clear();
            searchInput.SendKeys(searchText);
            return this;
        }

        public JQuery_Select_Page MultiSelectClick()
        {
            multipleSelectBox.Click();
            return this;
        }
    }
}
