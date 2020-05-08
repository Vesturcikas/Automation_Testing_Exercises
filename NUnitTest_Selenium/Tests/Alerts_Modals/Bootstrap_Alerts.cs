using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages;
using NUnitTest_Selenium.Pages.Alerts_Modals_Pages;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Alerts_Modals
{
    public class Bootstrap_Alerts:BaseTest
    {
        private Bootstrap_Alerts_Page bootstrapAlertsPage;
        private Bootstrap_Alerts_Asserts_Page bootstrapAlertsAssertsPage;        

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/bootstrap-alert-messages-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            bootstrapAlertsPage = new Bootstrap_Alerts_Page(driver);
            bootstrapAlertsAssertsPage = new Bootstrap_Alerts_Asserts_Page(driver);            
        }

        /// <summary>
        /// Click below button to display normal/auto closeable message in respective colors
        /// </summary>
        [Test]        
        public void SuccessAutoButtonTest()
        {
            bootstrapAlertsPage.SuccessAutoButtonClick();                       

            bootstrapAlertsAssertsPage.SuccessAutoAlertDisplay();
            Thread.Sleep(5000);
            bootstrapAlertsAssertsPage.SuccessAutoAlertNotDisplay();
        }

        [Test]
        public void SuccesNormalButtonTest()
        {
            bootstrapAlertsPage.SuccessNormalButtonClick();
            //Thread.Sleep(2000);
            bootstrapAlertsAssertsPage.SuccessNormalAlertDisplay();

            bootstrapAlertsPage.SuccesNormalAlertClose();

            bootstrapAlertsAssertsPage.SuccessNormalAlertNotDisplay();
        }

        [Test]
        public void WarningAutoButtonTest()
        {
            bootstrapAlertsPage.WarningAutoButtonClick();

            bootstrapAlertsAssertsPage.WarningAutoAlertDisplay();
            Thread.Sleep(3000);
            bootstrapAlertsAssertsPage.WarningAutoAlertNotDisplay();
        }

        [Test]
        public void WarningNormalButtonTest()
        {
            bootstrapAlertsPage.WarningNormalButtonClick();
            //Thread.Sleep(2000);
            bootstrapAlertsAssertsPage.WarningNormalAlertDisplay();

            bootstrapAlertsPage.WarningNormalAlertClose();

            bootstrapAlertsAssertsPage.WarningNormalAlertNotDisplay();
        }

        [Test]
        public void DangerAutoButtonTest()
        {
            bootstrapAlertsPage.DangerAutoButtonClick();

            bootstrapAlertsAssertsPage.DangerAutoAlertDisplay();
            Thread.Sleep(5000);
            bootstrapAlertsAssertsPage.DangerAutoAlertNotDisplay();
        }

        [Test]
        public void DangerNormalButtonTest()
        {
            bootstrapAlertsPage.DangerNormalButtonClick();
            //Thread.Sleep(2000);
            bootstrapAlertsAssertsPage.DangerNormalAlertDisplay();

            bootstrapAlertsPage.DangerNormalAlertClose();

            bootstrapAlertsAssertsPage.DangerNormalAlertNotDisplay();
        }

        [Test]
        public void InfoAutoButtonTest()
        {
            bootstrapAlertsPage.InfoAutoButtonClick();

            bootstrapAlertsAssertsPage.InfoAutoAlertDisplay();
            Thread.Sleep(6000);
            bootstrapAlertsAssertsPage.InfoAutoAlertNotDisplay();
        }

        [Test]
        public void InfoNormalButtonTest()
        {
            bootstrapAlertsPage.InfoNormalButtonClick();
            //Thread.Sleep(2000);
            bootstrapAlertsAssertsPage.InfoNormalAlertDisplay();

            bootstrapAlertsPage.InfoNormalAlertClose();

            bootstrapAlertsAssertsPage.InfoNormalAlertNotDisplay();
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
