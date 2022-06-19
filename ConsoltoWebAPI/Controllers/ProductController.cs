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

        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _productRepository2;

        public ProductController(IProductRepository productRepository,
            IProductRepository productRepository2)
        {
            _productRepository = productRepository;
            _productRepository2 = productRepository2;
        }

        [HttpPost("")]

        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productRepository.AddProduct(product);

            var products = _productRepository2.GetAllProducts();

            return Ok(products);
        }
        [HttpGet("")]

        public IActionResult GetName()
        {
            var name = _productRepository.GetName();

            return Ok(name);
        }
    }
}
