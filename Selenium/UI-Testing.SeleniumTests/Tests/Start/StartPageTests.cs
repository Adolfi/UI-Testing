using NUnit.Framework;
using UI_Testing.SeleniumTests.Shared;

namespace UI_Testing.SeleniumTests.Tests.Start
{
    public class PostPageTests : BaseTest
    {
        public StartPage startPage;

        [Test]
        public void Given_NavigateToStartPage_Then_AssertStartPageLocation()
        {
            // Given
            this.startPage = new StartPage(this.driver, "https://adolfi.dev/");

            // When
            this.startPage.Navigate();

            // Then
            this.AssertLocation(this.startPage.URI);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void Given_StartPageHasPost_When_ClickOnPost_Then_ExpectPostLocation(int index)
        {
            // Given
            this.startPage = new StartPage(this.driver, "https://adolfi.dev/");
            this.startPage.Navigate();
            var post = this.startPage.GetPost(index);

            // When
            this.startPage.ClickPost(index);

            // Then
            this.AssertLocation(post.URI);
        }

        [Test]
        [TestCase("UMBRACO")]
        [TestCase("UNIT TESTING")]
        [TestCase(".NET")]
        public void Given_StartPageHasTags_When_ClickOnTag_Then_ExpectTagLocation(string tagName)
        {
            // Given
            this.startPage = new StartPage(this.driver, "https://adolfi.dev/");
            this.startPage.Navigate();
            var tag = this.startPage.GetTag(tagName);

            // When
            this.startPage.ClickTag(tagName);

            // Then
            this.AssertLocation(tag.URI);
        }
    }
}