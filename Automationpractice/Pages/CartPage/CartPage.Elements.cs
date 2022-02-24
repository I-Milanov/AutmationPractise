using OpenQA.Selenium;

namespace Automationpractice.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement totalPriceAndTax => Driver.FindElement(By.Id("total_price"));
        public IWebElement totalTax => Driver.FindElement(By.Id("total_tax"));
        public IWebElement totalPriceWithoutTax => Driver.FindElement(By.Id("total_price_without_tax"));
        public IWebElement totalShippingPrice => Driver.FindElement(By.Id("total_shipping"));
        public IWebElement totalGiftWrappingCost => Driver.FindElement(By.Id("total_wrapping"));
        public IWebElement totalProductPrice => Driver.FindElement(By.Id("total_product"));
        public IWebElement totalProducts => Driver.FindElement(By.Id("summary_products_quantity"));
        public IWebElement ContinueShoppingButton=> Driver.FindElement(By.CssSelector(".cart_navigation .button-exclusive"));
        public IWebElement ProceeedToCheckOutButton => Driver.FindElement(By.CssSelector(".cart_navigation .standard-checkout"));
        


    }
}
