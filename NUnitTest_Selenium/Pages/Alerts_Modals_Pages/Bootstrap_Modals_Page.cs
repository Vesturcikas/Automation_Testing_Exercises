using OpenQA.Selenium;

namespace NUnitTest_Selenium.Pages.Alerts_Modals_Pages
{
    public class Bootstrap_Modals_Page : BasePage
    {
        private IWebElement singleModalButton => driver
            .FindElement(By.CssSelector("a[href='#myModal0']"));
        private IWebElement multipleModalButton => driver
            .FindElement(By.CssSelector("a[href='#myModal']"));
        private IWebElement singleModal 
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector("#myModal0"));
                }
                catch(NoSuchElementException)
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



        public Bootstrap_Modals_Page(IWebDriver driver):base(driver) { }

        public Bootstrap_Modals_Page SingleModalButtonClick()
        {
            singleModalButton.Click();
            return this;
        }

        public Bootstrap_Modals_Page SingleModalClose()
        {
            singleModal.FindElement(By.CssSelector("a[data-dismiss='modal']")).Click();
            return this;
        }

        public Bootstrap_Modals_Page SingleModalSaveChanges()
        {
            singleModal.FindElement(By.CssSelector("a[onclick='history.go(0)']")).Click();
            return this;
        }

        public Bootstrap_Modals_Page SingleModalCloseX()
        {
            singleModal.FindElement(By.CssSelector("button[class='close']")).Click();
            return this;
        }

        public Bootstrap_Modals_Page MultipleModalButtonClick()
        {
            multipleModalButton.Click();
            return this;
        }

        public Bootstrap_Modals_Page MultipleModalCloseX()
        {
            multipleModal10.FindElement(By.CssSelector("button[class='close']")).Click();
            return this;
        }

        public Bootstrap_Modals_Page MultipleModal2Open()
        {
            multipleModal10.FindElement(By.CssSelector("a[href='#myModal2']")).Click();
            return this;
        }

        public Bootstrap_Modals_Page MultipleModal2Close()
        {
            multipleModal2.FindElement(By.CssSelector("a[data-dismiss='modal']")).Click();
            return this;
        }

        public Bootstrap_Modals_Page MultipleModalSaveChanges()
        {
            multipleModal10.FindElement(By.CssSelector("a[onclick='history.go(0)']")).Click();
            return this;
        }
    }
}
