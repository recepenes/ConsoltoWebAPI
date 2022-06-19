using ConsoletoWebAPI.Models;

namespace ConsoletoWebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<ProductModel> products = new List<ProductModel>();

        public int AddProduct(ProductModel product)
        {
            product.ProductId += products.Count + 1;

            products.Add(product);

            return product.ProductId;
        }

        public List<ProductModel> GetAllProducts()
        {
            return products;
        }

        public string GetName()
        {
            return "Name From ProductRepository";
        }
    }
}
