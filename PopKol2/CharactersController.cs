using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopKol2.DTOs;
using PopKol2.Services;

namespace PopKol2
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly IDbService _dbService;
    
        public CharactersController(IDbService dbService)
        {
            _dbService = dbService;
        }
    
        [HttpGet("characters/{id}")]
        public async Task<IActionResult> GetRacersParticipations(int id)
        {
            var character = await _dbService.GetCharakter(id);
            return Ok(character);
        }
        
        [HttpPut("{charakterId}/backpacks")]
        public async Task<IActionResult> AddCharacter(int charakterId, AddBackapckDto dto)
        {
                await _dbService.AddCharacter(charakterId, dto);
                return Ok();
        }
    }
}
