using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automationpractice.Pages
{
     public partial class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public IWebDriver Driver { get; }
        public WebDriverWait Wait { get; }

        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
       


    }
}
