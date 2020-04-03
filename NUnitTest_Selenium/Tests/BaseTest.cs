using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Interactions;

namespace NUnitTest_Selenium.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string baseUrl;
        protected Actions act;

        [SetUp]
        public void BeforeEveryTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseUrl = "https://www.seleniumeasy.com/test";

            act = new Actions(driver);
        }

        [TearDown]
        public void AfterEveryTests()
        {
            driver.Quit();
        }
    }
}
