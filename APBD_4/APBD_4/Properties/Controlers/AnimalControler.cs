using APBD_4.Properties.Model;
using APBD_4.Properties.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_4.Properties.Controlers;

[Route("api/[controller]")]
[ApiController]
public class AnimalControler : ControllerBase
{
    private IAnimalService _animalService;


    public AnimalControler(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.getAnimals();
        return Ok(animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = _animalService.GetAnimal(id);
        if (animal == null)
        {
            return NotFound("Animal not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animalService.AddAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var result = _animalService.DeleteAnimal(id);
        if (result)
        {
            return NoContent();
        }

        return NotFound("Animal not found");
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var result = _animalService.UpdateAnimal(id, animal);
        if (result)
        {
            return NoContent();
        }
        
        return NotFound("Animal not found");
    }
}