using ConsoletoWebAPI.Models;
using ConsoletoWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpPost("")]

        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepository.AddProduct(product);

            var products = _productRepository.GetAllProducts();

            return Ok(products);
        }
    }
}
