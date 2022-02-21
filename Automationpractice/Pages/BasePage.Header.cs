using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        


        //To Do Take elements when hover 

    }
}
