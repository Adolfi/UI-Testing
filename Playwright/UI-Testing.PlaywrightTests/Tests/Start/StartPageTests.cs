using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace UI_Testing.PlaywrightTests.Tests.Start
{
    public class StartPageTests : PageTest
    {
        [Test]
        public async Task Given_NavigateToStartPage_Then_AssertStartPageLocation()
        {
            // When
            await Page.GotoAsync("https://adolfi.dev/");

            // Then
            Assert.AreEqual("https://adolfi.dev/", Page.Url);
        }

        [Test]
        [TestCase("UMBRACO PROJECT STRUCTURE", "https://adolfi.dev/blog/umbraco-project-structure/")]
        [TestCase("I'M A MICROSOFT MVP 2022!", "https://adolfi.dev/blog/microsoft-mvp/")]
        [TestCase("GET STARTED WITH UMBRACO 9", "https://adolfi.dev/blog/get-started-with-umbraco-9/")]
        public async Task Given_StartPageHasPost_When_ClickOnPost_Then_ExpectPostLocation(string heading, string expectedLocation)
        {
            // Given
            await Page.GotoAsync("https://adolfi.dev/");

            // When
            await Page.ClickAsync($"text={heading}");

            // Then
            Assert.AreEqual(expectedLocation, Page.Url);
        }

        [Test]
        [TestCase("UMBRACO", "https://adolfi.dev/tags/umbraco")]
        [TestCase("UNIT TESTING", "https://adolfi.dev/tags/unit%20testing")]
        [TestCase(".NET", "https://adolfi.dev/tags/-net")]
        public async Task Given_StartPageHasTags_When_ClickOnTag_Then_ExpectTagLocation(string tagName, string expectedLocation)
        {
            // Given
            await Page.GotoAsync("https://adolfi.dev/");

            // When
            await Page.ClickAsync($"text={tagName}");

            // Then
            Assert.AreEqual(expectedLocation, Page.Url);
        }
    }
}
