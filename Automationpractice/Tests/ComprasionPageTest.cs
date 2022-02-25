using NUnit.Framework;
using Automationpractice.Pages.ComparsionPage;


namespace Automationpractice.Tests
{
    [TestFixture]
    public class ComprasionPageTest : BaseTest
    {
        private ComparsionPage _comparsionPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            _comparsionPage = new ComparsionPage(Driver);
        }





        //here the idea was to use int[] in TestCase but as i fount nunit can't take it
        [Test]
        [TestCase("2,3,4")]
        public void ComprasionPageProductsAssert(string productsToCompareString)
        {
            string[] productsToCompareStringAsString = productsToCompareString.Split(',');
            int[] arrayOfProducts = new int[productsToCompareStringAsString.Length];
            for (int i = 0; i < arrayOfProducts.Length; i++)
            {
                arrayOfProducts[i] = int.Parse(productsToCompareStringAsString[i]);
            }

            _comparsionPage.AssertProductsToCompare(arrayOfProducts);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
