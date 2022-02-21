using Automationpractice.Pages;
using Automationpractice.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
