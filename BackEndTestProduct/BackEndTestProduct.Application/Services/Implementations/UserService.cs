using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndTestProduct.Application.InputModels;
using BackEndTestProduct.Application.Services.Interfaces;
using BackEndTestProduct.Application.ViewModels;
using BackEndTestProduct.Core.Entities;
using BackEndTestProduct.Infrastructure.Persistence;

namespace BackEndTestProduct.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;
        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
        }
        public int Create(NewUserInputModel user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            var newUser = new User
            {
                Nif = user.Nif,
                Password = user.Password,
                IsAdmin = user.IsAdmin
            };
            _appDbContext.Users.Add(newUser);
            return newUser.Id;
        }
        public void Delete(int nif)
        {
            var user = _appDbContext.Users.FirstOrDefault(u => u.Id == nif);
            if (user == null) throw new KeyNotFoundException($"User with ID {nif} not found.");
            _appDbContext.Users.Remove(user);
        }
        public void Update(int nif, UpdateUserInputModel user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            var existingUser = _appDbContext.Users.SingleOrDefault(u => u.Id == nif);

            if (existingUser == null) throw new KeyNotFoundException($"User with ID {nif} not found.");

            existingUser.Update(user.Password, user.IsAdmin);
            new UserViewModel(existingUser.Nif, existingUser.IsActive, existingUser.IsAdmin);

        }
        public List<UserViewModel> GetAll(string query)
        {
            var users = _appDbContext.Users;
            var userViewModel = users
                .Select(p => new UserViewModel(p.Nif, p.IsActive, p.IsAdmin))
                .ToList();
            return userViewModel;
        }
        public UserViewModel GetById(int id)
        {
            var user = _appDbContext.Users.SingleOrDefault(p => p.Id == id);
            if (user == null) throw new KeyNotFoundException($"User with ID {id} not found.");
            return new UserViewModel(user.Nif, user.IsActive, user.IsAdmin);
            
        }
    } 
}
