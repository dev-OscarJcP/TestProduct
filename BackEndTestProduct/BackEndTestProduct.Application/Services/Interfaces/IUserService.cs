using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndTestProduct.Application.InputModels;
using BackEndTestProduct.Application.ViewModels;

namespace BackEndTestProduct.Application.Services.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> GetAll(string query);
        UserViewModel GetById(int nif);
        int Create(NewUserInputModel user);
        void Delete(int nif);
        void Update(int nif, NewUserInputModel user);


    }
}
