using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace NUnitTest_Selenium.Tests.Date_Pickers
{
    public class Bootstrap_Date_Pickers : BaseTest
    {
        private IWebElement dateInput => driver.FindElement(By.CssSelector(".date > input"));
        private IWebElement datePicker => driver.FindElement(By.CssSelector(".datepicker"));
        private IWebElement buttonToday => datePicker.FindElement(By.CssSelector(".today"));
        private IWebElement buttonClear => datePicker.FindElement(By.CssSelector(".clear"));
        private IWebElement inputDateRange => driver.FindElement(By.CssSelector(".input-daterange"));
        private IWebElement startDateInput => inputDateRange.FindElement(By.CssSelector("[placeholder='Start date']"));
        private IWebElement endDateInput => inputDateRange.FindElement(By.CssSelector("[placeholder='End date']"));
        private IWebElement dayDatePicker => datePicker.FindElement(By.CssSelector(".datepicker-days"));
        private IWebElement monthDatePicker => datePicker.FindElement(By.CssSelector(".datepicker-months"));
        private IWebElement yearDatePicker => datePicker.FindElement(By.CssSelector(".datepicker-years"));
        private IWebElement decadDatePicker => datePicker.FindElement(By.CssSelector(".datepicker-decades"));
        private IWebElement centurieDatePicker => datePicker.FindElement(By.CssSelector(".datepicker-centuries"));

        [SetUp]
        public void BeforeTests()
        {
            string testUrl = baseUrl + "/bootstrap-date-picker-demo.html";
            driver.Navigate().GoToUrl(testUrl);
        }

        /// <summary>
        /// 
        /// Click on 'Today' to select Current date
        ///Click on Clear button to clear the date entered
        ///
        /// </summary>
        [Test]
        public void DateExample()
        {
            string dateTodayString = DateTime.Today.ToString("dd/MM/yyyy");

            dateInput.Click();            
            buttonToday.Click();

            Assert.AreEqual(dateTodayString, dateInput.GetAttribute("value"));

            dateInput.Click();
            buttonClear.Click();

            Assert.AreEqual("", dateInput.Text);
        }

        /// <summary>
        /// 
        /// Selected Date will be displayed in both fields. Ex: Selected Start date will be pre-populated in end date
        ///Start date should be less than end date
        /// 
        /// </summary>
        [Test]
        public void DateRangeExample()
        {
            int dayToday = DateTime.Today.Day;
            int monthToday = DateTime.Today.Month;
            int yearToday = DateTime.Today.Year;
            int dayStart = dayToday + 5;
            int monthStart = monthToday + 3;
            int yearStart = yearToday +2;
            int dayEnd = dayStart + 3;
            int monthEnd = monthStart + 1;
            int yearEnd = yearStart + 1;

            string startDate = DateConverter(dayStart, monthStart, yearStart);
            startDateInput.SendKeys(startDate);

            string endDate = DateConverter(dayEnd, monthEnd, yearEnd);
            endDateInput.SendKeys(endDate);
        }

        [TearDown]
        public void AfterTests()
        {

        }

        public static string DateConverter(int day, int month, int year)
        {
            string dateConverted = null;
            string dayC = null;
            string monthC = null;

            if (day < 10)
            {
                dayC = "0" + day.ToString();
            }
            else
            {
                dayC = day.ToString();
            }

            if (month < 10)
            {
                monthC = "0" + month.ToString();
            }
            else
            {
                monthC = month.ToString();
            }

            return dateConverted = dayC + "/" + monthC + "/" + year.ToString();
        }
    }
}
