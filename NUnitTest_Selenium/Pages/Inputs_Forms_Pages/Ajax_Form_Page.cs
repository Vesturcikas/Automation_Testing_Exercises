using OpenQA.Selenium;

namespace NUnitTest_Selenium.Pages.Inputs_Forms_Pages
{
    public class Ajax_Form_Page : BasePage
    {
        private IWebElement form => driver.FindElement(By.CssSelector("form"));
        private IWebElement inputName => form.FindElement(By.Id("title"));
        private IWebElement inputComment => form.FindElement(By.Id("description"));
        private IWebElement buttonSubmit => form.FindElement(By.Id("btn-submit"));
        public Ajax_Form_Page(IWebDriver driver) : base(driver) { }

        public Ajax_Form_Page NameInputClick()
        {            
            inputName.Click();
            return this;
        }

        public Ajax_Form_Page InputName(string inputText)
        {
            inputName.SendKeys(inputText);
            return this;
        }

        public Ajax_Form_Page NameCommentClick()
        {
            inputComment.Click();
            return this;
        }

        public Ajax_Form_Page InputComment(string inputText)
        {
            inputComment.SendKeys(inputText);
            return this;
        }

        public Ajax_Form_Page ButtonSubmitClick()
        {
            buttonSubmit.Click();
            return this;
        }
    }
}
