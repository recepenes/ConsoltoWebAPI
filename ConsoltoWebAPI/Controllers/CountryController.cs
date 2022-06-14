using ConsoletoWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[BindProperties(SupportsGet = true)]
    public class CountryController : ControllerBase
    {
        //[BindProperty]
        //public CountryModel Country { get; set; }

        //[HttpPost("")] Post is default
        //[HttpGet("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok($"Name = {Country.Name}, " +
        //        $"Population = {Country.Population}, Area = {Country.Area}");
        //}
        [HttpPost("")]
        public IActionResult AddCountry([FromQuery] CountryModel countryModel)
        {
            return Ok($"Name = {countryModel.Name}");
        }
    }
}
