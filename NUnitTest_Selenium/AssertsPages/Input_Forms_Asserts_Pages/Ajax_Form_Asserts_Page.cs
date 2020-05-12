using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages
{
    public class Ajax_Form_Asserts_Page : BasePage
    {
        private IWebElement form => driver.FindElement(By.CssSelector("form"));
        private IWebElement inputName => form.FindElement(By.Id("title"));
        private IWebElement inputComment => form.FindElement(By.Id("description"));
        private IWebElement submitControl => form.FindElement(By.Id("submit-control"));        
            
        public Ajax_Form_Asserts_Page(IWebDriver driver) : base(driver) { }

        public void FormSubmited()
        {
            string expectedText = "Form submited Successfully!";
            Assert.AreEqual(expectedText, submitControl.Text);
        }

        public void FormNotSubmited()
        {
            IWebElement star = form.FindElement(By.CssSelector(".validation-error"));
            Assert.AreEqual("*", star.Text);

            string borderColor = inputName.GetCssValue("borderColor");
            Assert.AreEqual("rgb(255, 0, 0)", borderColor);            
        }

        public void NameInputCheck(string expectedText)
        {
            string actualText = inputName.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
        }

        public void CommentInputCheck(string expectedText)
        {
            string actualText = inputComment.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
        }
    }
}
