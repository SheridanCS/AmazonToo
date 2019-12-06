//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using Microsoft.EntityFrameworkCore.ValueGeneration;

//namespace AmazonToo.Models
//{
//    public class AmazonDbContext : DbContext
//    {
//        public AmazonDbContext(DbContextOptions<AmazonDbContext> options) : base(options) { }
//        public DbSet<Order> Order { get; set; }
//        public DbSet<OrderItem> OrderItems { get; set; }
//        public DbSet<Product> Products { get; set; }
//        public DbSet<User> Users { get; set; }
//        public DbSet<UserAddress> UserAddresses { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder
//                .Entity<Order>()
//                .Property(o => o.Id)
//                .HasValueGenerator<GuidValueGenerator>();
            
//            modelBuilder
//                .Entity<OrderItem>()
//                .HasOne(oi => oi.Order)
//                .WithMany(o => o.Items);
//            modelBuilder
//                .Entity<OrderItem>()
//                .HasOne(oi => oi.Product)
//                .WithOne(p => p.OrderItem)
//                .HasForeignKey<OrderItem>(oi => oi.ProductId);
            
//            modelBuilder
//                .Entity<User>()
//                .Property(u => u.Id)
//                .HasValueGenerator<GuidValueGenerator>();
//            modelBuilder
//                .Entity<UserAddress>()
//                .Property(ua => ua.Province)
//                .HasConversion(new EnumToStringConverter<Province>());
//            modelBuilder
//                .Entity<UserAddress>()
//                .Property(ua => ua.Country)
//                .HasConversion(new EnumToStringConverter<Country>());
////            modelBuilder.Entity<Student>()
////                .HasOne(s => s.Attend)
////                .WithOne(i => i.Student)
////                .HasForeignKey<Attend>(a => a.StudentId);

//            modelBuilder
//                .Entity<UserAddress>()
//                .HasOne(ua => ua.User)
//                .WithMany(u => u.Addresses);
//        }
//    }
//}