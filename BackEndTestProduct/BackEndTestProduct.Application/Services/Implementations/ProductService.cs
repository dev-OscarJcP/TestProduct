using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BackEndTestProduct.Application.InputModels;
using BackEndTestProduct.Application.Services.Interfaces;
using BackEndTestProduct.Application.ViewModels;
using BackEndTestProduct.Core.Entities;
using BackEndTestProduct.Infrastructure.Persistence;

namespace BackEndTestProduct.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _AppDbContext;
        public ProductService(AppDbContext dbContext)
        {
            _AppDbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public int Create(NewProductInputModel product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            var newProduct = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ExpirationDate = product.ExpirationDate,
                StockQuantity = product.StockQuantity,
                IsActive = true
            };
            _AppDbContext.Products.Add(newProduct);
            return newProduct.Id;
        }
        public void Delete(int id)
        {
            var product = _AppDbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) throw new KeyNotFoundException($"Product with ID {id} not found.");
            _AppDbContext.Products.Remove(product);
        }

        public void Update(int id, UpdateProductInputModel product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            var existingProduct = _AppDbContext.Products.SingleOrDefault(p => p.Id == id);
            if (existingProduct == null) throw new KeyNotFoundException($"Product with ID {id} not found.");

            existingProduct.Update(product.Description, product.Price, product.StockQuantity, product.IsActive, product.Category);
            new ProductDetailViewModel(existingProduct.Id, existingProduct.Name, existingProduct.Description, existingProduct.Price, existingProduct.StockQuantity, existingProduct.ExpirationDate, existingProduct.Category, existingProduct.IsActive);
        }

        public List<ProductViewModel> GetAll(string query)
        {
            var products = _AppDbContext.Products;
            var productsViewModel = products
                .Select(p => new ProductViewModel (p.Id,p.Name, p.Description, p.Price, p.StockQuantity, p.Category, p.ExpirationDate))
                .ToList();
            return productsViewModel;
        }        
        public ProductViewModel GetById(int id)
        {
            var product = _AppDbContext.Products.SingleOrDefault(p => p.Id == id);
            if (product == null) throw new KeyNotFoundException($"Product with ID {id} not found.");
            return new ProductViewModel(product.Id, product.Name, product.Description, product.Price, product.StockQuantity, product.Category, product.ExpirationDate);
            
            
        }

    }
}
