using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages;
using NUnitTest_Selenium.Pages.Inputs_Forms_Pages;
using System;
using System.Collections.Generic;
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
            Thread.Sleep(2000);
            jQueryAssertsPage.IsCountryDisplayed(country);
        }

        [Test]
        public void CountrySearchOneLetterTest()
        {
            string k = "a";
            string k1 = "A";
            List<string> resultList0 = new List<string>();
            List<string> resultList1 = new List<string>();
            Random rnd = new Random();
            int num;

            jQueryPage
                .CountrySelectClick()
                .CountrySearchInput(k);
            Thread.Sleep(3000);

            int n0 = jQueryAssertsPage.CountrySearchResults(k, out resultList0);

            jQueryPage.CountrySearchInput(k1);
            int n1 = jQueryAssertsPage.CountrySearchResults(k1, out resultList1);
            Thread.Sleep(3000);

            Assert.AreEqual(n0, n1);
            Assert.AreEqual(resultList0, resultList1);

            if (n0>1)
            {
                num = rnd.Next(0, n0-1);
                jQueryPage.SelectCountry(resultList0[num]);
                jQueryAssertsPage.IsCountryDisplayed(resultList0[num]);
                Thread.Sleep(3000);
            }
            else if (n0 == 1)
            {                
                jQueryPage.SelectCountry(resultList0[0]);
                jQueryAssertsPage.IsCountryDisplayed(resultList0[0]);
                Thread.Sleep(3000);
            }
        }

        [Test]
        public void CountrySearchStringTest()
        {
            string testInputText1 = "dl";
            List<string> resultsList = new List<string>();

            jQueryPage
                .CountrySelectClick()
                .CountrySearchInput(testInputText1);
            Thread.Sleep(3000);

            jQueryAssertsPage.NoCountryMessage();
            Thread.Sleep(2000);
        }

        [Test]
        public void MultiSelectBoxTest()
        {
            string state0 = "Georgia";
            jQueryPage.MultiSelectClick();
            Thread.Sleep(2000);
            //jQueryAssertsPage.IsStatesListDisplayed();
            jQueryPage.SelectState(state0);
            Thread.Sleep(2000);
        }

        [TearDown]
        public void AfterTests() { }
    }
}
