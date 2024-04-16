using APBD_4.Properties.Model;

namespace APBD_4.Properties.Repositories;

public interface IVisitRepository
{
    void AddVisit(Visit visit);
    IEnumerable<Visit> GetVisitsByAnimal(Animal id);
}