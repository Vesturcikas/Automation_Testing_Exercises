using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_Selenium.AssertsPages
{
    public class CheckboxAssertsPage : BasePage
    {
        private IWebElement checkboxSingle => driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement message => driver.FindElement(By.Id("txtAge"));
        private IWebElement buttonCheck => driver.FindElement(By.Id("check1"));


        public CheckboxAssertsPage(IWebDriver driver) : base(driver) { }

        public void AssertIsCheckboxSelected()
        {
            Assert.IsTrue(checkboxSingle.Selected);
        }
        
        public void AssertIsMessageEqual(string tekstas)
        {
            Assert.AreEqual(tekstas, message.Text);
        }

        public void AssertCheckboxButton(string tekstas)
        {
            Assert.AreEqual(tekstas, buttonCheck.GetAttribute("value"));
        }
    }     
}
