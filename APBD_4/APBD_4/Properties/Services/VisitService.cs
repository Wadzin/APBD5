using APBD_4.Properties.Model;
using APBD_4.Properties.Repositories;

namespace APBD_4.Properties.Services;

public class VisitService : IVisitService
{
    private IVisitRepository _visitRepository;
    private IAnimalRepository _animalRepository;


    public VisitService(IVisitRepository visitRepository, IAnimalRepository animalRepository)
    {
        _visitRepository = visitRepository;
        _animalRepository = animalRepository;
    }

    public bool AddVisit(Visit visit)
    {
        if (_animalRepository.getAnimal(visit.Animal.Id) == null)
        {
            return false;
        }
        _visitRepository.AddVisit(visit);
        
        return true;
    }

    public IEnumerable<Visit> GetVisitsByAnimal(int id)
    {
        var animal = _animalRepository.getAnimal(id);
        if (animal == null)
        {
            return Enumerable.Empty<Visit>();
        }
        return _visitRepository.GetVisitsByAnimal(animal);
    }
}