using Automationpractice.Pages;
using Automationpractice.Tests;
using NUnit.Framework;

namespace Automationpractice
{
    [TestFixture]

    public class HeaderTests: BaseTest
    {
        private BasePage _basePage;
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com");
            _basePage = new BasePage(Driver);
        }

        [Test]
        public void AssertWomenNavigatorLink()
        {
            _basePage.NavWomen.Click();

            Assert.AreEqual("Women - My Store",_basePage.Driver.Title);           
        }

        [Test]
        public void AssertDressesNavigatorLink()
        {
            _basePage.NavDresses.Click();

            Assert.AreEqual("Dresses - My Store", _basePage.Driver.Title);
        }

        [Test]
        public void AssertTshirtNavigatorLink()
        {
            _basePage.NavTshirts.Click();

            Assert.AreEqual("T-shirts - My Store", _basePage.Driver.Title);
        }

        [Test]
        public void AssertContactUsHeaderLink()
        {
            _basePage.ContactUsLink.Click();

            Assert.AreEqual("Contact us - My Store", _basePage.Driver.Title);
        }

        [Test]
        public void AssertLogoLink()
        {
            AssertContactUsHeaderLink();
            _basePage.Logo.Click();

            Assert.AreEqual("My Store", _basePage.Driver.Title);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}