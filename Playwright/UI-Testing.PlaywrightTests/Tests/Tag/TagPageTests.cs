using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace UI_Testing.PlaywrightTests.Tests.Tag
{
    public class TagPageTests : PageTest
    {
        [Test]
        public async Task Given_NavigateToUmbracoTags_Then_AssertLocation()
        {
            // When
            await Page.GotoAsync("https://adolfi.dev/tags/umbraco");

            // Then
            Assert.AreEqual("https://adolfi.dev/tags/umbraco", Page.Url);
        }

        [Test]
        public async Task Given_NavigateToUnitTestingTags_Then_AssertLocation()
        {
            // When
            await Page.GotoAsync("https://adolfi.dev/tags/unit%20testing");

            // Then
            Assert.AreEqual("https://adolfi.dev/tags/unit%20testing", Page.Url);
        }

        [Test]
        public async Task Given_NavigateToDotNetTags_Then_AssertLocation()
        {
            // When
            await Page.GotoAsync("https://adolfi.dev/tags/-net");

            // Then
            Assert.AreEqual("https://adolfi.dev/tags/-net", Page.Url);
        }
    }
}
