namespace WebApplication1.DTOs;
using System.ComponentModel.DataAnnotations;

public class TitlesDTO
{
    [Key]
    public string Title { get; set; }
    public DateTime AcquiredAt { get; set; }
}