using Microsoft.EntityFrameworkCore;

namespace BartenderApp.Models
{
    public class DrinksDb : DbContext
    {
        public DbSet<Cocktail> Cocktails { get; set;}
        public DbSet<Order> Orders { get; set;} 
    }
}
