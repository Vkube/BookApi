using Microsoft.EntityFrameworkCore;
namespace ApiControllers.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Book> Books {get; set;} = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();   
    }
 protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
                new Book { Id =  Guid.NewGuid().ToString(), Author = "Shildt", Title = "C# 4.0 : полное руководство", Date= new DateTime(2020,02,30) },
                new Book { Id = Guid.NewGuid().ToString(), Author = "Richter" , Title= "CLR via C# Программирование на платформе Micrisoft .Net Framework 4.5", Date = new DateTime(2022,01,01) },
                new Book { Id = Guid.NewGuid().ToString(), Author = "Shildt" , Title= "Java, full documentation ", Date = new DateTime(2020,04,31) },
                new Book { Id = Guid.NewGuid().ToString(), Author = "Freeman " , Title= "Entity Framework Core 2 for Asp.net ", Date = new DateTime(2019,02,31) },
                new Book { Id = Guid.NewGuid().ToString(), Author = "Freeman " , Title= "Asp. Net Core 3 with example for professional", Date = new DateTime(2022,01,01) }
        );

    }
    
    }
}