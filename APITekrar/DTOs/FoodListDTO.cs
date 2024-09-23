using APITekrar.Entities;

namespace APITekrar.DTOs
{
    public class FoodListDTO
    {
        public string Name { get; set; }
        public int PreperationTime { get; set; }
        public ChefDTO Chef { get; set; }
        public int ChefId { get; set; }
    }
}
