using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DTOs;
using WebApplication1.Exceptions;
using WebApplication1.Models;
using Item = WebApplication1.Models.Item;

namespace WebApplication1.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }
    public async Task<Character> GetCharactersDTO(int Id)
    {
        
        var characters = await _context.Characters
            .Where(e => e.CharacterId == Id)
            .Select(e => new Character()
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                CurrentWeight = e.CurrentWeight,
                MaxWeight = e.MaxWeight,
                BackpackItems = e.Backpacks.Select(bp => new GetItemDto
                {
                    ItemName = bp.Item.Name,
                    Amount = bp.Amount,
                    ItemWeight = bp.Item.Weight
                }).ToList(),
                Titles = e.CharacterTitles.Select(bp => new TitlesDTO()
                {
                    Title = bp.Title.Name,
                    AcquiredAt = bp.AcquiredAt,
                }).ToList(),
            }).FirstOrDefaultAsync(e => e.CharacterId == Id);
        if (characters==null)
        {
            throw new NotFoundException();
        }
        return characters;
    }

    public async Task AddNewItem(int id, AddItemDTO dto)
    {
        
    }
}