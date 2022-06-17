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
        [HttpPost("{Name}/{Population}/{Area}")]
        public IActionResult AddCountry([FromRoute] CountryModel countryModel, [FromQuery] int id)
        {
            return Ok($"Name = {countryModel.Name} id={id}");
        }
        [HttpPut("{id}")]
        public IActionResult AddCountry([FromRoute] int id, [FromBody] CountryModel countryModel)
        {
            return Ok($"Name = {countryModel.Name} id={countryModel.Population}");
        }
    }
}
