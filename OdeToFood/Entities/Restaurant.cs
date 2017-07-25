using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None, 
        Italian,
        Japanese,
        American
    }

    public class Restaurant
    {
        public int Id { get; set; }
        
        [Display(Name="Restaurant name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}