namespace Automationpractice.Tests
{
    using Automationpractice.Pages.ComparsionPage;
    using NUnit.Framework;

    [TestFixture]
    public class ComprasionPageTest : BaseTest
    {
        private ComparsionPage comparsionPage;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            comparsionPage = new ComparsionPage(Driver);
        }

        // here the idea was to use int[] in TestCase but as i fount nunit can't take it
        [Test]
        [TestCase("2,3,4")]
        public void ComprasionPageProductsAssert(string productsToCompareString)
        {
            string[] productsToCompareStringAsString = productsToCompareString.Split(',');
            int[] productIds = new int[productsToCompareStringAsString.Length];
            for (int i = 0; i < productIds.Length; i++)
            {
                productIds[i] = int.Parse(productsToCompareStringAsString[i]);
            }

            comparsionPage.AssertProductsToCompare(productIds);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
