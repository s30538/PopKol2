using Microsoft.EntityFrameworkCore;
using PopKol2.Data;
using PopKol2.DTOs;
using PopKol2.Models;

namespace PopKol2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<GetCharacterDto> GetCharakter(int Id)
    {
        var character = await _context.Characters
            .Where(c => c.CharacterId == Id)
            .Select(e => new GetCharacterDto
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                CurrentWeight = e.CurrentWeight,
                MaxWeight = e.MaxWeight,
                BackpacksDtos = e.Backpacks.Select(p => new BackpackItemsDto()
                {
                    ItemName = p.Item.Name,
                    ItemWeight = p.Item.Weight,
                    Amount = p.Amount

                }).ToList(),
                TitlesDtos = e.CharacterTitles.Select(t => new TitlesDto()
                {
                    Title = t.Title.Name,
                    AquiredAt = t.AcquiredAt
                }).ToList(),
            }).FirstOrDefaultAsync();
        if (character == null)
        {
            throw new Exception("No character found");
        }
        return character;
    }

    public async Task AddCharacter(int characterId, AddBackapckDto dto)
    {
        
    }
}