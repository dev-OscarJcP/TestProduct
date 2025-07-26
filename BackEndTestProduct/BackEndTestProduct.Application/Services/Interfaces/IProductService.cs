using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndTestProduct.Application.InputModels;
using BackEndTestProduct.Application.ViewModels;

namespace BackEndTestProduct.Application.Services.Interfaces
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll(string query);
        ProductViewModel GetById(int id);
        int Create(NewProductInputModel product);
        void Delete(int id);
        void Update(int id, UpdateProductInputModel product);
    }
}
