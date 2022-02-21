using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Automationpractice.Pages.ProductsPage
{
    public partial class ProductsPage : BasePage
    {


        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }


        public IWebElement SortBy => Driver.FindElement(By.Id("selectProductSort"));

        public IWebElement CompareItemsNumber => Driver.FindElement(By.Id("selectProductSort"));



    }
}



