using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.Currency)]
        public double Price { get;  set; }
        public int? SerialNumberId { get; set; }
        public SerialNumber? SerialNumber { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        public List<ItemClient>? ItemClients { get; set; }
    }
}
