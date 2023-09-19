using Microsoft.AspNetCore.Mvc;
using WoofHub_App.Models;

namespace WoofHub_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private static List<AnimalModel> animals = new List<AnimalModel>();
        private static int id = 0;

        [HttpPost]
        public IActionResult AddAnimal([FromBody] AnimalModel animal)
        {
            animal.Id = id++;
            animals.Add(animal);

            return CreatedAtAction(nameof(SearchAnimalId),
                new { id = animal.Id },
                animal);
        }

        [HttpGet]
        public IEnumerable<AnimalModel> ShowAllAnimals()
        {
            return animals;
        }

        [HttpGet("{id}")]
        public IActionResult SearchAnimalId(int id)
        {
            var animal = animals.FirstOrDefault(animal => animal.Id == id);
            if (animal == null)
                return NotFound();

            return Ok(animal);
        }

        [HttpGet("Search")]
        public IActionResult SearchAnimalName([FromQuery] string AnimalName)
        {
            var matchingAnimals = animals.Where(animal => animal.AnimalName == AnimalName).ToList();
            if (!matchingAnimals.Any())
                return NotFound();

            return Ok(matchingAnimals);
        }
    }
}