using OpenQA.Selenium;
using UI_Testing.SeleniumTests.Shared;
using UI_Testing.SeleniumTests.Tests.Post;
using UI_Testing.SeleniumTests.Tests.Tag;

namespace UI_Testing.SeleniumTests.Tests.Start
{
    public class StartPage : BasePage
    {
        public StartPage(IWebDriver driver, string uri) : base(driver, uri) { }

        public PostPage GetPost(int index)
        {
            var link = this.GetPostLink(index);
            var uri = link.GetAttribute("href");
            return new PostPage(this.driver, uri);
        }

        public void ClickPost(int index)
        {
            var link = this.GetPostLink(index);
            link.Click();
        }

        private IWebElement GetPostLink(int index)
        {
            var title = this.driver.FindElements(By.ClassName("post-title"))[index];
            return title.FindElement(By.TagName("a"));
        }

        internal TagPage GetTag(string tagName)
        {
            var link = GetTagLink(tagName);
            var uri = link.GetAttribute("href");
            return new TagPage(this.driver, uri);
        }

        private IWebElement GetTagLink(string tagName)
        {
            var description = this.driver.FindElement(By.ClassName("blog-description"));
            return description.FindElement(By.LinkText(tagName));
        }

        internal void ClickTag(string tagName)
        {
            var link = this.GetTagLink(tagName);
            link.Click();
        }
    }
}
