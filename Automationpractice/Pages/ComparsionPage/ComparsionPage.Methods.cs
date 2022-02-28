namespace Automationpractice.Pages.ComparsionPage
{
    using System.Collections.Generic;
    using Automationpractice.Models.ProductPreview;
    using OpenQA.Selenium;

    public partial class ComparsionPage : ProductsPage.ProductsPage
    {
        public bool ComparsionScreenVerification(int[] productIds)
        {
            int counter = productIds.Length;
            ProductPreview[] productsFromProdutPage = new ProductPreview[productIds.Length];

            for (int i = 0; i < productIds.Length; i++)
            {
                ProductPreview tempProduct = new ()
                {
                    Name = TakeNameAsString(productIds[i]),
                    Price = TakeProductPriceAsString(productIds[i]),
                };
                productsFromProdutPage[i] = tempProduct;
                AddToCompare(productIds[i]);
            }

            CompareButtonTop.Click();

            if (!ComprasionPageProductsCountVerify(productIds.Length))
            {
                return false;
            }

            IReadOnlyCollection<IWebElement> productsToCompare = ProductsToCompare;
            ProductPreview[] productsFromComparePage = new ProductPreview[productsToCompare.Count];

            for (int i = 0; i < productsToCompare.Count; i++)
            {
                ProductPreview tempProduct = new ()
                {
                    Name = TakeProductNameFromComprassionScreen(i),
                    Price = TakeProductPriceFromComprassionScreen(i),
                };
                productsFromComparePage[i] = tempProduct;
            }

            for (int i = 0; i < productsFromProdutPage.Length; i++)
            {
                for (int j = 0; j < productsFromComparePage.Length; j++)
                {
                    if (productsFromProdutPage[i].Name == productsFromComparePage[j].Name &&
                        productsFromProdutPage[i].Price == productsFromComparePage[j].Price)
                    {
                        counter--;
                    }
                }
            }

            return counter == 0;
        }

        public bool ComprasionPageProductsCountVerify(int productsThatMustBe)
        {
            return ProductsToCompare.Count == productsThatMustBe;
        }
    }
}
