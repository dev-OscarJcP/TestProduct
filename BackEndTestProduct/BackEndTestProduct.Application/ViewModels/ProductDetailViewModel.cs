using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Application.ViewModels
{
    public class ProductDetailViewModel
    {
        public ProductDetailViewModel(int id, string name, string description, decimal price, int stockQuantity, DateTime expirationDate, string category, bool isActive)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            ExpirationDate = expirationDate;
            Category = category;
            IsActive = isActive;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Category { get; set; }
        public bool IsActive { get; set; }
    }
}
