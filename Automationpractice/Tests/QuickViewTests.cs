using Automationpractice.Models.ProductPreview;
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

        [Test]
        [TestCase(2)]
        public void QuickViewPriceAssert(int productNumber)
        {
            _productPreview = new ProductPreview();
            _productPreview.Price = _quickViewPage.TakeProductPriceAsString(productNumber);

            _quickViewPage.OpenProductQuickView(productNumber);

            _quickViewPage.AssertQuickViewPrice(_quickViewPage.ProductPrice.Text);
        }

        [Test]
        [TestCase(1)]
        public void QuickViewNameAssert(int productNumber)
        {
            _productPreview = new ProductPreview();
            _productPreview.Name = _quickViewPage.TakeNameAsString(productNumber);

            _quickViewPage.OpenProductQuickView(productNumber);

            _quickViewPage.AssertQuickViewName(_quickViewPage.ProductName.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
