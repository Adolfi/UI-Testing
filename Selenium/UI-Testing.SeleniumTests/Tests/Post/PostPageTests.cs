using NUnit.Framework;
using UI_Testing.SeleniumTests.Shared;

namespace UI_Testing.SeleniumTests.Tests.Post
{
    public class PostPageTests : BaseTest
    {
        public PostPage postPage;

        [Test]
        public void When_NavigateToPostPage_Then_AssertPostPageLocation()
        {
            // Given
            this.postPage = new PostPage(this.driver, "https://adolfi.dev/blog/site-variables-in-umbraco-9/");

            // When
            this.postPage.Navigate();

            // Then
            this.AssertLocation(this.postPage.URI);
        }

        [Test]
        [TestCase("https://adolfi.dev/blog/site-variables-in-umbraco-9/", "SITE VARIABLES IN UMBRACO 9")]
        [TestCase("https://adolfi.dev/blog/get-started-with-umbraco-9/", "GET STARTED WITH UMBRACO 9")]
        public void Given_NavigateToPostPage_When_GetHeading_Then_AssertExpectedHeading(string uri, string expected)
        {
            // Given
            this.postPage = new PostPage(this.driver, uri);
            this.postPage.Navigate();

            // When
            var actual = this.postPage.GetHeading();

            // Then
            Assert.AreEqual(expected, actual);
        }

        [Test]        
        [TestCase("https://adolfi.dev/blog/microsoft-mvp//", "TAGS: MICROSOFT, MVP")]
        [TestCase("https://adolfi.dev/blog/get-started-with-umbraco-9/", "TAGS: UMBRACO")]
        public void Given_NavigateToPostPage_When_GetTags_Then_AssertExpectedTags(string uri, string expected)
        {
            // Given
            this.postPage = new PostPage(this.driver, uri);
            this.postPage.Navigate();

            // When
            var actual = this.postPage.GetTags()?.Text;

            // Then
            Assert.AreEqual(expected, actual);
        }
    }
}