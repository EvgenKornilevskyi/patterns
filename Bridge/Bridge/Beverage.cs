namespace DesignPatterns.Bridge
{
    public abstract class Beverage
    {
        private readonly int _sugar;

        public Beverage(int sugar)
        {
            _sugar = sugar;
        }

        public abstract void Prepare();
        public abstract void Drink();
        public abstract int Cost();
    }
}
