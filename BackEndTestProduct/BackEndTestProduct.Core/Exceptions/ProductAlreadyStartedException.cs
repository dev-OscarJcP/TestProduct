using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndTestProduct.Core.Exceptions
{
    public class ProductAlreadyStartedException : Exception
    {
        public ProductAlreadyStartedException() : base("The product has already started.")
        {
        }
       
    }
}
