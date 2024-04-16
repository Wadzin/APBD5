using APBD_4.Properties.Model;

namespace APBD_4.Properties.Services;

public interface IVisitService
{
    bool AddVisit(Visit visit);
    IEnumerable<Visit> GetVisitsByAnimal(int id);
}