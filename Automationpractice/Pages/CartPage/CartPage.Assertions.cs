using Automationpractice.Models;
using NUnit.Framework;

namespace Automationpractice.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public void AssertProductInCartIsCorrect(int productNumber, Product productToExpexted)
        {
            //Name
            Assert.AreEqual(productToExpexted.Name, TakeNameFromProductInCart(productNumber));

            //Qantity
            Assert.AreEqual(productToExpexted.Quantity.ToString(), TakeQantityFromProductInCart(productNumber));

            //Size
            Assert.AreEqual(productToExpexted.Size, TakeSizeFromProductInCart(productNumber));

            //Color
            Assert.AreEqual(productToExpexted.Color, TakeColorFromProductInCart(productNumber));
        }

    }
}
