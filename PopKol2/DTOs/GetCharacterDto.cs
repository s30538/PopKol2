using PopKol2.Models;

namespace PopKol2.DTOs;

public class GetCharacterDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public List<BackpackItemsDto> BackpacksDtos { get; set; }
    public List<TitlesDto> TitlesDtos { get; set; }
    
}

public class BackpackItemsDto
{
    public string ItemName { get; set; }
    public int ItemWeight { get; set; }
    public int Amount { get; set; }
}

public class TitlesDto
{
    public string Title { get; set; }
    public DateTime AquiredAt { get; set; }
}
