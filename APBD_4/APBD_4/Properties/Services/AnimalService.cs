using APBD_4.Properties.Model;
using APBD_4.Properties.Repositories;

namespace APBD_4.Properties.Services;

public class AnimalService : IAnimalService
{
    private IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> getAnimals()
    {
        return _animalRepository.findAll();
    }

    public Animal? GetAnimal(int id)
    {
        return _animalRepository.getAnimal(id);
    }

    public void AddAnimal(Animal animal)
    {
        _animalRepository.AddAnimal(animal);
    }

    public bool DeleteAnimal(int id)
    {
        return _animalRepository.DeleteAnimal(id);
    }

    public bool UpdateAnimal(int id, Animal animal)
    {
        return _animalRepository.UpdateAnimal(id, animal);
    }
}