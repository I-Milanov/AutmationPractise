using Automationpractice.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Automationpractice.Pages.QuickView
{
    public partial class QuickView : ProductsPage.ProductsPage
    {

        public IWebElement SelectColor(int colorNumber)
        {
            return Driver.FindElement(By.CssSelector($"#color_to_pick_list li:nth-of-type({colorNumber}) a"));
        }

        public bool IsQuickViewOpen()
        {
            return Driver.FindElement(By.Id("product")).Displayed;
        }

        public string SelectColorAndReturnItsName(int colorNumber)
        {
            string colorName = SelectColor(colorNumber).GetAttribute("name");
            SelectColor(colorNumber).Click();
            return colorName;
        }
        public void GoToCart()
        {
            AddToCartQuickView.Click();
            Driver.SwitchTo().DefaultContent();
            ProceedToCheckout.Click();
        }

        public void SelectProductSize(string size)
        {
            var selectElement = new SelectElement(ProductSize);
            selectElement.SelectByText(size);
        }

        public Product CreateProduct(Product product, string size)
        {
            product.Name = ProductName.Text;
            product.Price = ProductPrice.Text;

            //I could't find a way to take value that is set from dropdown;
            if (size != "")
                product.Size = size;
            else
                product.Size = "S";
            product.Color = SelectedColor.GetAttribute("title");
            product.Quantity = int.Parse(IfStringIsEmptyReplaceWith0(QuantityField.GetAttribute("value")));

            return product;
        }
    }
}
