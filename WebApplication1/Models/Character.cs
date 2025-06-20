using System.ComponentModel.DataAnnotations;
using WebApplication1.DTOs;

namespace WebApplication1.Models;

public class Character
{
    [Key]
    public int CharacterId { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(120)]
    public string LastName { get; set; }

    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    
    public ICollection<CharacterTitle> CharacterTitles { get; set; } = null!;
    public ICollection<Backpack> Backpacks { get; set; } = null!;
    public List<GetItemDto> BackpackItems { get; set; }
    public List<TitlesDTO> Titles { get; set; }
}