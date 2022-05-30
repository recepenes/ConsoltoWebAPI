using ConsoletoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalsModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalsModel>()
            {
                new AnimalsModel() {Id=1, Name="Wolf"},
                new AnimalsModel() {Id=2, Name="Lion"}
            };
        }

        [Route("", Name = "All"),]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }
        [Route("Accepted")]
        public IActionResult GetAnimalsAccepted()
        {
            return Accepted("~/api/animals");
        }
        [Route("AcceptedAtAction")]
        public IActionResult GetAnimalsAcceptedAtAction()
        {
            return AcceptedAtAction("GetAnimals");
        }
        [Route("AcceptedAtRoute")]
        public IActionResult GetAnimalsAcceptedAtRoute()
        {
            return AcceptedAtRoute("All");
        }
        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC")) return BadRequest();

            return Ok(animals);

        }
    }
}
