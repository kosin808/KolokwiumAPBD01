using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Title
{
    [Key]
    public int TitleId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<CharacterTitle> CharacterTitles { get; set; } = null!;
}