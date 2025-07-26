using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndTestProduct.Core.Entities;

namespace BackEndTestProduct.Infrastructure.Persistence
{
    public class AppDbContext
    {
        public AppDbContext()
        {
            new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.0m, ExpirationDate = DateTime.Now.AddMonths(1), StockQuantity = 100, IsActive = true },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 20.0m, ExpirationDate = DateTime.Now.AddMonths(2), StockQuantity = 200, IsActive = true },
                new Product { Id = 3, Name = "Product 3", Description = "Description 3", Price = 30.0m, ExpirationDate = DateTime.Now.AddMonths(3), StockQuantity = 300, IsActive = true }
            };
            new List<User>
            {
                new User { Id = 1, Nif = 12345678, Password = "password1", IsAdmin = true, IsActive = true },
                new User { Id = 2, Nif = 87654321, Password = "password2", IsAdmin = false, IsActive = true },
                new User { Id = 3, Nif = 11223344, Password = "password3", IsAdmin = false, IsActive = false }
            };
        }
        public List<Product> Products { get; set; } 
        public List<User> Users { get; set; }
    }
}
