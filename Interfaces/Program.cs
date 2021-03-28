using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            SqlCustomerDal sqlCustomerDal = new SqlCustomerDal();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            MySqlCustomerDal mySqlCustomerDal = new MySqlCustomerDal();
            //customerManager.Add(sqlCustomerDal);

            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Ali",
            //    LastName = "Karagöz",
            //    Address = "İstanbul"
            //};

            //Student student = new Student
            //{
            //    Id = 1,
            //    FirstName = "Sefa",
            //    LastName = "Kılıç",

            //};

            //manager.Add(student);


            ICustomerDal[] customerDals = new ICustomerDal[3] {sqlCustomerDal,oracleCustomerDal,mySqlCustomerDal};

            foreach (var customerdal in customerDals)
            {
                customerdal.Add();
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
