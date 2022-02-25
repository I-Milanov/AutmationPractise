using NUnit.Framework;

namespace Automationpractice.Pages.QuickView
{
    public partial class QuickView : ProductsPage.ProductsPage
    {
     
        public void AssertQuickViewPrice(string price)
        {
            Assert.That(price == ProductPrice.Text);
        }
        public void AssertQuickViewName(string price)
        {
            Assert.That(price == ProductName.Text);
        }
    }
}
