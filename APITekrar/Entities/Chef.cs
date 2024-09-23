namespace APITekrar.Entities
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
    }
}
