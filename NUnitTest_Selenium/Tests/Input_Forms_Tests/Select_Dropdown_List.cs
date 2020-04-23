using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using NUnitTest_Selenium.Pages.Inputs_Forms_Pages;
using NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Select_Dropdown_List : BaseTest
    {
        private SelectDropDownPage dropDownPage;
        private SelectDropDownAssertsPage dropDownAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/basic-select-dropdown-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            dropDownPage = new SelectDropDownPage(driver);
            dropDownAssertsPage = new SelectDropDownAssertsPage(driver);
        }

        /// <summary>
        /// 
        /// Selected value from the list will display below the dropdown
        /// 
        /// </summary>
        [Test]
        public void SelectList()
        {
            string selectText = "Wednesday";

            dropDownPage
                .SelectListCklick()
                .SelectListSelectElement(selectText);

            dropDownAssertsPage.AssertMessageFromSelectList(selectText);            
        }

        /// <summary>
        /// 
        /// By clicking on the buttons, you can get value from the list which will display just below the buttons
        /// 
        /// </summary>
        [Test]
        public void MultiSelectList()
        {
            string selectText = "Texas";
            string selectText1 = "Texas,Florida,New York";

            dropDownPage
                .MultiSelectListSelectElement(selectText)
                .ButtonFirstClick();
            dropDownAssertsPage.AssertMessageFromMultiSelectList(selectText);            

            dropDownPage.ButtonAllClick();
            dropDownAssertsPage.AssertMessageFromMultiSelectList(selectText);
            
            dropDownPage
                .MultiSelect()
                .ButtonFirstClick();
            dropDownAssertsPage.AssertMessageFromMultiSelectList(selectText);

            dropDownPage.ButtonAllClick();
            dropDownAssertsPage.AssertMessageFromMultiSelectList(selectText1);
        }

        [TearDown]
        public void AfterTests()
        {

        }

    }
}
