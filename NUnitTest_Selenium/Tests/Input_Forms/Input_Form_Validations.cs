using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTest_Selenium.Tests.Input_Forms
{
    public class Input_Form_Validations : BaseTest
    {
        private IWebElement firstname => driver.FindElement(By.Name("first_name"));
        private IWebElement lastname => driver.FindElement(By.Name("last_name"));
        private IWebElement email => driver.FindElement(By.Name("email"));
        private IWebElement phone => driver.FindElement(By.Name("phone"));
        private IWebElement address => driver.FindElement(By.Name("address"));
        private IWebElement city => driver.FindElement(By.Name("city"));
        private IWebElement state => driver.FindElement(By.Name("state"));
        private IWebElement zip => driver.FindElement(By.Name("zip"));
        private IWebElement website => driver.FindElement(By.Name("website"));
        private IWebElement hosting => driver.FindElement(By.Name("hosting"));
        private IWebElement comment => driver.FindElement(By.Name("comment"));
        private IWebElement sendButton => driver.FindElement(By.CssSelector(".btn"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/input-form-demo.html";
            driver.Navigate().GoToUrl(testUrl);
        }

        [Test]
        public void FillForm()
        {
            firstname.SendKeys("Vesturas");
            lastname.SendKeys("Stanevicius");
            email.SendKeys("email@email.com");
            phone.SendKeys("+370 123 123 123");
            address.SendKeys("Gatve g.");
            city.SendKeys("Kaunas");
            new SelectElement(state).SelectByIndex(5);
            zip.SendKeys("LT-1213");
            website.SendKeys("www.website.com");
            hosting.Click();
            comment.SendKeys("Komentaras, komentaras.");
            sendButton.Click();
            Thread.Sleep(1000);

            Assert.AreEqual("", firstname.Text);
            Assert.AreEqual("", lastname.Text);
            Assert.AreEqual("", email.Text);
            Assert.AreEqual("", phone.Text);
            Assert.AreEqual("", address.Text);
            Assert.AreEqual("", city.Text);
            Assert.AreEqual("", zip.Text);
            Assert.AreEqual("", website.Text);
            Assert.AreEqual("", comment.Text);

        }
    }
}
