using Microsoft.AspNetCore.Mvc;
using WebApplication1.Exceptions;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CharactersController : ControllerBase
{
    private readonly IDbService _dbService;

    public CharactersController(IDbService dbService)
    {
        _dbService = dbService;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCharacters(int id)
    {
        try
        {
            var characters = await _dbService.GetCharactersDTO(id);
            
            return Ok(characters);
        }
        catch (NotFoundException e)
        {
            return NotFound();
        }
    }

    [HttpPost("{id}/backpacks")]
    public async Task AddItemBackpack(int id, [FromBody] Character character)
    {
        
    }
}