using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>(); // Hashset is an unordered collection of unique elements (more performant than a List but doesnt allow duplicates)
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; } // generic interface - collection of method signatures bundled together.
                                                                     // ICollection required by Entity to outline methods for querying and changing data.
  }
  public enum CuisineName
  {
    Mexican,
    Italian,
    Szechuan,
    Cantonese,
    Thai,
    Indian,
    French,
    American,
    Mediterranean,
    Japanese,
    Ethiopian

  }
}