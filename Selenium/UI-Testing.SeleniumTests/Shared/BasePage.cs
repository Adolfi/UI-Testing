using OpenQA.Selenium;

namespace UI_Testing.SeleniumTests.Shared
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;
        public readonly string URI;

        protected BasePage(IWebDriver driver, string uri)
        {
            this.driver = driver;
            this.URI = uri;
        }

        public void Navigate() => this.driver.Navigate().GoToUrl(this.URI);
    }
}
