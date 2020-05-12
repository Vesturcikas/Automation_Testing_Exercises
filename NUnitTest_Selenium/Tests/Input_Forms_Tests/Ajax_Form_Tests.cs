using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages;
using NUnitTest_Selenium.Pages.Inputs_Forms_Pages;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Input_Forms_Tests
{
    public class Ajax_Form_Tests : BaseTest
    {
        private Ajax_Form_Page ajaxFormPage;
        private Ajax_Form_Asserts_Page ajaxFormAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/ajax-form-submit-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            ajaxFormPage = new Ajax_Form_Page(driver);
            ajaxFormAssertsPage = new Ajax_Form_Asserts_Page(driver);
        }

        [Test]
        public void NameInputTest()
        {
            string nameText = "Vestas";
            ajaxFormPage.InputName(nameText);
                
            ajaxFormAssertsPage.NameInputCheck(nameText);
        }

        [Test]
        public void CommentInputTest()
        {
            string commentText = "Komentaras, komentaras.";
            ajaxFormPage.InputComment(commentText);

            ajaxFormAssertsPage.CommentInputCheck(commentText);
        }

        [Test]
        public void FormFillTest()
        {
            string nameText = "Vestas";
            string commentText = "Komentaras, komentaras.";
            ajaxFormPage
                .InputName(nameText)
                .InputComment(commentText)
                .ButtonSubmitClick();
            Thread.Sleep(1000);

            ajaxFormAssertsPage.FormSubmited();
        }

        [Test]
        public void WrongFormFillTest()
        {
            string nameText = "";
            string commentText = "Komentaras, komentaras.";
            ajaxFormPage
                .InputName(nameText)
                .InputComment(commentText)
                .ButtonSubmitClick();
            Thread.Sleep(1000);

            ajaxFormAssertsPage.FormNotSubmited();
        }        

        [TearDown]
        public void AfterTests() { }
    }
}
