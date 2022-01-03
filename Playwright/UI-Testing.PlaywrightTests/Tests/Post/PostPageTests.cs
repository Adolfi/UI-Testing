using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace UI_Testing.PlaywrightTests.Tests.Post
{
    public class PostPageTests : PageTest
    {
        [Test]
        public async Task When_NavigateToPostPage_Then_AssertPostPageLocation()
        {
            // When
            await Page.GotoAsync("https://adolfi.dev/blog/site-variables-in-umbraco-9/");

            // Then
            Assert.AreEqual("https://adolfi.dev/blog/site-variables-in-umbraco-9/", Page.Url);
        }

        [Test]
        [TestCase("https://adolfi.dev/blog/site-variables-in-umbraco-9/", "Site Variables in Umbraco 9")]
        [TestCase("https://adolfi.dev/blog/get-started-with-umbraco-9/", "Get started with Umbraco 9")]
        public async Task Given_NavigateToPostPage_When_GetHeading_Then_AssertExpectedHeading(string uri, string expected)
        {
            // Given
            await Page.GotoAsync(uri);

            // When
            var element = await Page.QuerySelectorAsync(".post-title");
            var title = await element.TextContentAsync();

            // Then
            Assert.AreEqual(expected, title);
        }

        [Test]
        [TestCase("https://adolfi.dev/blog/microsoft-mvp//", "TAGS: MICROSOFT, MVP")]
        [TestCase("https://adolfi.dev/blog/get-started-with-umbraco-9/", "TAGS: UMBRACO")]
        public async Task Given_NavigateToPostPage_When_GetTags_Then_AssertExpectedTags(string uri, string expected)
        {
            // Given
            await Page.GotoAsync(uri);

            // When
            var element = await Page.QuerySelectorAsync(".tags");
            var tags = await element.InnerTextAsync();

            // Then
            Assert.AreEqual(expected, tags);
        }
    }
}
