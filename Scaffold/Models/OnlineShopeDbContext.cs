using Microsoft.EntityFrameworkCore;

namespace Scaffold.Models
{
    public class OnlineShopeDbContext:DbContext
    {
        public OnlineShopeDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product>? Product { get; set; }
        public DbSet<Person>? Person { get; set; }
    }
}
