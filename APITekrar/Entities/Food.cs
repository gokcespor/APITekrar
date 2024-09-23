namespace APITekrar.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreperationTime { get; set; }
        public Chef Chef { get; set; }
        public int ChefId { get; set; }
    }
}
