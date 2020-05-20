using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages;
using NUnitTest_Selenium.Pages.Alerts_Modals_Pages;

namespace NUnitTest_Selenium.Tests.Alerts_Modals
{
    public class FileDownload:BaseTest
    {
        string testText = "Bandomasis tekstas";

        private File_Download_Page fileDownloadPage;
        private File_Download_Asserts_Page fileDownloadAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/generate-file-to-download-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            fileDownloadPage = new File_Download_Page(driver);
            fileDownloadAssertsPage = new File_Download_Asserts_Page(driver);
        }

        [Test]
        public void InputTextTest()
        {
            fileDownloadPage.TextInput(testText);
            
            fileDownloadAssertsPage.CountSimbols(testText);
        }

        [Test]
        public void CreatingFileTest()
        {
            fileDownloadPage
                .TextInput(testText)
                .CreatButtonClick();

            fileDownloadAssertsPage.CheckLinkToDownload();
        }

        [Test]
        public void DownloadTest()
        {
            //Store the ID of the original window
            string originalWindowID = driver.CurrentWindowHandle;

            fileDownloadPage
                .TextInput(testText)
                .CreatButtonClick();
            Thread.Sleep(3000);
            fileDownloadAssertsPage.CheckLinkToDownload();
            Thread.Sleep(3000);
            fileDownloadPage.DownloadClick();
            Thread.Sleep(3000);
            //fileDownloadAssertsPage.IsMoreWindowsOpen(2);

            fileDownloadPage.SwitchToWindow(originalWindowID);

            Thread.Sleep(3000);
        }

        [TearDown]
        public void AfterTests()
        {

        }

    }
}
