namespace DesignPatterns.Bridge
{
    public abstract class Coffee : Beverage
    {
        public Coffee(int sugar) : base(sugar)
        {
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing coffee...");
        }
        public override int Cost()
        {
            return 10;
        }
    }
}
