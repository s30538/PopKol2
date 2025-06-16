using PopKol2.DTOs;

namespace PopKol2.Services;

public interface IDbService
{
    Task<GetCharacterDto> GetCharakter(int Id);
    Task AddCharacter(int characterId, AddBackapckDto dto);
}