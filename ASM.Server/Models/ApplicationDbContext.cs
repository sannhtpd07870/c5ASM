using Microsoft.EntityFrameworkCore;

namespace ASM.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API configurations

            // User Entity
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Customer Entity
            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

            // OrderDetail composite key
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.FoodItemId });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.FoodItem)
                .WithMany(fi => fi.OrderDetails)
                .HasForeignKey(od => od.FoodItemId);

            // Review composite key
            modelBuilder.Entity<Review>()
                .HasKey(r => new { r.UserId, r.FoodItemId });

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.FoodItem)
                .WithMany(fi => fi.Reviews)
                .HasForeignKey(r => r.FoodItemId);
        }
    }


}
