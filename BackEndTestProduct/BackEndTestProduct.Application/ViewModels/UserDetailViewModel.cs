using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Application.ViewModels
{
    public class UserDetailViewModel
    {
        public UserDetailViewModel(int nif, string password, bool isAdmin, bool isActive)
        {
            Nif = nif;
            Password = password;
            IsAdmin = isAdmin;
            IsActive = isActive;
            
        }
        public int Nif { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
}
