using NUnit.Framework;
using NUnitTest_Selenium.Pages;
using OpenQA.Selenium;

namespace NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages
{
    public class Bootstrap_Alerts_Asserts_Page :BasePage
    {
        private IWebElement succesAutoAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-autocloseable-success[style='display: block;']"));
                }
                catch(NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement succesNormalAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-normal-success[style='display: block;']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }
        private IWebElement warningAutoAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-autocloseable-warning[style='display: block;']"));
                }
                catch (NoSuchElementException)
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
        private IWebElement dangerAutoAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-autocloseable-danger[style='display: block;']"));
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
        private IWebElement infoAutoAlert
        {
            get
            {
                try
                {
                    return driver.FindElement(By.CssSelector(".alert-autocloseable-info[style='display: block;']"));
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

        public Bootstrap_Alerts_Asserts_Page(IWebDriver driver): base( driver) { }

        public void SuccessAutoAlertDisplay()
        {
            Assert.IsNotNull(succesAutoAlert);
        }

        public void SuccessAutoAlertNotDisplay()
        {
            Assert.IsNull(succesAutoAlert);
        }

        public void SuccessNormalAlertDisplay()
        {
            Assert.IsNotNull(succesNormalAlert);
        }

        public void SuccessNormalAlertNotDisplay()
        {
            Assert.IsNull(succesNormalAlert);
        }

        public void WarningAutoAlertDisplay()
        {
            Assert.IsNotNull(warningAutoAlert);
        }

        public void WarningAutoAlertNotDisplay()
        {
            Assert.IsNull(warningAutoAlert);
        }

        public void WarningNormalAlertDisplay()
        {
            Assert.IsNotNull(warningNormalAlert);
        }

        public void WarningNormalAlertNotDisplay()
        {
            Assert.IsNull(warningNormalAlert);
        }

        public void DangerAutoAlertDisplay()
        {
            Assert.IsNotNull(dangerAutoAlert);
        }

        public void DangerAutoAlertNotDisplay()
        {
            Assert.IsNull(dangerAutoAlert);
        }

        public void DangerNormalAlertDisplay()
        {
            Assert.IsNotNull(dangerNormalAlert);
        }

        public void DangerNormalAlertNotDisplay()
        {
            Assert.IsNull(dangerNormalAlert);
        }

        public void InfoAutoAlertDisplay()
        {
            Assert.IsNotNull(infoAutoAlert);
        }

        public void InfoAutoAlertNotDisplay()
        {
            Assert.IsNull(infoAutoAlert);
        }

        public void InfoNormalAlertDisplay()
        {
            Assert.IsNotNull(infoNormalAlert);
        }

        public void InfoNormalAlertNotDisplay()
        {
            Assert.IsNull(infoNormalAlert);
        }
    }
}
