using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Checkbox : BaseTest
    {
        private IWebElement checkboxSingle => driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement message => driver.FindElement(By.Id("txtAge"));
        private IWebElement buttonCheck => driver.FindElement(By.Id("check1"));        

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/basic-checkbox-demo.html";
            driver.Navigate().GoToUrl(testUrl);
        }

        /// <summary>
        /// 
        /// Clicking on the checkbox will display a success message. Keep an eye on it
        /// 
        /// </summary>
        [Test]
        public void SingleCheckbox()
        {
            checkboxSingle.Click();

            Assert.IsTrue(checkboxSingle.Selected);           
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
            var checkboxElementList = driver.FindElements(By.CssSelector("input.cb1-element"));
            string tekstas1 = "Uncheck All";
            string tekstas2 = "Check All";

            buttonCheck.Click();

            Assert.AreEqual(tekstas1, buttonCheck.GetAttribute("value"));

            checkboxElementList[3].Click();

            Assert.AreEqual(tekstas2, buttonCheck.GetAttribute("value"));
        }

        [TearDown]
        public void AfterTests()
        {

        }
    }
}
