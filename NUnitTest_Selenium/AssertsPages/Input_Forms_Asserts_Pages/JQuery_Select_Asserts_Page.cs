using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages
{
    public class JQuery_Select_Asserts_Page : BasePage
    {
        private List<string> originalCountryList = new List<string> { "", "Australia", "Bangladesh", "Denmark", "Hong Kong", "India", "Japan", "Netherlands", "New Zealand", "South Africa", "United States of America"};
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
        private IWebElement countrySearchMessage
        {
            get
            {
                try
                {
                    return countryList.FindElement(By.CssSelector(".select2-results__message"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement statesList
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#select2-43j2-results[aria-hidden='false']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }


        public JQuery_Select_Asserts_Page(IWebDriver driver) : base(driver) { }

        public void IsSingleDropDownListDisplayed()
        {
            Assert.IsNotNull(singleDropDownList);
            Assert.IsNotNull(countryList);
        }

        public void IsSingleDropDownListNotDisplayed()
        {
            Assert.IsNull(singleDropDownList);
            Assert.IsNull(countryList);
        }

        public void IsCountryDisplayed(string expectedText)
        {
            IWebElement countryDisplay = driver.FindElement(By.Id("select2-country-container"));
            Assert.AreEqual(expectedText, countryDisplay.Text);
        }

        public int CountrySearchResults(string searchText, out List<string> searchResultList)
        {
            List<string> actualSearchList = new List<string>();
            foreach (var item in originalCountryList)
            {
                if (item.Contains(searchText))
                {
                    actualSearchList.Add(item);
                }
                else if (searchText.Length == 1)
                {                    
                    if (item.Contains(searchText.ToUpper()))
                    {
                        actualSearchList.Add(item);
                    }
                    else if (item.Contains(searchText.ToLower()))
                    {
                        actualSearchList.Add(item);
                    }
                }
            }

            IReadOnlyCollection<IWebElement> actualElementsList = countryList.FindElements(By.CssSelector("li"));
            Assert.AreEqual(actualSearchList.Count, actualElementsList.Count);

            foreach (var item in actualSearchList)
            {
                foreach (var element in actualElementsList)
                {
                    if (item == element.Text)
                    {
                        Assert.AreEqual(item, element.Text);
                        break;
                    }
                }
            }

            searchResultList = actualSearchList;
            return actualElementsList.Count;
        }

        public void NoCountryMessage()
        {
            string expectedText = "No results found";
            Assert.IsNotNull(countrySearchMessage);
            Assert.AreEqual(expectedText, countrySearchMessage.Text);
        }

        public void IsStatesListDisplayed() 
        {
            Assert.IsNotNull(statesList);
        }

    }
}
