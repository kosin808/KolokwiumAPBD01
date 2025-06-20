namespace WebApplication1.DTOs;

public class AddItemDTO
{
    private List<Item> items { get; set; } = null!;
}

public class Item
{
    public int ItemId { get; set; }
}
