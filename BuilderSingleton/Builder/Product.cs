using System.Linq;
namespace DesignPatterns.Builder
{
    public class Product
    {
        private string? dough;
        private List<string>? ingredients;
        public string? Dough
        {
            get { return dough; }
            set { dough = value; }   
        }
        public List<string> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public void ListIngredients()
        {
            ingredients.ForEach(item => Console.Write(item + " "));
        }
    }
}
