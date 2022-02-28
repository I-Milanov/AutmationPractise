namespace Automationpractice.Pages.CartPage
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public partial class CartPage
    {
        public IReadOnlyCollection<IWebElement> ProductsInCart => Driver.FindElements(By.CssSelector("#cart_summary tbody tr"));

        public string TakeSizeFromProductInCart(int productNumber)
        {
            return SeparateColorAndSize(productNumber)[1];
        }

        public string TakeColorFromProductInCart(int productNumber)
        {
            return SeparateColorAndSize(productNumber)[0];
        }

        public string DeleteProductInCart(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_quantity_delete")).Text;
        }

        public string IncreaseByOneProductQantity(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .button-plus")).Text;
        }

        public string DecreaseByOneProductQantity(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .button-minus")).Text;
        }

        private string[] SeparateColorAndSize(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_description small a")).Text.Replace("Color : ", string.Empty).Replace(", Size :", string.Empty).Split(' ');
        }
    }
}
