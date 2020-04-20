using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using NUnitTest_Selenium.AssertsPages;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Simple_Form : BaseTest
    {      
        private SimpleFormPage simpleFormPage;
        private SimpleFormAssertsPage simpleFormAssertsPage;
            
        [SetUp]
        public void BeforeTest()
        {
            string testUrl = baseUrl + "/basic-first-form-demo.html";
            driver.Navigate().GoToUrl(testUrl);
            simpleFormPage = new SimpleFormPage(driver);
            simpleFormAssertsPage = new SimpleFormAssertsPage(driver);
        }

        /// <summary>
        /// 
        /// Enter your message
        /// Click on 'Show Message' button to display message entered in input field
        /// 
        /// </summary>
        [Test]
        public void SingleInputField()
        {
            string text1 = "Hello, this is user message.";

            simpleFormPage.InputText(text1);
            simpleFormAssertsPage.AssertUserMessageText(text1);            
        }

        /// <summary>
        /// 
        /// Enter Value for a
        /// Enter Value for b
        /// Click on 'Get Total' button to display the sum of two numbers 'a and b'
        /// 
        /// </summary>
        [Test]
        public void TwoInputFields()
        {
            string a = "5";
            string b = "7";
            string resultat = "12";

            simpleFormPage.AddTwoNumbers(a, b);
            simpleFormAssertsPage.AssertDispayedValue(resultat);            
        }

        [TearDown]
        public void AfterTest()
        {

        }
    }
}
