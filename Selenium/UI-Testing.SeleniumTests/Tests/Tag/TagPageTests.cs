using NUnit.Framework;
using UI_Testing.SeleniumTests.Shared;

namespace UI_Testing.SeleniumTests.Tests.Tag
{
    public class TagPageTests : BaseTest
    {
        public TagPage tagPage;

        [Test]
        public void Given_NavigateToUmbracoTag_Then_AssertLocation()
        {
            // Given
            this.tagPage = new TagPage(this.driver, "https://adolfi.dev/tags/umbraco");

            // When
            this.tagPage.Navigate();

            // Then
            this.AssertLocation("https://adolfi.dev/tags/umbraco");
        }

        [Test]
        public void Given_NavigateToUnitTestingTag_Then_AssertLocation()
        {
            // Given
            this.tagPage = new TagPage(this.driver, "https://adolfi.dev/tags/unit%20testing");

            // When
            this.tagPage.Navigate();

            // Then
            this.AssertLocation("https://adolfi.dev/tags/unit%20testing");
        }

        [Test]
        public void Given_NavigateToDotNetTag_Then_AssertStartPageLocation()
        {
            // Given
            this.tagPage = new TagPage(this.driver, "https://adolfi.dev/tags/-net");

            // When
            this.tagPage.Navigate();

            // Then
            this.AssertLocation("https://adolfi.dev/tags/-net");
        }

    }
}