using OpenQA.Selenium;

namespace NUnitTest_Selenium.Pages.Alerts_Modals_Pages
{
    public class Bootstrap_Alerts_Page : BasePage
    {
        private IWebElement successAutoButton => driver.FindElement(By.Id("autoclosable-btn-success"));
        private IWebElement successNormalButton => driver.FindElement(By.Id("normal-btn-success"));
        private IWebElement warningAutoButton => driver.FindElement(By.Id("autoclosable-btn-warning"));
        private IWebElement warningNormalButton => driver.FindElement(By.Id("normal-btn-warning"));
        private IWebElement dangerAutoButton => driver.FindElement(By.Id("autoclosable-btn-danger"));
        private IWebElement dangerNormalButton => driver.FindElement(By.Id("normal-btn-danger"));
        private IWebElement infoAutoButton => driver.FindElement(By.Id("autoclosable-btn-info"));
        private IWebElement infoNormalButton => driver.FindElement(By.Id("normal-btn-info"));
        private IWebElement succesNormalAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-normal-success[style='display: block;']"));
                }
                catch(NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement warningNormalAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-normal-warning[style='display: block;']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement dangerNormalAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-normal-danger[style='display: block;']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement infoNormalAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-normal-info[style='display: block;']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public Bootstrap_Alerts_Page(IWebDriver driver) : base(driver) { }

        public Bootstrap_Alerts_Page SuccessAutoButtonClick()
        {
            successAutoButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page SuccessNormalButtonClick()
        {
            successNormalButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page SuccesNormalAlertClose()
        {
            succesNormalAlert.FindElement(By.CssSelector(".close")).Click();
            return this;
        }

        public Bootstrap_Alerts_Page WarningAutoButtonClick()
        {
            warningAutoButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page WarningNormalButtonClick()
        {
            warningNormalButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page WarningNormalAlertClose()
        {
            warningNormalAlert.FindElement(By.CssSelector(".close")).Click();
            return this;
        }

        public Bootstrap_Alerts_Page DangerAutoButtonClick()
        {
            dangerAutoButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page DangerNormalButtonClick()
        {
            dangerNormalButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page DangerNormalAlertClose()
        {
            dangerNormalAlert.FindElement(By.CssSelector(".close")).Click();
            return this;
        }

        public Bootstrap_Alerts_Page InfoAutoButtonClick()
        {
            infoAutoButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page InfoNormalButtonClick()
        {
            infoNormalButton.Click();
            return this;
        }

        public Bootstrap_Alerts_Page InfoNormalAlertClose()
        {
            infoNormalAlert.FindElement(By.CssSelector(".close")).Click();
            return this;
        }
    }
}
