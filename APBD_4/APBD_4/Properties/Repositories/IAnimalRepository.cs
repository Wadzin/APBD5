using APBD_4.Properties.Model;

namespace APBD_4.Properties.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> findAll();
    Animal? getAnimal(int id);
    void AddAnimal(Animal animal);

    bool DeleteAnimal(int id);
    bool UpdateAnimal(int id, Animal animal);
}