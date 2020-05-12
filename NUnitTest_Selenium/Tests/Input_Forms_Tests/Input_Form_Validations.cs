using NUnit.Framework;
using NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages;
using NUnitTest_Selenium.Pages.Inputs_Forms_Pages;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Input_Forms_Tests
{
    public class Input_Form_Validations : BaseTest
    {
        private Input_Form_Validation_Page validationPage;
        private Validation_Form_Asserts_Page validationAssertsPage;

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/input-form-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            validationPage = new Input_Form_Validation_Page(driver);
            validationAssertsPage = new Validation_Form_Asserts_Page(driver);
        }        

        [Test]
        public void FillFormTest()
        {
            string firstName = "Vesturas";
            string lastName = "Stanevicius";
            string email = "email@email.com";
            string phoneNumber = "+370 123 123 123";
            string address = "Gatve g.";
            string city = "Kaunas";
            int stateNumber = 5;
            string zipCode = "LT-1213";
            string website = "www.website.com";
            //for Hosting "Yes" or "No"
            string host = "No";
            string comment = "Komentaras, komentaras.";

            validationPage
                .FirstNameInput(firstName)
                .LastNameInput(lastName)
                .EmailInput(email)
                .PhoneNumberInput(phoneNumber)
                .AddressInput(address)
                .CityInput(city)
                .SelectState(stateNumber)
                .ZipCodeInput(zipCode)
                .WebInput(website)
                .HostingSelect(host)
                .CommentInput(comment);
                
            Thread.Sleep(1000);

            validationAssertsPage
                .FirstNameInputCheck(firstName)
                .LasttNameInputCheck(lastName)
                .EmailInputCheck(email)
                .PhoneInputCheck(phoneNumber)
                .AddressInputCheck(address)
                .CityInputCheck(city)
                .StateCheck()
                .ZipCodeInputCheck(zipCode)
                .WebsiteInputCheck(website)
                .CommentCheck(comment);
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
