using Microsoft.EntityFrameworkCore;
using Ecommerce.Shared.Entities;
namespace Ecommerce.Api.Data
{
    public class DataContext :DbContext
    { 
        public DataContext (DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<country> countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<country>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name","countryId").IsUnique();
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique();


        }

    }
}
