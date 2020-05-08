using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages
{
    public class Bootstrap_Modals_Asserts_Page : BasePage
    {
        private IWebElement singleModal
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#myModal0"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement multipleModal10
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#myModal"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement multipleModal2
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#myModal2"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public Bootstrap_Modals_Asserts_Page(IWebDriver driver) : base(driver) { }

        public void SingleModalIsDisplayed()
        {
            Assert.IsTrue(singleModal.Displayed);
        }

        public void SingleModalNotDisplayed()
        {
            Assert.IsFalse(singleModal.Displayed);
        }

        public void MultipleModalIsDisplayed()
        {
            Assert.IsTrue(multipleModal10.Displayed);
        }

        public void MultipleModalNotDisplayed()
        {
            Assert.IsFalse(multipleModal10.Displayed);
        }

        public void MultipleModal2IsDisplayed()
        {
            Assert.IsTrue(multipleModal2.Displayed);
        }

        public void MultipleModal2NotDisplayed()
        {
            Assert.IsFalse(multipleModal2.Displayed);
        }
    }
}
