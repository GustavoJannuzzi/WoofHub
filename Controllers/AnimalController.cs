using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WoofHub_App.Data;
using WoofHub_App.Data.DTOs;
using WoofHub_App.Models;

namespace WoofHub_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private WoofHubContext _context;
        private IMapper _mapper;

        public AnimalController(WoofHubContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddAnimal(
            [FromBody] AnimalDTO animalDto)
        {
            AnimalModel animal = _mapper.Map<AnimalModel>(animalDto);
            _context.Animals.Add(animal);
            _context.SaveChanges();
            return CreatedAtAction(nameof(SearchAnimalId),
                new { id = animal.Id },
                animal);
        }

        [HttpGet]
        public IEnumerable<AnimalModel> ShowAllAnimals()
        {
            return _context.Animals;
        }

        [HttpGet("{id}")]
        public IActionResult SearchAnimalId(int id)
        {
            var animal = _context.Animals.FirstOrDefault(animal => animal.Id == id);
            if (animal == null)
                return NotFound();

            return Ok(animal);
        }

        [HttpGet("Search")]
        public IActionResult SearchAnimalName([FromQuery] string AnimalName)
        {
            var matchingAnimals = _context.Animals.Where(animal => animal.AnimalName == AnimalName).ToList();
            if (!matchingAnimals.Any())
                return NotFound();

            return Ok(matchingAnimals);
        }
    }
}