namespace Automationpractice.Tests
{
    using Automationpractice.Models;
    using Automationpractice.Pages.CartPage;
    using Automationpractice.Pages.QuickView;
    using NUnit.Framework;

    [TestFixture]
    public class CartTests : BaseTest
    {
        private QuickView quickView;
        private CartPage cartPage;
        private Product product;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            quickView = new QuickView(Driver);
            cartPage = new CartPage(Driver);
            product = new Product();
        }

        [Test]
        [TestCase(1, 3)]
        public void ChangeQuantityFromQuickViewAndAddToCartAssert(int productNumber, int quant)
        {
            quickView.OpenProductQuickView(productNumber);
            quickView.QuantityField.Clear();
            quickView.QuantityField.SendKeys(quant.ToString());

            quickView.CreateProduct(product, string.Empty);
            quickView.GoToCart();

            cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [Test]
        [TestCase(2, "L")]
        public void ChangeSizeFromQuickViewAndAddToCartAssert(int productNumber, string size)
        {
            quickView.OpenProductQuickView(productNumber);
            quickView.SelectProductSize(size);

            quickView.CreateProduct(product, size);
            quickView.GoToCart();

            cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [Test]
        [TestCase(3, 3)]
        public void ChangeColorFromQuickViewAndAddToCartAssert(int productNumber, int colorNumber)
        {
            quickView.OpenProductQuickView(productNumber);
            quickView.SelectColorAndReturnItsName(colorNumber);

            quickView.CreateProduct(product, string.Empty);
            quickView.GoToCart();

            cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [Test]
        [TestCase(3, 3, "M", 2)]
        public void ChangeEverythingFromQuickViewAddToCartAssert(int productNumber, int quant, string size, int colorNumber)
        {
            quickView.OpenProductQuickView(productNumber);
            quickView.QuantityField.Clear();
            quickView.QuantityField.SendKeys(quant.ToString());
            quickView.SelectProductSize(size);
            quickView.SelectColorAndReturnItsName(colorNumber);

            quickView.CreateProduct(product, size);
            quickView.GoToCart();

            cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
