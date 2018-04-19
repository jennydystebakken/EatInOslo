namespace RestaurantsMVC.Models {
    public class Restaurants {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public bool OpenNow { get; set; }
    }
}