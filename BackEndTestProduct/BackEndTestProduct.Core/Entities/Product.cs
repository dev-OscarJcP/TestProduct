using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }
        public string Category { get; set; }

        public void UpdateStock(int quantity)
        {
            if (quantity < 0 && Math.Abs(quantity) > StockQuantity)
            {
                throw new InvalidOperationException("Cannot reduce stock below zero.");
            }
            StockQuantity += quantity;
        }
        
        public void Update(string description, decimal price, int stockQuantity, bool isActive, string category)
        {
            this.Description = description;
            this.Price = price;
            this.StockQuantity = stockQuantity;
            this.IsActive = isActive;
            this.Category = category;
        }

    }
    
}
