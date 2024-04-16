using System.Security.Cryptography;
using APBD_4.Properties.Model;

namespace APBD_4.Properties.Repositories;

public class AnimalRepository : IAnimalRepository
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public IEnumerable<Animal> GetAnimals()
    {
        return Animals;
    }

    public IEnumerable<Animal> findAll()
    {
        throw new NotImplementedException();
    }

    public Animal? getAnimal(int id)
    {
        return Animals.Find(a => a.Id == id);
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public bool DeleteAnimal(int id)
    {
        var animal = getAnimal(id);
        if (animal == null)
        {
            return false;
        }
        return Animals.Remove(animal);
    }

    public bool UpdateAnimal(int id, Animal animal)
    {
        var foundedAnimal = getAnimal(id);
        if (foundedAnimal == null)
        {
            return false;
        }
        
        foundedAnimal.Name = animal.Name;
        foundedAnimal.Category = animal.Category;
        foundedAnimal.Weight = animal.Weight;
        foundedAnimal.Color = animal.Color;

        return true;
    }
}