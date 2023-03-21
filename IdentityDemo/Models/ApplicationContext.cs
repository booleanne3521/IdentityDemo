using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IdentityDemo.Models
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
        base(options)
        {
        }
      

        // Exponerar våra databas-modeller via properties av typen DbSet<T> 
        public DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Specificerar vilken datatyp databasen ska använda för en specifik kkolumn
            modelBuilder.Entity<Order>()
                .Property(o => o.PriceTotal)
                .HasColumnType(SqlDbType.Money.ToString());
        }
    }

}

