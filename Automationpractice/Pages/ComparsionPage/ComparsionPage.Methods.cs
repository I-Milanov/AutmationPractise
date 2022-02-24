using OpenQA.Selenium;
using Automationpractice.Models.ProductPreview;
using System.Collections.Generic;

namespace Automationpractice.Pages.ComparsionPage
{
    public partial class ComparsionPage : ProductsPage.ProductsPage
    {

        public bool ComparsionScreenVerification(int[] arrayOfProducts)
        {

            int counter = arrayOfProducts.Length;
            ProductPreview[] productsFromProdutPage = new ProductPreview[arrayOfProducts.Length];

            for (int i = 0; i < arrayOfProducts.Length; i++)
            {
                ProductPreview tempProduct = new ProductPreview();
                tempProduct.Name = TakeNameAsString(arrayOfProducts[i]);
                tempProduct.Price = TakeProductPriceAsString(arrayOfProducts[i]);
                productsFromProdutPage[i] = tempProduct;
                AddToCompare(arrayOfProducts[i]);
            }
            CompareButtonTop.Click();

            if (!ComprasionPageProductsCountVerify(arrayOfProducts.Length))
            {
                return false;
            }

            IReadOnlyCollection<IWebElement> productsToCompare = ProductsToCompare;
            ProductPreview[] productsFromComparePage = new ProductPreview[productsToCompare.Count];

            for (int i = 0; i < productsToCompare.Count; i++)
            {
                ProductPreview tempProduct = new ProductPreview();
                tempProduct.Name = TakeProductNameFromComprassionScreen(i);
                tempProduct.Price = TakeProductPriceFromComprassionScreen(i);
                productsFromComparePage[i] = tempProduct;
            }

            for (int i = 0; i < productsFromProdutPage.Length; i++)
            {
                for (int j = 0; j < productsFromComparePage.Length; j++)
                {
                    if (productsFromProdutPage[i].Name== productsFromComparePage[j].Name&&
                        productsFromProdutPage[i].Price == productsFromComparePage[j].Price)
                    {
                        counter--;
                    }
                }
            }


            return counter == 0 ? true : false;
        }
        public bool ComprasionPageProductsCountVerify(int productsThatMustBe)
        {
            return ProductsToCompare.Count == productsThatMustBe ? true : false;
        }
        public string TakeProductNameFromComprassionScreen(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"#product_comparison .product-block:nth-of-type({productNumber + 2}) .product-name")).Text;
        }
        public string TakeProductPriceFromComprassionScreen(int productNumber)
        {
            return Driver.FindElement(By.CssSelector($"#product_comparison .product-block:nth-of-type({productNumber + 2}) .product-price")).Text;
        }



    }
}
