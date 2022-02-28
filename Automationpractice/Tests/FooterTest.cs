namespace Automationpractice
{
    using Automationpractice.Pages;
    using Automationpractice.Tests;
    using NUnit.Framework;

    [TestFixture]
    public class FooterTest : BaseTest
    {
        private BasePage basePage;

        [SetUp]
        public void Setup()
        {
            Initialize();

            Driver.Navigate().GoToUrl("http://automationpractice.com");
            basePage = new BasePage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
