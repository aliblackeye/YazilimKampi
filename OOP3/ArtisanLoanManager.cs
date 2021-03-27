using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ArtisanLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
