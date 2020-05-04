using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnitTest_Selenium.Pages;
using NUnit.Framework;

namespace NUnitTest_Selenium.AssertsPages.Alerts_Modals_Asserts_Pages
{
    class Javascript_Alerts_Asserts_Page : BasePage
    {
        private IWebElement confirmMessage => driver.FindElement(By.Id("confirm-demo"));
        private IWebElement promptMessage => driver.FindElement(By.Id("prompt-demo"));

        public Javascript_Alerts_Asserts_Page(IWebDriver driver) : base(driver) { }

        public void AssertAlertMessage(string txt1, string txt2)
        {           
            Assert.AreEqual(txt1, txt2);
        }
        
        public void AssertConfirmMessage(string txt1)
        {
            switch (txt1)
            {
                case "Ok": 
                    {                        
                        Assert.AreEqual("You pressed OK!", confirmMessage.Text);
                        break;
                    }
                case "Cancel":
                    {
                        Assert.AreEqual("You pressed Cancel!", confirmMessage.Text);
                        break;
                    }
                default: 
                    break;
            }
        }

        public void AssertPromptMessage(string txt1, string txt2)
        {
            switch (txt1)
            {
                case "Ok":
                    {
                        string assertText = "You have entered '" + txt2 + "' !";
                        Assert.AreEqual(assertText, promptMessage.Text);
                        break;
                    }
                case "Cancel":
                    {
                        Assert.AreEqual("You have entered 'Enter name' !", promptMessage.Text);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
