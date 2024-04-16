using APBD_4.Properties.Model;

namespace APBD_4.Properties.Repositories;

public class VisitRepository : IVisitRepository
{
    public List<Visit> Visits { get; set; } = new List<Visit>();
    public void AddVisit(Visit visit)
    {
        Visits.Add(visit);
    }

    public IEnumerable<Visit> GetVisitsByAnimal(Animal animal)
    {
        return Visits.Where(v => v.Animal == animal);
    }
}