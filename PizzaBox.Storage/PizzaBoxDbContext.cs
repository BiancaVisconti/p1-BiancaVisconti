using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Crust> Crust { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Topping> Topping { get; set; }

    public PizzaBoxDbContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder) {}


    // protected override void OnConfiguring(DbContextOptionsBuilder builder)
    // {
    //   builder.UseSqlServer("server=localhost;database=PizzaBoxDb;user id=sa;password=Password12345");
    // } 
  }
}