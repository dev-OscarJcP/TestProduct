using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndTestProduct.Application.ViewModels;

namespace BackEndTestProduct.Application.Services.Interfaces
{
    public interface IUserService
    {
        List<string> GetAll();
        UserViewModel GetById(int id);
        int Create(string name, string email, string password);
        void Delete(int id);
        void Update(string password, Boolean isAdmin);


    }
}
