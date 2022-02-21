using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Automationpractice.Pages.ProductsPage
{
    public class ProductsPage : BasePage
    {


        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }


        public IWebElement SortBy => Driver.FindElement(By.Id("selectProductSort"));




        public float[] TakeEveryProductsPrices()
        {
            var prices = Driver.FindElements(By.CssSelector(".product_list  .right-block .price"));
            float[] pricesfloat = new float[prices.Count];
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.CurrencyDecimalSeparator = ".";

            for (int i = 0; i < prices.Count; i++)
            {
                pricesfloat[i] = float.Parse(prices[i].Text.ToString().Substring(1, 5), NumberStyles.Any, ci);
                ;
            }
            return pricesfloat;
        }

        public bool IsHighToLow(float[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsLowToHigh(float[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] > prices[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public void AddToCart(int itemNumber)
        {
            var productToHover = Driver.FindElement(By.CssSelector($".right-block:nth-child({itemNumber})"));
            HoverOverAnElement(productToHover);
            var addToCartButton = Driver.FindElement(By.CssSelector($".right-block:nth-child({itemNumber}) .button"));
            addToCartButton.Click();
            WaitForLoad();
            var closebutton = Driver.FindElement(By.CssSelector(".cross"));
            closebutton.Click();
        }



        private void HoverOverAnElement(IWebElement element)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();

        }


    }
}



