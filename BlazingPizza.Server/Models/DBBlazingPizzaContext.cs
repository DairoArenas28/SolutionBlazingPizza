using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Models
{
    public class DBBlazingPizzaContext : DbContext
    {
        public DBBlazingPizzaContext(DbContextOptions<DBBlazingPizzaContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Pizza> Pizza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
