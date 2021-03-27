using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager artisanLoanManager = new ArtisanLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

           



            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(artisanLoanManager,smsLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager,vehicleLoanManager };

            //applyManager.LoanPreInfo(loans);
        }
    }
}
