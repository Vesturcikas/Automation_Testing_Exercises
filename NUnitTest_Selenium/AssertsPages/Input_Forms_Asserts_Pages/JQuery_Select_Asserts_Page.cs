using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages
{
    public class JQuery_Select_Asserts_Page : BasePage
    {
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
    }
}
