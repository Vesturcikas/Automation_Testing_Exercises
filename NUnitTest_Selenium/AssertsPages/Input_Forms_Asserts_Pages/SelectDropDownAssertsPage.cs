using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages
{
    public class SelectDropDownAssertsPage : BasePage
    {
        private IWebElement messageFromSelectList => driver.FindElement(By.ClassName("selected-value"));
        private IWebElement messageFromMultiList => driver.FindElement(By.CssSelector(".getall-selected"));
        public SelectDropDownAssertsPage(IWebDriver driver) : base(driver) { }

        public void AssertMessageFromSelectList(string text)
        {
            string assertString = "Day selected :- " + text;
            Assert.AreEqual(assertString, messageFromSelectList.Text);
            Assert.IsTrue(messageFromSelectList.Text.Contains(text));
        }

        public void AssertMessageFromMultiSelectList(string text)
        {
            Assert.IsTrue(messageFromMultiList.Text.Contains(text));
        }
        
    }
}
