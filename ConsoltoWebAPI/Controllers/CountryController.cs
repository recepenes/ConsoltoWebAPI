using ConsoletoWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [BindProperty]
        public CountryModel Country { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {Country.Name}, " +
                $"Population = {Country.Population}, Area = {Country.Area}");
        }
    }
}
