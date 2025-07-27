using Microsoft.EntityFrameworkCore;
using TestProduct.Models;

namespace TestProduct.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; } = null!;
    }
}
