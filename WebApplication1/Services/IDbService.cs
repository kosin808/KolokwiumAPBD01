using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IDbService
{
    Task<Character> GetCharactersDTO(int Id);
    Task AddNewItem(int id, AddItemDTO dto);
}