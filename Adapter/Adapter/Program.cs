namespace DesignPatterns.Adapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var auto = new Auto("Car", 15, 0.1f, 100);

            var ukrainianCustoms = new UkrainianCustoms(auto);
            var adapter = new Adapter(ukrainianCustoms);

            Console.WriteLine(adapter.calculatePrice());
        }
    }
}

