using OpenQA.Selenium;

namespace Automationpractice.Pages.ProductsPage
{
    public partial class ProductsPage : BasePage
    {


        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SortBy => Driver.FindElement(By.Id("selectProductSort"));
        public IWebElement CompareItemsNumber => Driver.FindElement(By.CssSelector(".total-compare-val"));
        public IWebElement CompareButtonTop => Driver.FindElement(By.CssSelector(".top-pagination-content .bt_compare"));

    }
}



