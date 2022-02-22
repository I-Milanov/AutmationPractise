﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationpractice.Pages.Quick__View
{
    public partial class QuickView:BasePage
    {
        public QuickView(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement TweeterButton => Driver.FindElement(By.CssSelector(".btn-twitter"));
        public IWebElement FacebookButton => Driver.FindElement(By.CssSelector(".btn-facebook"));
        public IWebElement GoogleButton => Driver.FindElement(By.CssSelector(".btn-google-plus"));
        public IWebElement PinterestButton => Driver.FindElement(By.CssSelector(".btn-pinterest"));

        public IWebElement ProductName => Driver.FindElement(By.XPath("//*[@id='product']//h1[@itemprop='name']"));
        public IWebElement ProductReference => Driver.FindElement(By.XPath("//*[@id='product']//*[@id='product_reference']"));

        public IWebElement QuantityField => Driver.FindElement(By.XPath("//*[@id='product']//*[@id='quantity_wanted']"));

        public IWebElement QuantityMinusButton => Driver.FindElement(By.CssSelector("#product .button-minus"));

        public IWebElement QuantityPlusButton => Driver.FindElement(By.CssSelector("#product .button-plus"));
        public IWebElement ProductSize => Driver.FindElement(By.CssSelector("#product #group_1"));

        public IWebElement AddToCart => Driver.FindElement(By.CssSelector("#product .exclusive"));

        public IWebElement AddToWishList => Driver.FindElement(By.CssSelector("#product #wishlist_button"));

        public IReadOnlyCollection<IWebElement> Colors => Driver.FindElements(By.CssSelector("#product .color_pick"));


    
    }
}
