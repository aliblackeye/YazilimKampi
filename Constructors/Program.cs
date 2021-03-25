using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,FirstName="Ali",LastName="Karagöz",City="Ankara" };
        }
    }  

    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı.");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
