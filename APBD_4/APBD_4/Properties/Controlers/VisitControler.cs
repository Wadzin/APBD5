using APBD_4.Properties.Model;
using APBD_4.Properties.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_4.Properties.Controlers;

[Route("api/[controller]")]
[ApiController]
public class VisitControler : ControllerBase
{
    private IVisitService _visitService;

    public VisitControler(IVisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        var result = _visitService.AddVisit(visit);
        if (result)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        return NotFound("Animal not found");
    }

    [HttpGet("{animalId:int}")]
    public IActionResult GetVisits(int animalId)
    {
        var visits = _visitService.GetVisitsByAnimal(animalId);
        return Ok(visits);
    }
}