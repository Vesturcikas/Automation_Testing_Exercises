using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages;
using NUnitTest_Selenium.Pages.Alerts_Modals_Pages;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Alerts_Modals
{
    public class Bootstrap_Modals : BaseTest
    {
        private Bootstrap_Modals_Page bootstrModalsPage;
        private Bootstrap_Modals_Asserts_Page bootstrModalsAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/bootstrap-modal-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            bootstrModalsPage = new Bootstrap_Modals_Page(driver);
            bootstrModalsAssertsPage = new Bootstrap_Modals_Asserts_Page(driver);
        }

        [Test]
        public void SingleModalTest()
        {
            bootstrModalsPage.SingleModalButtonClick();
            Thread.Sleep(2000);
            bootstrModalsAssertsPage.SingleModalIsDisplayed();

            bootstrModalsPage.SingleModalClose();
            Thread.Sleep(2000);
            bootstrModalsAssertsPage.SingleModalNotDisplayed();

            bootstrModalsPage.SingleModalButtonClick();
            Thread.Sleep(2000);          
            bootstrModalsPage.SingleModalCloseX();
            Thread.Sleep(2000);
            bootstrModalsAssertsPage.SingleModalNotDisplayed();

            bootstrModalsPage.SingleModalButtonClick();
            Thread.Sleep(2000);
            bootstrModalsPage.SingleModalSaveChanges();
            Thread.Sleep(5000);
            bootstrModalsAssertsPage.SingleModalNotDisplayed();            
        }

        [Test]
        public void MultipleModalTest()
        {
            bootstrModalsPage.MultipleModalButtonClick();
            Thread.Sleep(2000);
            bootstrModalsAssertsPage.MultipleModalIsDisplayed();

            bootstrModalsPage.MultipleModalCloseX();
            Thread.Sleep(2000);
            bootstrModalsAssertsPage.MultipleModalNotDisplayed();

            bootstrModalsPage.MultipleModalButtonClick();
            Thread.Sleep(2000);
            bootstrModalsPage.MultipleModal2Open();
            Thread.Sleep(5000);
            bootstrModalsAssertsPage.MultipleModal2IsDisplayed();

            bootstrModalsPage.MultipleModal2Close();
            Thread.Sleep(2000);
            bootstrModalsAssertsPage.MultipleModal2NotDisplayed();

            bootstrModalsPage.MultipleModalSaveChanges();
            Thread.Sleep(5000);
            bootstrModalsAssertsPage.MultipleModalNotDisplayed();
        }

        [TearDown]
        public void AfterTest()
        {

        }
    }
}
