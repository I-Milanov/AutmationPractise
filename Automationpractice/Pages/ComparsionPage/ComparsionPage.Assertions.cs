namespace Automationpractice.Pages.ComparsionPage
{
    using NUnit.Framework;

    public partial class ComparsionPage : ProductsPage.ProductsPage
    {
        public void AssertProductsToCompare(int[] productIds)
        {
            Assert.That(ComparsionScreenVerification(productIds));
        }
    }
}
