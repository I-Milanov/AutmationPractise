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
            Assert.IsTrue(_productPage.IsHighToLow(_productPage.TakeEveryProductsPrices()));

        }

        [Test]
        public void AddProductToCart()
        {            
            _productPage.AddToCart(2);
            
            string actualResult = _productPage.CartQuantity.Text;
            Assert.AreEqual("1", actualResult);
        }

        [Test]
        public void AddToCompare()
        {
            _productPage.AddToCompare(1);

            Assert.AreEqual("1", _productPage.CompareItemsNumber.Text);
        }




        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}

