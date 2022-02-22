using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationpractice.Pages.Quick__View
{
    public partial class QuickView : BasePage
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

            IWebElement color = Driver.FindElement(By.CssSelector
    ("# product .color_pick:nth-child({colorNumber}"));
            return color;
        }

    }
}
