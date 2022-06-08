namespace DesignPatterns.Bridge
{
    public class WhiteCoffee : Coffee
    {
        public WhiteCoffee(int sugar) : base(sugar)
        {
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing white coffee...");
        }
        public override void Drink()
        {
            Console.WriteLine("Drinking white coffee...");
        }
    }
}
