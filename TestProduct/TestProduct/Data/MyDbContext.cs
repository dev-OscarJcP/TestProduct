using Microsoft.EntityFrameworkCore;
using System;
using TestProduct.Models;

namespace TestProduct.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ProductModel> Products { get; set; } = null!;

    }
}
