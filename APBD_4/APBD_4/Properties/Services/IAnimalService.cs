using APBD_4.Properties.Model;

namespace APBD_4.Properties.Services;

public interface IAnimalService
{
    IEnumerable<Animal> getAnimals();
    Animal? GetAnimal(int id);
    void AddAnimal(Animal animal);

    bool DeleteAnimal(int id);
    bool UpdateAnimal(int id, Animal animal);
}