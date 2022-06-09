namespace DesignPatterns.TemplateMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            var client = new Client();

            var pirate = new Pirate();

            client.DefendHero(pirate);
        }
    }
}