using OpenQA.Selenium;
using System.Collections.Generic;

namespace Automationpractice.Pages.CartPage
{
    public partial class CartPage
    {
        public IReadOnlyCollection<IWebElement> ProductsInCart => Driver.FindElements(By.CssSelector("#cart_summary tbody tr"));

        public string TakeNameFromProductInCart(IWebElement product)
        {
            return Driver.FindElement(By.CssSelector(".cart_description .product-name a")).Text;
        }

        public string TakeNameFromProductInCart(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_description .product-name a")).Text;
        }

        public string TakeUnitPriceFromProductInCart(IWebElement product)
        {
            return Driver.FindElement(By.CssSelector(".cart_unit .price .price")).Text;
        }

        public string TakeUnitPriceFromProductInCart(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_unit .price .price")).Text;
        }

        public string TakeTotalPriceFromProductInCart(IWebElement product)
        {
            return Driver.FindElement(By.CssSelector(".cart_total .price")).Text;
        }

        public string TakeTotalPriceFromProductInCart(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_total .price")).Text;
        }

        public string TakeQantityFromProductInCart(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_quantity .cart_quantity_input")).GetAttribute("value");
        }
        public string TakeSizeFromProductInCart(int productNumber)
        {
            return SeparateColorAndSize(productNumber)[1];
        }
        public string TakeColorFromProductInCart(int productNumber)
        {
            return SeparateColorAndSize(productNumber)[0];
        }
        private string[] SeparateColorAndSize(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_description small a")).Text.Replace("Color : ", "").Replace(", Size :", "").Split(' ');
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

    }
}
