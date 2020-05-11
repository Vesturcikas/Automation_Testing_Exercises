using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest_Selenium.Pages.Inputs_Forms_Pages
{
    public class Input_Form_Validation_Page : BasePage
    {
        private IWebElement validationForm => driver.FindElement(By.CssSelector("form"));
        
        public Input_Form_Validation_Page(IWebDriver driver):base(driver) { }

        public Input_Form_Validation_Page FirstNameInput(string text)
        {
            IWebElement firstNameInput = validationForm.FindElement(By.Name("first_name"));
            firstNameInput.Clear();
            firstNameInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page LastNameInput(string text)
        {
            IWebElement lastNameInput = validationForm.FindElement(By.Name("last_name"));
            lastNameInput.Clear();
            lastNameInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page EmailInput(string text)
        {
            IWebElement emailInput = validationForm.FindElement(By.Name("email"));
            emailInput.Clear();
            emailInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page PhoneNumberInput(string text)
        {
            IWebElement phoneNumberInput = validationForm.FindElement(By.Name("phone"));
            phoneNumberInput.Clear();
            phoneNumberInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page AddressInput(string text)
        {
            IWebElement addressInput = validationForm.FindElement(By.Name("address"));
            addressInput.Clear();
            addressInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page CityInput(string text)
        {
            IWebElement cityInput = validationForm.FindElement(By.Name("city"));
            cityInput.Clear();
            cityInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page SelectState(int numb)
        {
            IWebElement states = validationForm.FindElement(By.Name("state"));
            new SelectElement(states).SelectByIndex(numb);
            return this;
        }

        public Input_Form_Validation_Page ZipCodeInput(string text)
        {
            IWebElement zipCodeInput = validationForm.FindElement(By.Name("zip"));
            zipCodeInput.Clear();
            zipCodeInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page WebInput(string text)
        {
            IWebElement websiteInput = validationForm.FindElement(By.Name("website"));
            websiteInput.Clear();
            websiteInput.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page HostingSelect(string text)
        {
            IWebElement hostingYes = validationForm.FindElement(By.CssSelector(".radio input[value='yes']"));
            IWebElement hostingNo = validationForm.FindElement(By.CssSelector(".radio input[value='no']"));

            switch (text)
            {
                case "Yes": hostingYes.Click(); break;
                case "No": hostingNo.Click(); break;
                default:
                    break;
            }
            return this;
        }

        public Input_Form_Validation_Page CommentInput(string text)
        {
            IWebElement comment = validationForm.FindElement(By.Name("comment"));
            comment.Clear();
            comment.SendKeys(text);
            return this;
        }

        public Input_Form_Validation_Page SendButtonClick()
        {
            IWebElement buttonSend = validationForm.FindElement(By.CssSelector("button[type='submit']"));
            buttonSend.Click();
            return this;
        }

    }
}
