using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager
    {
        //Method Injection
        public void Apply(ILoanManager loanManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            //
            
            loanManager.Calculate();
            loggerService.Log();
           

        }

        public void LoanPreInfo(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
