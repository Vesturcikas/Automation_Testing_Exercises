using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Simple_Form : BaseTest
    {
        private IWebElement userMessageInput => driver.FindElement(By.Id("user-message"));
        private IWebElement buttonShowMessage => driver.FindElement(By.CssSelector("#get-input > button"));
        private IWebElement userMessageShow => driver.FindElement(By.CssSelector("#user-message > #display"));
        private IWebElement firstNum => driver.FindElement(By.Id("sum1"));
        private IWebElement secondNum => driver.FindElement(By.Id("sum2"));
        private IWebElement buttonGetTotal => driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement displayValue => driver.FindElement(By.Id("displayvalue"));

        [SetUp]
        public void BeforeTest()
        {
            string testUrl = baseUrl + "/basic-first-form-demo.html";
            driver.Navigate().GoToUrl(testUrl);
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
            userMessageInput.SendKeys("Hello, this is user message.");
            buttonShowMessage.Click();

            Assert.AreEqual("Hello, this is user message.", userMessageShow.Text);
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
            firstNum.SendKeys("5");
            secondNum.SendKeys("7");
            buttonGetTotal.Click();

            Assert.AreEqual("12", displayValue.Text);
        }

        [TearDown]
        public void AfterTest()
        {

        }
    }
}
