using OpenQA.Selenium;


namespace NUnitTest_Selenium.Pages
{
    public class SimpleFormPage : BasePage
    {
        private IWebElement userMessageInput => driver.FindElement(By.Id("user-message"));
        private IWebElement buttonShowMessage => driver.FindElement(By.CssSelector("#get-input > button"));
        public IWebElement userMessageShow => driver.FindElement(By.CssSelector("#user-message > #display"));
        private IWebElement firstNum => driver.FindElement(By.Id("sum1"));
        private IWebElement secondNum => driver.FindElement(By.Id("sum2"));
        private IWebElement buttonGetTotal => driver.FindElement(By.CssSelector("#gettotal > button"));
        public IWebElement displayValue => driver.FindElement(By.Id("displayvalue"));

        public SimpleFormPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public SimpleFormPage InputText(string text)
        {
            userMessageInput.SendKeys(text);
            buttonShowMessage.Click();
            return this;
        }

        public SimpleFormPage AddTwoNumbers(string a, string b)
        {
            firstNum.SendKeys(a);
            secondNum.SendKeys(b);
            buttonGetTotal.Click();
            return this;
        }
    }
}
