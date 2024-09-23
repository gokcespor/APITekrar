using APITekrar.Entities;
using System.Text.Json.Serialization;

namespace APITekrar.DTOs
{
    public class FoodDTO
    {
        public string Name { get; set; }
        public int PreperationTime { get; set; }
        public int ChefId { get; set; }
    }
}
