using DesignPatterns.Builder;

namespace DesingPatterns.Builder
{
    public class Director
    {
        private static Director director;
        private static readonly object _lock = new object();

        private IBuilder? builder;
        private Director() { }
        public static Director GetDirector()
        {
            if(director == null)
            {
                lock (_lock)
                {
                    if(director == null)
                    {
                        director = new Director();
                    }
                }
            }
            return director;
        }
        public IBuilder Builder
        {
            set { builder = value; }    
        }
        public void BuildStandartProduct()
        {
            var ingredients = new List<string>()
            {
                "Olives", "Tomatoes", "Sausages"
            };
            this.builder.SetDough("StandartPizza");
            this.builder.SetIngredients(ingredients);
        }
        public void BuildProductWithNoIngredients()
        {
            this.builder.SetDough("NoIngredientsPizza");
        }
    }
}
