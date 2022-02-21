using Automationpractice.Pages;
using Automationpractice.Pages.ProductsPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AssertSortByPriceHighestFirst()
        {
            _productPage.SortBy.SendKeys("Price: Highest first");
            _productPage.WaitForLoad();
            Assert.IsTrue(_productPage.IsHighToLow(_productPage.TakeEveryProductsPrices()));

        }

        [Test]
        public void AssertAddProductToCart()
        {            
            _productPage.AddToCart(2);
            
            string actualResult = _productPage.CartQuantity.Text;
            Assert.AreEqual("1", actualResult);
        }



        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}

