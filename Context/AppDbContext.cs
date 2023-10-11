using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;

namespace StudentsApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
        new Student
        {
            Id = 1,
            Name = "Maria da Penha",
            Email = "mariapenha@gmail.com",
            Age = 23,
        },
        new Student
        {
            Id = 2,
            Name = "Manuel Bueno",
            Email = "manuelbueno@gmail.com",
            Age = 24,
        }
            );
    }
}