using Automationpractice.Pages.ProductsPage;
using NUnit.Framework;

namespace Automationpractice.Tests
{
    [TestFixture]
    public class ProductsPageTest : BaseTest
    {
        private ProductsPage _productPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            _productPage = new ProductsPage(Driver);
        }

        [Test]
        public void SortByPriceHighestFirst()
        {
            _productPage.SortBy.SendKeys("Price: Highest first");
            _productPage.AssertSortByPriceHighestFirst();            
        }

        [Test]
        [TestCase(2)]
        public void AddProductToCart(int productNumber)
        {

            string beforeProductsInCart = _productPage.CartQuantity.Text;

            _productPage.AddToCart(productNumber);

            _productPage.AssertThatProductIsAddToCart(beforeProductsInCart);
        }

        [Test]
        [TestCase(2)]
        public void AddToCompare(int productNumber)
        {
            string beforeProductsInCart = _productPage.CompareItemsNumber.Text;

            _productPage.AddToCompare(productNumber);

            _productPage.AssertThatProductIsAddToCompare(beforeProductsInCart);
        }

        [Test]
        [TestCase(3)]
        public void NavigateToQickView(int productNumber)
        {
            _productPage.OpenProductQuickView(productNumber);

            _productPage.AssertQuickViewIsOpen();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}


