using DesignPatterns.Builder;

namespace DesingPatterns.Builder
{
    public class Director
    {
        private IBuilder? builder;
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
