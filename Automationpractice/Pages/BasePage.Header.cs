using OpenQA.Selenium;

namespace Automationpractice.Pages
{
    public partial class BasePage
    {
        public IWebElement SearchField => Driver.FindElement(By.Id("search_query_top"));
        public IWebElement SearchButton => Driver.FindElement(By.ClassName("button-search"));
        public IWebElement Logo => Driver.FindElement(By.ClassName("logo"));
        public IWebElement ContactUsLink => Driver.FindElement(By.Id("contact-link"));
        public IWebElement SingInLink => Driver.FindElement(By.ClassName("login"));
        public IWebElement CartField => Driver.FindElement(By.CssSelector(".shopping_cart>a"));
        public IWebElement NavWomen => Driver.FindElement(By.CssSelector("#block_top_menu>ul>li:nth-child(1)"));
        public IWebElement NavDresses => Driver.FindElement(By.CssSelector("#block_top_menu>ul>li:nth-child(2)"));
        public IWebElement NavTshirts => Driver.FindElement(By.CssSelector("#block_top_menu>ul>li:nth-child(3)"));
        public IWebElement CartQuantity => Driver.FindElement(By.CssSelector(".shopping_cart>a>span"));

        public IWebElement ProceedToCheckout => Driver.FindElement(By.CssSelector("#header .container .row #layer_cart .button-medium"));

        //To Do Take elements when hover 
    }
}
