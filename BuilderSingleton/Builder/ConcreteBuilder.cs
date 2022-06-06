namespace DesignPatterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.product = new Product();
        }

        public void SetDough(string dough)
        {
            this.product.Dough = dough;
        }

        public void SetIngredients(List<string> ingridients)
        {
            this.product.Ingredients = ingridients;
        }
        public Product GetProduct()
        {
            var result = this.product;

            this.Reset();

            return result;
        }
    }
}
