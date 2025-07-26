using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int nif, bool isAdmin, bool isActive)
        {
            Nif = nif;
            IsAdmin = isAdmin;
            IsActive = isActive;
        }
        public int Nif { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        
    }
}
