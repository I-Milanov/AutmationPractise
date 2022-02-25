using NUnit.Framework;

namespace Automationpractice.Pages.ProductsPage
{
    public partial class ProductsPage : BasePage
    {
        public void AssertSortByPriceHighestFirst()
        {
            Assert.IsTrue(IsHighToLow(TakeEveryProductsPrices()));
        }
        public void AssertThatProductIsAddToCart(string beforeInCart)
        {
            beforeInCart = IfStringIsEmptyReplaceWith0(beforeInCart);
            Assert.AreEqual(int.Parse(beforeInCart) + 1,int.Parse(CartQuantity.Text));
        }

        public void AssertThatProductIsAddToCompare(string beforeInCompare)
        {
            beforeInCompare= IfStringIsEmptyReplaceWith0(beforeInCompare);

            Assert.AreEqual(int.Parse(beforeInCompare) + 1, int.Parse(CompareItemsNumber.Text));
        }


        public void AssertQuickViewIsOpen()
        {
            Assert.That(IsQuickViewOpen);
        }

}
}



