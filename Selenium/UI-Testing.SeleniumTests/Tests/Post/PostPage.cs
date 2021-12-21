using OpenQA.Selenium;
using System;
using UI_Testing.SeleniumTests.Shared;

namespace UI_Testing.SeleniumTests.Tests.Post
{
    public class PostPage : BasePage
    {
        public PostPage(IWebDriver driver, string uri) : base(driver, uri) { }

        public string GetHeading()
        {
            return this.driver.FindElement(By.ClassName("post-title")).Text;
        }

        public IWebElement GetTags()
        {
            return this.driver.FindElement(By.ClassName("tags"));
        }
    }
}
