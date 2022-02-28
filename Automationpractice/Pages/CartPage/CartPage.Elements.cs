namespace Automationpractice.Pages.CartPage
{
    using OpenQA.Selenium;

    public partial class CartPage : BasePage
    {
        public CartPage(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement TotalPriceAndTax => Driver.FindElement(By.Id("total_price"));

        public IWebElement TotalTax => Driver.FindElement(By.Id("total_tax"));

        public IWebElement TotalPriceWithoutTax => Driver.FindElement(By.Id("total_price_without_tax"));

        public IWebElement TotalShippingPrice => Driver.FindElement(By.Id("total_shipping"));

        public IWebElement TotalGiftWrappingCost => Driver.FindElement(By.Id("total_wrapping"));

        public IWebElement TotalProductPrice => Driver.FindElement(By.Id("total_product"));

        public IWebElement TotalProducts => Driver.FindElement(By.Id("summary_products_quantity"));

        public IWebElement ContinueShoppingButton => Driver.FindElement(By.CssSelector(".cart_navigation .button-exclusive"));

        public IWebElement ProceeedToCheckOutButton => Driver.FindElement(By.CssSelector(".cart_navigation .standard-checkout"));

        public static string TakeTotalPriceFromProductInCart(IWebElement product) => product.FindElement(By.CssSelector(".cart_total .price")).Text;

        public static string TakeUnitPriceFromProductInCart(IWebElement product) => product.FindElement(By.CssSelector(".cart_unit .price .price")).Text;

        public string TakeUnitPriceFromProductInCart(int productNumber) => Driver.FindElement(
            By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_unit .price .price")).Text;

        public string TakeNameFromProductInCart(int productNumber) => Driver.FindElement(
            By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_description .product-name a")).Text;

        public string TakeTotalPriceFromProductInCart(int productNumber) => Driver.FindElement(
            By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_total .price")).Text;

        public string TakeQantityFromProductInCart(int productNumber) => Driver.FindElement(
            By.CssSelector($"tbody tr:nth-of-type({productNumber}) .cart_quantity .cart_quantity_input")).GetAttribute("value");
    }
}
