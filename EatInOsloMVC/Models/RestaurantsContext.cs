using Microsoft.EntityFrameworkCore;

namespace RestaurantsMVC.Models {
    public class RestaurantsContext:DbContext
    {
        public RestaurantsContext(DbContextOptions<RestaurantsContext> options):base(options){}
        
        public DbSet<RestaurantsMVC.Models.Restaurants> Restaurants { get; set; }
        
    }
}