namespace InterfacesDemo
{
    class Worker : IWorker, IEat, ISalary
    {
        public string Name { get; set; }

        public void Eat()
        {
            System.Console.WriteLine("İşçi yiyor.");
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            System.Console.WriteLine("İşçi çalışıyor.");
        }
    }
}
