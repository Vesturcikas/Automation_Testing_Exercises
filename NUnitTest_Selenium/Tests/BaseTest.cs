using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NUnitTest_Selenium.Tests
{
    class BaseTest
    {
        public IWebDriver driver;
        public string baseUrl;

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
