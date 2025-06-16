using Microsoft.EntityFrameworkCore;
using PopKol2.Models;

namespace PopKol2.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character> Characters  { get; set; }
    public DbSet<CharacterTitle> CharacterTitles  { get; set; }
    public DbSet<Item> Items  { get; set; }
    public DbSet<Title> Titles  { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(new List<Item>()
        {
            new Item() {ItemId = 1, Name= "abcd",Weight = 10},
  
        });
        modelBuilder.Entity<Title>().HasData(new List<Title>()
        {
            new Title() {TitleId = 1,Name = "abc"},
            
        });
        modelBuilder.Entity<Character>().HasData(new List<Character>()
        {
            new Character() {CharacterId = 1,FirstName = "Jan",LastName = "Kwiatek", CurrentWeight = 10, MaxWeight = 10},   
        });
        modelBuilder.Entity<CharacterTitle>().HasData(new List<CharacterTitle>()
        {
            new CharacterTitle() {CharacterId = 1,TitleId = 1,AcquiredAt = DateTime.Now},
        });
        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>()
        {
            new Backpack() {CharacterId = 1, ItemId = 1,Amount = 1},
            
        });
    }
}