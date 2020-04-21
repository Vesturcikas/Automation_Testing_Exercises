using NUnit.Framework;
using OpenQA.Selenium;
using NUnitTest_Selenium.Pages;
using NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages;

namespace NUnitTest_Selenium.Tests.Input_Forms_Tests
{
    public class Radio_Buttons : BaseTest
    {
        RadioButtonsPage radioButtonsPage;
        RadioButtonsAssertsPage radioButtonsAssertsPage;

        [SetUp]
        public void BevoreTests()
        {
            string testUrl = baseUrl + "/basic-radiobutton-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            radioButtonsPage = new RadioButtonsPage(driver);
            radioButtonsAssertsPage = new RadioButtonsAssertsPage(driver);
        }

        /// <summary>
        /// Click on button to get the selected value
        /// </summary>
        [Test]
        public void RadioButtonDemo()
        {
            string text1 = "Radio button is Not checked";
            string text2 = "Radio button 'Male' is checked";
            string text3 = "Radio button 'Female' is checked";

            radioButtonsPage.GetCheckedValueClick();

            radioButtonsAssertsPage.AssertTopRadioButtonValue(text1);

            radioButtonsPage
                .TopMaleButtonClick()
                .GetCheckedValueClick();

            radioButtonsAssertsPage.AssertTopRadioButtonValue(text2);

            radioButtonsPage
                .TopFemaleButtonClick()
                .GetCheckedValueClick();

            radioButtonsAssertsPage.AssertTopRadioButtonValue(text3);
        }

        /// <summary>
        /// Click on button to get the selected values from Group Sex and Age group
        /// </summary>
        [Test]
        public void GroupRadioButtonsDemo()
        {
            string text1 = "Sex :\r\nAge group:";
            string text2 = "Sex : Female\r\nAge group: 15 - 50";

            radioButtonsPage.GetGroupValues();

            radioButtonsAssertsPage.AssertGroupRadioButtonValue(text1);

            radioButtonsPage
                .DownFemaleButtonClick()
                .DownFiftyButtonClick()
                .GetGroupValues();

            radioButtonsAssertsPage.AssertGroupRadioButtonValue(text2);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
