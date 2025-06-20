using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;
public class DatabaseContext : DbContext
{
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }
    
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
            new Item() {ItemId = 1,Weight = 10,Name = "Item 1"},
            new Item() {ItemId = 2,Weight = 11,Name = "Item 2"},
            new Item() {ItemId = 3,Weight = 12,Name = "Item 3"}

        });
        
        modelBuilder.Entity<Title>().HasData(new List<Title>()
        {
            new Title() {TitleId = 1,Name = "Title1"},
            
            new Title() {TitleId = 2,Name = "Title2"},
        });
        
        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>()
        {
            new Backpack() { CharacterId = 1, ItemId = 1, Amount = 2},
            new Backpack() {  CharacterId = 1, ItemId = 2, Amount = 2},
            new Backpack() {  CharacterId = 1, ItemId = 3, Amount = 2},
        });
        
        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character() { CharacterId = 1, FirstName = "Johm", LastName = "Yakuza",CurrentWeight = 43,MaxWeight = 200},
        });
        
        modelBuilder.Entity<CharacterTitle>().HasData(
            new CharacterTitle(){ CharacterId = 1,TitleId = 1,AcquiredAt = new DateTime(2024-06-10)},
            new CharacterTitle(){ CharacterId = 2,TitleId = 2,AcquiredAt = new DateTime(2024-06-09)},
            new CharacterTitle(){ CharacterId =3 ,TitleId = 3,AcquiredAt = new DateTime(2024-06-08)}
        );
    }
}