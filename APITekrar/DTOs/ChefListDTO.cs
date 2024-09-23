namespace APITekrar.DTOs
{
    public class ChefListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FoodDTO> Foods { get; set; }
    }
}
