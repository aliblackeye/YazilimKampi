namespace InterfacesDemo
{
    class Robot : IWorker
    {
        public string Name { get; set; }

        public void Work()
        {
            System.Console.WriteLine("Robot çalışıyor.");
        }
    }
}
