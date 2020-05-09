using OpenQA.Selenium;

namespace NUnitTest_Selenium.Pages.Alerts_Modals_Pages
{
    public class Window_Popup_Modals_Page : BasePage
    {
        private IWebElement twitterFollowButton => driver.FindElement(By.CssSelector("a[title='Follow @seleniumeasy on Twitter']"));
        private IWebElement facebookLikeButton => driver.FindElement(By.CssSelector("a[title='Follow @seleniumeasy on Facebook']"));
        private IWebElement twitterAndFacebookFollowButton => driver.FindElement(By.CssSelector("a[title='Follow @seleniumeasy']"));
        private IWebElement followAllButton => driver.FindElement(By.CssSelector("a[id='followall']"));

        public Window_Popup_Modals_Page(IWebDriver driver) : base(driver) { }

        public Window_Popup_Modals_Page TwitterFollowButtonClick()
        {
            twitterFollowButton.Click();
            return this;
        }

        public Window_Popup_Modals_Page FacebookLikeButtonClick()
        {
            facebookLikeButton.Click();
            return this;
        }

        public Window_Popup_Modals_Page FollowAllButtonClick()
        {
            followAllButton.Click();
            return this;
        }

        public void SwitchToWindow(string winUrl, string originWindow)
        {
            foreach (var item in driver.WindowHandles)
            {
                if (item !=originWindow)
                {
                    driver.SwitchTo().Window(item);
                    if (driver.Url == winUrl) break;
                    else driver.SwitchTo().Window(originWindow);
                }
            }        
        }
    }
}
