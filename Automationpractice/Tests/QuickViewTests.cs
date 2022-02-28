namespace Automationpractice.Tests
{
    using Automationpractice.Models.ProductPreview;
    using Automationpractice.Pages.QuickView;
    using NUnit.Framework;

    [TestFixture]

    public class QuickViewTests : BaseTest
    {
        private QuickView quickViewPage;
        private ProductPreview productPreview;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category=8&controller=category");
            quickViewPage = new QuickView(Driver);
        }

        [Test]
        [TestCase(2)]
        public void QuickViewPriceAssert(int productNumber)
        {
            productPreview = new ProductPreview
            {
                Price = quickViewPage.TakeProductPriceAsString(productNumber),
            };

            quickViewPage.OpenProductQuickView(productNumber);

            quickViewPage.AssertQuickViewPrice(quickViewPage.ProductPrice.Text);
        }

        [Test]
        [TestCase(1)]
        public void QuickViewNameAssert(int productNumber)
        {
            productPreview = new ProductPreview
            {
                Name = quickViewPage.TakeNameAsString(productNumber),
            };

            quickViewPage.OpenProductQuickView(productNumber);

            quickViewPage.AssertQuickViewName(quickViewPage.ProductName.Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
