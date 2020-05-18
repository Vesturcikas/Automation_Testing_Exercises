using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

namespace NUnitTest_Selenium.Tests
{
    public static class MyDriver
    {
        public static IWebDriver InitDriver(Browser browser)
        {
            IWebDriver driver = null;
            switch (browser)
            {
                case Browser.Chrome: driver = new ChromeDriver(GetChromeOptions()); break;
                case Browser.Edge: driver = new EdgeDriver(); break;
                default: Assert.Fail("We don't have this browser!"); break;
            }

            //Setting up the Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return driver;
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("incognito");
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            return chromeOptions;
        }

    }

    public enum Browser
    {
        Chrome,
        Edge
    }
}
