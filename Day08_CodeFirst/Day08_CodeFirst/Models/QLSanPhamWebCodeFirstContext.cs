using Microsoft.EntityFrameworkCore;

namespace Day08_CodeFirst.Models
{
    public class QLSanPhamWebCodeFirstContext : DbContext
    {
        public QLSanPhamWebCodeFirstContext(DbContextOptions<QLSanPhamWebCodeFirstContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
       
    }
}
