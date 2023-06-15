using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNamespace
{
    public interface ICustomer
    {
        string Name { get; set; }
         string Address { get; set; }
         string City { get; set; }
    }
}
