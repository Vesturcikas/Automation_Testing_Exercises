using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_Selenium.AssertsPages.Input_Forms_Asserts_Pages
{
    public class RadioButtonsAssertsPage : BasePage
    {
        IWebElement radioButtonValue => driver.FindElement(By.CssSelector(".radiobutton"));
        IWebElement groupRadioButtonValue => driver.FindElement(By.CssSelector(".groupradiobutton"));

        public RadioButtonsAssertsPage(IWebDriver driver) : base (driver) { }

        public void AssertTopRadioButtonValue(string text)
        {
            Assert.AreEqual(text, radioButtonValue.Text);
        }

        public void AssertGroupRadioButtonValue(string text)
        {
            Assert.AreEqual(text, groupRadioButtonValue.Text);
        }

        ////*[@id="easycont"]/div/div[2]/div[2]/div[2]/p[2]/text()[1]
        /////*[@id="easycont"]/div/div[2]/div[2]/div[2]/p[2]/text()[2]
    }
}
