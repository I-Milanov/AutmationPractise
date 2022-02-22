using Automationpractice.Pages.ProductPreview;
using Automationpractice.Pages.QuickView;
using NUnit.Framework;

namespace Automationpractice.Tests
{
    [TestFixture]

    public class QuickViewTests : BaseTest
    {
        private QuickView _quickViewPage;
        private ProductPreview _productPreview;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            _quickViewPage = new QuickView(Driver);
        }

        //[Test]
        //[TestCase(1)]
        //public void TweetButtonAssert(int productNumber)
        //{
        //    _quickViewPage.OpenProductQuickView(productNumber);
        //    _quickViewPage.TweeterButton.Click();
        //}

        [Test]
        [TestCase(1)]
        public void QuickViewPriceAssert(int productNumber)
        {
            _productPreview = new ProductPreview();
            _productPreview.Price = _quickViewPage.TakeProductPriceAsString(productNumber);
            _quickViewPage.OpenProductQuickView(productNumber);
            string quickViewPrice = _quickViewPage.ProductPrice.Text;
            Assert.That(_productPreview.Price == quickViewPrice);
        }

        [Test]
        [TestCase(1)]
        public void QuickViewNameAssert(int productNumber)
        {
            _productPreview = new ProductPreview();
            _productPreview.Name = _quickViewPage.TakeNameAsString(productNumber);
            _quickViewPage.OpenProductQuickView(productNumber);
            string quickViewName = _quickViewPage.ProductName.Text;
            Assert.That(_productPreview.Name == quickViewName);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
