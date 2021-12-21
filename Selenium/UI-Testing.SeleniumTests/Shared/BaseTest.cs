using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UI_Testing.SeleniumTests.Shared
{
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        protected virtual void Setup()
        {
            this.driver = new ChromeDriver();
        }

        public void AssertLocation(string uri) => Assert.AreEqual(uri, new Uri(this.driver.Url).GetLeftPart(UriPartial.Path));        

        [TearDown]
        protected virtual void TearDown()
        {
            this.driver.Quit();
            this.driver.Dispose();
        }
    }
}
