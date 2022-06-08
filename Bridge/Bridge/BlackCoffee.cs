namespace DesignPatterns.Bridge
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int sugar) : base(sugar)
        {
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing black cofffe...");
        }
        public override void Drink()
        {
            Console.WriteLine("Drinking black coffee...");
        }
    }
}
