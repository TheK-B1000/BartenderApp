using Microsoft.EntityFrameworkCore;

namespace BartenderApp.Models
{
    public class DrinksDb : DbContext
    {
        public DrinksDb(DbContextOptions<DrinksDb> options) : base(options) { }
        public DbSet<Cocktail> Cocktails { get; set;}
        public DbSet<Order> Orders { get; set;} 
    }
}
