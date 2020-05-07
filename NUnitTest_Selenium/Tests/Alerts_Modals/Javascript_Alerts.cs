using NUnit.Framework;
using System;
using NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages;
using NUnitTest_Selenium.Pages.Alerts_Modals_Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest_Selenium.Tests.Alerts_Modals
{
    public class Javascript_Alerts : BaseTest
    {
        private Javascript_Alerts_Page javaAlertsPage;
        private Javascript_Alerts_Asserts_Page javaAlertsAssertsPage;
        private WebDriverWait wait;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/javascript-alert-box-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            javaAlertsPage = new Javascript_Alerts_Page(driver);
            javaAlertsAssertsPage = new Javascript_Alerts_Asserts_Page(driver);

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// When an alert box pops up, user have to click "OK" button to proceed.
        /// </summary>
        [Test]
        [Obsolete]
        public void AlertBoxTest()
        {
            string trueText = "I am an alert box!";

            javaAlertsPage.AlertBoxButtonClick();

            //Wait for the alert to be displayed
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

            //Store the alert text in a variable
            string alertText = alert.Text;

            javaAlertsAssertsPage.AssertAlertMessage(trueText, alertText);

            //Press the OK button
            alert.Accept();
        }

        /// <summary>
        /// When a confirm box pops up, user can click "OK" or "Cancel" to proceed.
        /// </summary>
        [Test]
        [Obsolete]
        public void ConfirmBoxTest()
        {
            string trueText = "Press a button!";

            //Wait for the alert to be displayed
            javaAlertsPage.ConfirmBoxButtonClick();

            //Wait for the alert to be displayed
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

            //Store the alert text in a variable
            string alertText = alert.Text;

            javaAlertsAssertsPage.AssertAlertMessage(trueText, alertText);

            //Press the OK button
            alert.Accept();

            javaAlertsAssertsPage.AssertConfirmMessage("Ok");

            javaAlertsPage.ConfirmBoxButtonClick();
            alert = wait.Until(ExpectedConditions.AlertIsPresent());

            //Press the Cancel button
            alert.Dismiss();

            javaAlertsAssertsPage.AssertConfirmMessage("Cancel");
        }

        [Test]
        [Obsolete]
        public void PromptBoxTestOK()
        {
            string trueText = "Please enter your name";
            string text = "Vesturas";

            javaAlertsPage.PromptBoxButtonClick();

            //Wait for the alert to be displayed
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

            //Store the alert text in a variable
            string alertText = alert.Text;

            javaAlertsAssertsPage.AssertAlertMessage(trueText, alertText);

            //Type your message
            alert.SendKeys(text);

            //Press the OK button
            alert.Accept();

            javaAlertsAssertsPage.AssertPromptMessage("Ok", text);
        }

        /*
        [Test]
        public void PromptBoxTestCancel()
        {
            string trueText = "Please enter your name";            

            javaAlertsPage.PromptBoxButtonClick();

            //Wait for the alert to be displayed
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());

            //Store the alert text in a variable
            string alertText = alert.Text;

            javaAlertsAssertsPage.AssertAlertMessage(trueText, alertText);           

            //Press the Cancel button
            alert.Dismiss();

            javaAlertsAssertsPage.AssertPromptMessage("Cancel", "");
        }
        */

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
