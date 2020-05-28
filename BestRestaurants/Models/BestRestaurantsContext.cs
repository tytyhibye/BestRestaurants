using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext // inherits/extends from Entity's DbContext for built in functionality
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; } // needs to know which C# object it's going to represent <Restaurant>

    public BestRestaurantsContext(DbContextOptions options) : base(options) { } // using Startup.cs options via "dependency injection"
  }
}