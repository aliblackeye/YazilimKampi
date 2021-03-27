using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   //Bireysel - Gerçek Müşteri
            //Ali Karagöz
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Ali Karagöz";
            customer1.IdentityNumber = "12345678910";


            //Kurumsal - Tüzel Müşteri
            //Karagöz Holding
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Karagöz Holding";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
