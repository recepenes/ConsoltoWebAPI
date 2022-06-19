using ConsoletoWebAPI.Models;
using ConsoletoWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel(){Id=1,Name="Employee 1"},
                new EmployeeModel(){Id=2,Name="Employee 2"}
            };
        }

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0) return NotFound();

            return Ok(new List<EmployeeModel>()
            {
                 new EmployeeModel(){Id=1,Name="Employee 1"},
                 new EmployeeModel(){Id=2,Name="Employee 3"}
            });
        }
        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeesBasicDetails(int id)
        {
            if (id == 0) return NotFound();

            return new EmployeeModel() { Id = 1, Name = "Employee 1" };
        }
        [HttpGet("")]
        public IActionResult GetName([FromServices] IProductRepository _productRepository)
        {
            var name = _productRepository.GetName();

            return Ok(name);
        }
    }
}
