using Automationpractice.Pages.CartPage;
using Automationpractice.Pages.QuickView;
using NUnit.Framework;

namespace Automationpractice.Tests
{
    [TestFixture]
    public class CartTests : BaseTest
    {

        private QuickView _quickView;
        private CartPage _cartPage;
        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            _quickView = new QuickView(Driver);
            _cartPage = new CartPage(Driver);
        }

        [Test]
        [TestCase(1, 3)]
        public void ChangeQuantityFromQuickViewAndAddToCartAssert(int productNumber, int quant)
        {
            _quickView.OpenProductQuickView(productNumber);
            _quickView.QuantityField.Clear();
            _quickView.QuantityField.SendKeys(quant.ToString());
            _quickView.AddToCartQuickView.Click();
            Driver.SwitchTo().DefaultContent();
            _quickView.ProceedToCheckout.Click();
            string expectedResult = quant.ToString();
            string actualResult = _cartPage.TakeQantityFromProductInCart(1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(2, 'L')]
        public void ChangeSizeFromQuickViewAndAddToCartAssert(int productNumber, char size)
        {
            _quickView.OpenProductQuickView(productNumber);
            _quickView.ProductSize.SendKeys(size.ToString());
            _quickView.AddToCartQuickView.Click();
            Driver.SwitchTo().DefaultContent();
            _quickView.ProceedToCheckout.Click();
            string actualResult = _cartPage.TakeSizeFromProductInCart(1);
            Assert.AreEqual(size.ToString(), actualResult);
        }

        [Test]
        [TestCase(3, 3)]
        public void ChangeColorFromQuickViewAndAddToCartAssert(int productNumber, int colorNumber)
        {
            _quickView.OpenProductQuickView(productNumber);
            string expectedResult = _quickView.SelectColorAndReturnItsName(colorNumber);
            _quickView.AddToCartQuickView.Click();
            Driver.SwitchTo().DefaultContent();
            _quickView.ProceedToCheckout.Click();
            string actualColor= _cartPage.TakeColorFromProductInCart(1);
            Assert.AreEqual(expectedResult, actualColor);
        }

        [Test]
        [TestCase(3, 3, 'M', 2)]
        public void ChangeEverythingFromQuickViewAddToCartAssert(int productNumber, int quant, char size, int colorNumber)
        {
            string expectedName = _quickView.TakeNameAsString(productNumber);
            _quickView.OpenProductQuickView(productNumber);           
            _quickView.QuantityField.Clear();
            _quickView.QuantityField.SendKeys(quant.ToString());
            _quickView.ProductSize.SendKeys(size.ToString());
            string expectedColor = _quickView.SelectColorAndReturnItsName(colorNumber);       
            _quickView.AddToCartQuickView.Click();
            Driver.SwitchTo().DefaultContent();
            _quickView.ProceedToCheckout.Click();

            //Name
            string actualName = _cartPage.TakeNameFromProductInCart(1);
            Assert.AreEqual(expectedName, actualName);

            //Qantity
            string actualQuant = _cartPage.TakeQantityFromProductInCart(1);
            Assert.AreEqual(quant.ToString(), actualQuant);

            //Size
            string actualSize = _cartPage.TakeSizeFromProductInCart(1);
            Assert.AreEqual(size.ToString(), actualSize);

            //Color
            string actualColor = _cartPage.TakeColorFromProductInCart(1);
            Assert.AreEqual(expectedColor, actualColor);
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
