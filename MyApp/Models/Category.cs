using System.ComponentModel.DataAnnotations;

namespace MyApp.Models;

public class Category
{
    public int Id { get; set; }
    [Required(ErrorMessage = "{0} required")]
    public string Name { get; set; } = null!;
    public List<Item>? Items { get; set; }
}
