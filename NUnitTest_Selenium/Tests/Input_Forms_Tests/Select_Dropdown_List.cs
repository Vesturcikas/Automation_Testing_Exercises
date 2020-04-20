using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Select_Dropdown_List : BaseTest
    {
        private IWebElement selectList => driver.FindElement(By.Id("select-demo"));        
        private IWebElement messageFromSelectList => driver.FindElement(By.ClassName("selected-value"));
        private IWebElement multiSelectList => driver.FindElement(By.Id("multi-select"));
        private IWebElement buttonFirst => driver.FindElement(By.Id("printMe"));
        private IWebElement buttonAll => driver.FindElement(By.Id("printAll"));
        private IWebElement messageFromMultiList => driver.FindElement(By.CssSelector(".getall-selected"));

       

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/basic-select-dropdown-demo.html";
            driver.Navigate().GoToUrl(testUrl);
        }

        /// <summary>
        /// 
        /// Selected value from the list will display below the dropdown
        /// 
        /// </summary>
        [Test]
        public void SelectList()
        {
            string selectText = "Wednesday";

            selectList.Click();
            new SelectElement(selectList).SelectByText(selectText);

            Assert.AreEqual("Day selected :- Wednesday", messageFromSelectList.Text);
            Assert.IsTrue(messageFromSelectList.Text.Contains("Wednesday"));
        }

        /// <summary>
        /// 
        /// By clicking on the buttons, you can get value from the list which will display just below the buttons
        /// 
        /// </summary>
        [Test]
        public void MultiSelectList()
        {
            new SelectElement(multiSelectList).SelectByText("Texas");
            /*
            act.KeyDown(Keys.Control);
            act.MoveToElement(multiSelectList.FindElement(By.CssSelector("[value='Texas']"))).Click();
            act.KeyUp(Keys.Control);
            act.Build().Perform();
            */
            buttonFirst.Click();

            Assert.IsTrue(messageFromMultiList.Text.Contains("Texas"));

            buttonAll.Click();

            Assert.IsTrue(messageFromMultiList.Text.Contains("Texas"));
                        
            
            act.KeyDown(Keys.Control);
            act.MoveToElement(multiSelectList.FindElement(By.CssSelector("[value='Florida']"))).Click();
            act.MoveToElement(multiSelectList.FindElement(By.CssSelector("[value='New York']"))).Click();
            act.KeyUp(Keys.Control);
            act.Build().Perform();
            buttonFirst.Click();

            Assert.IsTrue(messageFromMultiList.Text.Contains("Texas"));

            buttonAll.Click();

            Assert.IsTrue(messageFromMultiList.Text.Contains("Texas,Florida,New York"));
        }

        [TearDown]
        public void AfterTests()
        {

        }

    }
}
