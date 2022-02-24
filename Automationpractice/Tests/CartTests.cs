using Automationpractice.Pages.CartPage;
using Automationpractice.Pages.QuickView;
using NUnit.Framework;
using OpenQA.Selenium;

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
        [TestCase(1, 'L')]
        public void ChangeSizeFromQuickViewAndAddToCartAssert(int productNumber, char size)
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


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
