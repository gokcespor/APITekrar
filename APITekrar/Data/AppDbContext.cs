using APITekrar.Entities;
using Microsoft.EntityFrameworkCore;

namespace APITekrar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) 
        {
            
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Chef> Chefs { get; set; }
    }
}
