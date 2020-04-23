using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_Selenium.AssertsPages
{
    public class SimpleFormAssertsPage : BasePage
    {
        private IWebElement userMessageShow => driver.FindElement(By.CssSelector("#user-message > #display"));
        private IWebElement displayValue => driver.FindElement(By.Id("displayvalue"));

        public SimpleFormAssertsPage(IWebDriver driver) : base(driver) { }

        public void AssertUserMessageText(string text1)
        {
            Assert.AreEqual(text1, userMessageShow.Text);            
        }

        public void AssertDispayedValue(string c)
        {
            Assert.AreEqual(c, displayValue.Text);            
        }
    }
}
