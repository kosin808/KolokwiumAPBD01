using WebApplication1.Models;

namespace WebApplication1.DTOs;

public class GetCharactersDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<ItemDto> Items { get; set; } = null!;
    public ICollection<TitleDTO> Titles { get; set; } = null!;

}

public class ItemDto
{
    public string ItemName { get; set; }
    public int ItemWeight { get; set; }
    public int Amount { get; set; }
}

public class TitleDTO
{
    public string Title { get; set; }
    public DateTime AcquiredAt { get; set; }
}