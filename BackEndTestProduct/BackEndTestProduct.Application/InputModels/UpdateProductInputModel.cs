using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Application.InputModels
{
    public class UpdateProductInputModel
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public string Category { get; set; }
    }
}
