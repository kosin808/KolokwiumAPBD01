using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Item
{
    [Key]
    public int ItemId { get; set; }
    [Required]
    [MaxLength(100)]
    public String Name { get; set; }
    public int Weight { get; set; }
    
    public ICollection<Backpack> Backpacks { get; set; }
}