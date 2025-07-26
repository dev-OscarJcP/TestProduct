using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Core.Exceptions
{
    public class UserAlreadyStartedException : Exception
    {
        public UserAlreadyStartedException() : base("The user has already started.")
        {
        }
    }
}
