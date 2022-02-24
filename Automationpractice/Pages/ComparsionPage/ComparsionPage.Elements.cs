using OpenQA.Selenium;
using System.Collections.Generic;

namespace Automationpractice.Pages.ComparsionPage
{
    public partial class ComparsionPage : ProductsPage.ProductsPage
    {
        public ComparsionPage(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement TweeterButton => Driver.FindElement(By.CssSelector("btn-twitter"));
        public IWebElement FacebookButton => Driver.FindElement(By.CssSelector("btn-twitter"));
        public IWebElement GoogleButton => Driver.FindElement(By.CssSelector("btn-google-plus"));
        public IWebElement PinterestButton => Driver.FindElement(By.CssSelector("btn-pinterest"));
        public IWebElement ContShoppingButton => Driver.FindElement(By.CssSelector(".footer_link .btn-default"));
        public IReadOnlyCollection<IWebElement> ProductsToCompare => Driver.FindElements(By.CssSelector(".product-block"));


    }
}
