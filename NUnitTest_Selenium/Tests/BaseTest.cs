using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace NUnitTest_Selenium.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string baseUrl;        

        [SetUp]
        public void BeforeEveryTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseUrl = "https://www.seleniumeasy.com/test";           
        }

        [TearDown]
        public void AfterEveryTests()
        {
            driver.Quit();
        }
    }
}
