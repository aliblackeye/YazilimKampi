namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public string Name { get; set; }

        public void Eat()
        {
            System.Console.WriteLine("Yönetici yiyor.");
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            System.Console.WriteLine("Yönetici çalışıyor.");
        }
    }
}
