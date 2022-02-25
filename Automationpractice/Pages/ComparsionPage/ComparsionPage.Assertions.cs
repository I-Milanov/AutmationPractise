using NUnit.Framework;

namespace Automationpractice.Pages.ComparsionPage
{
    public partial class ComparsionPage : ProductsPage.ProductsPage
    {
        public void AssertProductsToCompare(int[] arrayOfProducts)
        {
            Assert.That(ComparsionScreenVerification(arrayOfProducts));
        }

    }
}
