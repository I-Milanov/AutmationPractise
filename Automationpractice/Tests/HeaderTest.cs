namespace Automationpractice
{
    using Automationpractice.Pages;
    using Automationpractice.Tests;
    using NUnit.Framework;

    [TestFixture]

    public class HeaderTest : BaseTest
    {
        private BasePage basePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com");
            basePage = new BasePage(Driver);
        }

        [Test]
        public void WomenNavigatorLink()
        {
            basePage.NavWomen.Click();

            Assert.AreEqual("Women - My Store", basePage.Driver.Title);
        }

        [Test]
        public void DressesNavigatorLink()
        {
            basePage.NavDresses.Click();

            Assert.AreEqual("Dresses - My Store", basePage.Driver.Title);
        }

        [Test]
        public void TshirtNavigatorLink()
        {
            basePage.NavTshirts.Click();

            Assert.AreEqual("T-shirts - My Store", basePage.Driver.Title);
        }

        [Test]
        public void ContactUsHeaderLink()
        {
            basePage.ContactUsLink.Click();

            Assert.AreEqual("Contact us - My Store", basePage.Driver.Title);
        }

        [Test]
        public void LogoLink()
        {
            ContactUsHeaderLink();
            basePage.Logo.Click();

            Assert.AreEqual("My Store", basePage.Driver.Title);
        }

        // To Do
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}