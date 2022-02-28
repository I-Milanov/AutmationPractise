namespace Automationpractice.Pages.ComparsionPage
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public partial class ComparsionPage : ProductsPage.ProductsPage
    {
        public ComparsionPage(IWebDriver driver)
            : base(driver)
        {
        }

        public IWebElement TweeterButton => WaitAndFindElement(By.CssSelector("btn-twitter"));

        public IWebElement FacebookButton => WaitAndFindElement(By.CssSelector("btn-twitter"));

        public IWebElement GoogleButton => WaitAndFindElement(By.CssSelector("btn-google-plus"));

        public IWebElement PinterestButton => WaitAndFindElement(By.CssSelector("btn-pinterest"));

        public IWebElement ContShoppingButton => WaitAndFindElement(By.CssSelector(".footer_link .btn-default"));

        public IReadOnlyCollection<IWebElement> ProductsToCompare => Driver.FindElements(By.CssSelector(".product-block"));

        public string TakeProductNameFromComprassionScreen(int productNumber) => Driver.FindElement(
            By.CssSelector($"#product_comparison .product-block:nth-of-type({productNumber + 2}) .product-name")).Text;

        public string TakeProductPriceFromComprassionScreen(int productNumber) => Driver.FindElement(
            By.CssSelector($"#product_comparison .product-block:nth-of-type({productNumber + 2}) .product-price")).Text;
    }
}
