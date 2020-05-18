using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NUnitTest_Selenium.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string baseUrl;        

        [SetUp]
        public void BeforeEveryTests()
        {
            driver = MyDriver.InitDriver(Browser.Chrome);            
            baseUrl = "https://www.seleniumeasy.com/test";             
        }

        [TearDown]
        public void AfterEveryTests()
        {
            driver.Quit();
        }
    }
}
