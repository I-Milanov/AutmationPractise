using Automationpractice.Models;
using Automationpractice.Pages.CartPage;
using Automationpractice.Pages.QuickView;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Automationpractice.Tests
{
    [TestFixture]
    public class CartTests : BaseTest
    {

        private QuickView _quickView;
        private CartPage _cartPage;
        private Product product;
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            _quickView = new QuickView(Driver);
            _cartPage = new CartPage(Driver);
            product = new Product();

        }

        [Test]
        [TestCase(1, 3)]
        public void ChangeQuantityFromQuickViewAndAddToCartAssert(int productNumber, int quant)
        {
            _quickView.OpenProductQuickView(productNumber);
            _quickView.QuantityField.Clear();
            _quickView.QuantityField.SendKeys(quant.ToString());


            _quickView.CreateProduct(product,"");
            _quickView.GoToCart();

            _cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [Test]
        [TestCase(2, "L")]
        public void ChangeSizeFromQuickViewAndAddToCartAssert(int productNumber, string size)
        {
            _quickView.OpenProductQuickView(productNumber);
            _quickView.SelectProductSize(size);

            _quickView.CreateProduct(product,"");
            _quickView.GoToCart();

            _cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [Test]
        [TestCase(3, 3)]
        public void ChangeColorFromQuickViewAndAddToCartAssert(int productNumber, int colorNumber)
        {
            _quickView.OpenProductQuickView(productNumber);
            _quickView.SelectColorAndReturnItsName(colorNumber);

            _quickView.CreateProduct(product, "");
            _quickView.GoToCart();

            _cartPage.AssertProductInCartIsCorrect(1, product);
        }

        [Test]
        [TestCase(3, 3, "M", 2)]
        public void ChangeEverythingFromQuickViewAddToCartAssert(int productNumber, int quant, string size, int colorNumber)
        {
            _quickView.OpenProductQuickView(productNumber);             
            _quickView.QuantityField.Clear();
            _quickView.QuantityField.SendKeys(quant.ToString());
            _quickView.SelectProductSize(size);  
            _quickView.SelectColorAndReturnItsName(colorNumber);
            
            _quickView.CreateProduct(product, size);
            _quickView.GoToCart();

            _cartPage.AssertProductInCartIsCorrect(1, product);
        }

   
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
