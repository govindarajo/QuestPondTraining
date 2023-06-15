using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using InterfaceNamespace;

namespace MiddleLayer
{
    public class Customer :ICustomer
    { 
        public string Address { get; set; }
    
        public string Name { get; set; }
        public string City { get; set; }

        public void Add()
        {
            var cusDal = new DALCustomer();
            cusDal.Add(this);
        }

    }
}
