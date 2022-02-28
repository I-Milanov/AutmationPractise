namespace Automationpractice.Pages.ProductsPage
{
    using OpenQA.Selenium;

    public partial class ProductsPage : BasePage
    {
        public ProductsPage(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement SortBy => Driver.FindElement(By.Id("selectProductSort"));

        public IWebElement CompareItemsNumber => Driver.FindElement(By.CssSelector(".total-compare-val"));

        public IWebElement CompareButtonTop => Driver.FindElement(By.CssSelector(".top-pagination-content .bt_compare"));

        public string TakeProductPriceAsString(int productNum)
        {
            string price = Driver.FindElement(By.CssSelector($".product_list>li:nth-child({productNum}) .right-block .content_price span")).Text;
            return price;
        }

        public string TakeNameAsString(int productNum)
        {
            string name = Driver.FindElement(By.CssSelector($".product_list>li:nth-child({productNum}) .right-block .product-name")).Text;
            return name;
        }
    }
}
