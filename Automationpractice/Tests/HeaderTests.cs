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
        public void WomenNavigatorLink()
        {
            _basePage.NavWomen.Click();

            Assert.AreEqual("Women - My Store",_basePage.Driver.Title);           
        }

        [Test]
        public void DressesNavigatorLink()
        {
            _basePage.NavDresses.Click();

            Assert.AreEqual("Dresses - My Store", _basePage.Driver.Title);
        }

        [Test]
        public void TshirtNavigatorLink()
        {
            _basePage.NavTshirts.Click();

            Assert.AreEqual("T-shirts - My Store", _basePage.Driver.Title);
        }

        [Test]
        public void ContactUsHeaderLink()
        {
            _basePage.ContactUsLink.Click();

            Assert.AreEqual("Contact us - My Store", _basePage.Driver.Title);
        }

        [Test]
        public void LogoLink()
        {
            ContactUsHeaderLink();
            _basePage.Logo.Click();

            Assert.AreEqual("My Store", _basePage.Driver.Title);
        }


        //To Do
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}