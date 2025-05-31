using Microsoft.EntityFrameworkCore;
using MyBusiness_DB.Models;

namespace MyBusiness_DB
{
    public class BusinessContext : DbContext
    {
        public BusinessContext(DbContextOptions<BusinessContext> options) : base(options) {}
        
        public DbSet<Brand> Brands { get; set; }
        
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<ProductByOrder> ProductByOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand", "store");
            modelBuilder.Entity<Brand>().HasData(
                new Brand {BrandId = 1, BrandName = "Otro", BrandActive = true},
                new Brand {BrandId = 2, BrandName = "Bravo", BrandActive = true},
                new Brand {BrandId = 3, BrandName = "Dos coronas", BrandActive = true},
                new Brand {BrandId = 4, BrandName = "Gouda", BrandActive = true},
                new Brand {BrandId = 5, BrandName = "Vima", BrandActive = true});
                
            modelBuilder.Entity<UnitOfMeasurement>().ToTable("UnitOfMeasurement", "store");
            modelBuilder.Entity<UnitOfMeasurement>().HasData(
                new UnitOfMeasurement {UnitOfMeasurementId = 1, UnitOfMeasurementName = "Unidad", UnitOfMeasurementInitials = "U", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 2, UnitOfMeasurementName = "Kilogramo", UnitOfMeasurementInitials = "Kg", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 3, UnitOfMeasurementName = "Gramo", UnitOfMeasurementInitials = "g", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 4, UnitOfMeasurementName = "Libra", UnitOfMeasurementInitials = "Lb", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 5, UnitOfMeasurementName = "Metro", UnitOfMeasurementInitials = "m", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 6, UnitOfMeasurementName = "Centímetro", UnitOfMeasurementInitials = "cm", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 7, UnitOfMeasurementName = "Mililitro", UnitOfMeasurementInitials = "ml", UnitOfMeasurementActive = true},
                new UnitOfMeasurement {UnitOfMeasurementId = 8, UnitOfMeasurementName = "Litro", UnitOfMeasurementInitials = "L", UnitOfMeasurementActive = true});
            
            modelBuilder.Entity<Product>().ToTable("Product", "store");
            modelBuilder.Entity<Order>().ToTable("Order", "store");
            modelBuilder.Entity<ProductByOrder>().ToTable("ProductByOrder", "store");

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithMany(e => e.Products)
                .UsingEntity<ProductByOrder>();
        }
    }
}