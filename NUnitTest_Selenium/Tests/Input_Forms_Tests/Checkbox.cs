using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using NUnitTest_Selenium.AssertsPages;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Checkbox : BaseTest
    {
        private CheckboxPage checkboxPage;
        private CheckboxAssertsPage checkboxAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/basic-checkbox-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            checkboxPage = new CheckboxPage(driver);
            checkboxAssertsPage = new CheckboxAssertsPage(driver);
        }

        /// <summary>
        /// 
        /// Clicking on the checkbox will display a success message. Keep an eye on it
        /// 
        /// </summary>
        [Test]
        public void SingleCheckbox()
        {
            checkboxPage.SingleCheckboxCheck();
            checkboxAssertsPage.AssertIsCheckboxSelected();                 
        }

        /// <summary>
        /// 
        /// Click on 'Check All' to check all checkboxes at once.
        /// When you check all the checkboxes, button will change to 'Uncheck All'
        /// When you uncheck at least one checkbox, button will change to 'Check All'
        /// 
        /// </summary>
        [Test]
        public void MultipleCheckbox()
        {            
            string tekstas1 = "Uncheck All";
            string tekstas2 = "Check All";
            int i = 3;

            checkboxPage.CheckAll();
            checkboxAssertsPage.AssertCheckboxButton(tekstas1);       
            checkboxPage.CheckOneCheckbox(i);
            checkboxAssertsPage.AssertCheckboxButton(tekstas2);            
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
