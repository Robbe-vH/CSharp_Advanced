using System.Collections.Generic;

namespace ClassLibOvererving.Products
{
    internal class Basket
    {
        List<Product> products;
        int total = 0;
        public void AddProduct(Product selectedProduct)
        {
            products.Add(selectedProduct);
        }

        public void ClearBasket()
        {
            products.Clear();
            total = 0;
        }

        public int TotalPrice()
        {
            
            foreach (Product product in products)
            {
                total += product.Prijs;
            }
            return total;
        }
    }
}
