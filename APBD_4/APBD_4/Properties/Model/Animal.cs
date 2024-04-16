using System.ComponentModel.DataAnnotations;

namespace APBD_4.Properties.Model;

public class Animal
{
    public int Id;
    [Required]
    public string Name;
    [Required]
    public string Category;
    [Required]
    public double Weight;
    [Required]
    public string Color;
}