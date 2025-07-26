using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Application.InputModels
{
    public class NewProductInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }


    }
}
