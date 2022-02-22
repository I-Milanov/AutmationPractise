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
        public void FacebookLink()
        {//To Do
            //string actualResult;
            
            //_basePage.ScrollTo(_basePage.FollowUsFacebook).Click();
            //Driver.SwitchTo().ActiveElement();
            //actualResult = Driver.Title;

            //Assert.AreEqual("Selenium Framework | Facebook", actualResult);
        }

        //To Do



        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
