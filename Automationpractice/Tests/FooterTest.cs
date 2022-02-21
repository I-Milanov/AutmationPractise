using Automationpractice.Pages;
using Automationpractice.Tests;
using NUnit.Framework;

namespace Automationpractice

{
    [TestFixture]
    public class FooterTest : BaseTest
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
        public void AssertFacebookLink()
        {
            _basePage.ScrollTo(_basePage.FollowUsFacebook).Click();
            Driver.SwitchTo().ActiveElement();
            Assert.AreEqual("https://www.facebook.com/groups/525066904174158/",_basePage.Driver.Url.ToString());
        }





        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
