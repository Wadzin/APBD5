using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace APBD_4.Properties.Model;

public class Visit
{
    [Required]
    public DateTime VisitDate;
    [Required]
    public Animal Animal;
    [Required]
    public String Description;
    [Required]
    public double Price;
}