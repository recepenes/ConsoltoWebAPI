using ConsoletoWebAPI.Models;

namespace ConsoletoWebAPI.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
        string GetName();
    }
}