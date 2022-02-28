namespace Automationpractice.Tests
{
    using Automationpractice.Pages.ProductsPage;
    using NUnit.Framework;
    using OpenQA.Selenium.Support.UI;

    [TestFixture]
    public class ProductsPageTest : BaseTest
    {
        private WebDriverWait webDiberWait;
        private ProductsPage productPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            productPage = new ProductsPage(Driver);
        }

        [Test]
        public void SortByPriceHighestFirst()
        {
            productPage.SortBy.SendKeys("Price: Highest first");
            productPage.AssertSortByPriceHighestFirst();
        }

        [Test]
        [TestCase(2)]
        public void AddProductToCart(int productNumber)
        {
            string beforeProductsInCart = productPage.CartQuantity.Text;

            productPage.AddToCart(productNumber);

            productPage.AssertThatProductIsAddToCart(beforeProductsInCart);
        }

        [Test]
        [TestCase(2)]
        public void AddToCompare(int productNumber)
        {
            string beforeProductsInCart = productPage.CompareItemsNumber.Text;

            productPage.AddToCompare(productNumber);

            productPage.AssertThatProductIsAddToCompare(beforeProductsInCart);
        }

        [Test]
        [TestCase(3)]
        public void NavigateToQickView(int productNumber)
        {
            productPage.OpenProductQuickView(productNumber);

            productPage.AssertQuickViewIsOpen();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}