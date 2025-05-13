using Microsoft.EntityFrameworkCore;
using Ecommerce.Shared.Entities;
namespace Ecommerce.Api.Data
{
    public class DataContext :DbContext
    { 
        public DataContext (DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<country>().HasIndex(x => x.Name).IsUnique();

        }

    }
}
