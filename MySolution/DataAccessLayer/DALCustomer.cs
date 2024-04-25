using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceNamespace;

namespace DataAccessLayer
{
    public class DALCustomer
    {
        public void Add(ICustomer customer)
        {
            //DB Access
        }
        public DALCustomer GetClone()
        {
            return (DALCustomer) this.MemberwiseClone();
        }
    }
}
