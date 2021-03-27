using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Bireysel - Gerçek
    //Miras - Inheritance
    class IndividualCustomer:Customer
    {
        public string IdentityNumber { get; set; }
        public string CustomerName { get; set; }
    }
}
