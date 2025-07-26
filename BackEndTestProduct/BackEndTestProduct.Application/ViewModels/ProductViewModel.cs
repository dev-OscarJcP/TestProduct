using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(string name, string description, decimal price, int stockQuantity, string category, DateTime expirationDate)
        {
            
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            Category = category;
            ExpirationDate = expirationDate;
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; }
        public DateTime ExpirationDate { get; set; }
        
    }
}
