using DesingPatterns.Builder;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = Director.GetDirector();
            var builder = new ConcreteBuilder();

            director.Builder = builder;

            Console.WriteLine("StandarPizza ingredients: ");
            director.BuildStandartProduct();
            builder.GetProduct().ListIngredients();
        }
    }
}