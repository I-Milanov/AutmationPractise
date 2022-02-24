using OpenQA.Selenium;

namespace Automationpractice.Pages.QuickView
{
    public partial class QuickView : ProductsPage.ProductsPage
    {
        public void FillTheData(int quant, char size, int colorNumber)
        {
            QuantityField.SendKeys(quant.ToString());
            ProductSize.SendKeys(size.ToString());
            IWebElement color = SelectColor(colorNumber);
            color.Click();
        }
        public IWebElement SelectColor(int colorNumber)
        {
            IWebElement color = Driver.FindElement(By.CssSelector($"#product .color_pick:nth-child({colorNumber})"));
            return color;
        }
        public bool IsQuickViewOpen()
        {
            return Driver.FindElement(By.Id("product")).Displayed;
        }

    }
}
