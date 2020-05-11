using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages
{
    public class Validation_Form_Asserts_Page : BasePage
    {
        private IWebElement validationForm => driver.FindElement(By.CssSelector("form"));

        public Validation_Form_Asserts_Page(IWebDriver driver) : base(driver) { }

        public Validation_Form_Asserts_Page FirstNameInputCheck(string expectedText)
        {
            IWebElement firstNameInput = validationForm.FindElement(By.Name("first_name"));
            string actualText = firstNameInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page LasttNameInputCheck(string expectedText)
        {
            IWebElement lastNameInput = validationForm.FindElement(By.Name("last_name"));
            string actualText = lastNameInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page EmailInputCheck(string expectedText)
        {
            IWebElement emailInput = validationForm.FindElement(By.Name("email"));
            string actualText = emailInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page PhoneInputCheck(string expectedText)
        {
            IWebElement phoneNumberInput = validationForm.FindElement(By.Name("phone"));
            string actualText = phoneNumberInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page AddressInputCheck(string expectedText)
        {
            IWebElement addressInput = validationForm.FindElement(By.Name("address"));
            string actualText = addressInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page CityInputCheck(string expectedText)
        {
            IWebElement cityInput = validationForm.FindElement(By.Name("city"));
            string actualText = cityInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page ZipCodeInputCheck(string expectedText)
        {
            IWebElement zipCodeInput = validationForm.FindElement(By.Name("zip"));
            string actualText = zipCodeInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page WebsiteInputCheck(string expectedText)
        {
            IWebElement websiteInput = validationForm.FindElement(By.Name("website"));
            string actualText = websiteInput.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page CommentCheck(string expectedText)
        {
            IWebElement comment = validationForm.FindElement(By.Name("comment"));
            string actualText = comment.GetAttribute("value");
            Assert.AreEqual(expectedText, actualText);
            return this;
        }

        public Validation_Form_Asserts_Page StateCheck()
        {
            IWebElement states = validationForm.FindElement(By.Name("state"));            
            Assert.IsNotNull(states.GetAttribute("value"));
            return this;
        }
    }
}
