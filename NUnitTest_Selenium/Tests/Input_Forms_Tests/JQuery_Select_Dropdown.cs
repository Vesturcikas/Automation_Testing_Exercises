using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages;
using NUnitTest_Selenium.Pages.Inputs_Forms_Pages;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Input_Forms_Tests
{
    public class JQuery_Select_Dropdown : BaseTest
    {
        private JQuery_Select_Page jQueryPage;
        private JQuery_Select_Asserts_Page jQueryAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/jquery-dropdown-search-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            jQueryPage = new JQuery_Select_Page(driver);
            jQueryAssertsPage = new JQuery_Select_Asserts_Page(driver);
        }

        [Test]
        public void SingleDropDownListTest()
        {
            jQueryPage.CountrySelectClick();
            Thread.Sleep(1000);

            jQueryAssertsPage.IsSingleDropDownListDisplayed();

            jQueryPage.CountrySelectClick();
            Thread.Sleep(1000);

            jQueryAssertsPage.IsSingleDropDownListNotDisplayed();
        }

        [Test]
        public void CountrySelectTest()
        {
            string country = "Denmark";

            jQueryPage.CountrySelectClick();
            Thread.Sleep(3000);

            jQueryPage.SelectCountry(country);
            Thread.Sleep(5000);            
        }

        [TearDown]
        public void AfterTests() { }
    }
}
